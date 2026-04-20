using MCplaylist;
using System.IO;
using System.Collections.Generic;
using System;
using System.Drawing;
using System.Windows.Forms;
using WMPLib;

namespace DoAnNhom
{
    public partial class Form1 : Form
    {
        private MyPlaylistManager player;
        private bool suppressListSelectionPlayback = false;

        private List<string> filePaths = new List<string>();

        // BỘ TỪ ĐIỂN NGẦM: Ánh xạ vị trí trên giao diện tìm kiếm với vị trí gốc
        private List<int> displayedIndices = new List<int>();

        public Form1()
        {
            InitializeComponent();
            player = new MyPlaylistManager();

            // Tự động gắn sự kiện tìm kiếm cho TextBox bạn vừa kéo thả
            if (TxtSearch != null)
            {
                TxtSearch.TextChanged += TxtSearch_TextChanged_1;
            }

            // Đăng ký sự kiện của Windows Media Player
            if (axWindowsMediaPlayer1 != null)
            {
                axWindowsMediaPlayer1.PositionChange += AxWindowsMediaPlayer1_PositionChange;
                axWindowsMediaPlayer1.PlayStateChange += AxWindowsMediaPlayer1_PlayStateChange;
            }
        }
        private void AxWindowsMediaPlayer1_PlayStateChange(object sender, AxWMPLib._WMPOCXEvents_PlayStateChangeEvent e)
        {
            WMPPlayState state = (WMPPlayState)e.newState;
            if (this.play != null) this.play.Enabled = state != WMPPlayState.wmppsPlaying;
            if (this.pause != null) this.pause.Enabled = state == WMPPlayState.wmppsPlaying;
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = "Media Files|*.mp3;*.mp4;*.wav";
            openFile.Multiselect = true;

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                foreach (string path in openFile.FileNames)
                {
                    filePaths.Add(path);
                    player.AddMusic(path); // Thêm vào Double Linked List ngầm
                }
                RefreshListBox(); // Hiển thị lên danh sách
            }
        }

        private void Remove_Click(object sender, EventArgs e)
        {
            if (ListNhac.SelectedIndex != -1)
            {
                // Lấy vị trí GỐC thông qua bộ từ điển
                int realIndex = displayedIndices[ListNhac.SelectedIndex];

                player.RemoveTrackAt(realIndex);
                filePaths.RemoveAt(realIndex);

                RefreshListBox(); // Tải lại danh sách sau khi xóa
            }
            else
            {
                MessageBox.Show("Vui lòng chọn một bài hát để xóa!");
            }
        }

        private void KeoLen_Click(object sender, EventArgs e)
        {
            if (ListNhac.SelectedIndex > 0)
            {
                suppressListSelectionPlayback = true;
                ListNhac.SelectedIndex--;
                suppressListSelectionPlayback = false;
            }
        }

        private void KeoXuong_Click(object sender, EventArgs e)
        {
            if (ListNhac.SelectedIndex < ListNhac.Items.Count - 1)
            {
                suppressListSelectionPlayback = true;
                ListNhac.SelectedIndex++;
                suppressListSelectionPlayback = false;
            }
        }

        private void ListNhac_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ListNhac.SelectedIndex != -1)
            {
                if (suppressListSelectionPlayback) return;

                // Giải mã vị trí ẢO trên giao diện thành vị trí THẬT
                int realIdx = displayedIndices[ListNhac.SelectedIndex];
                PlayAtIndex(realIdx);
            }
        }

        private void previous_Click(object sender, EventArgs e)
        {
            if (ListNhac.Items.Count == 0) return;

            int idx = ListNhac.SelectedIndex;
            if (idx > 0)
            {
                ListNhac.SelectedIndex = idx - 1; // Nhảy vệt xanh (sẽ tự kích hoạt nhạc)
            }
            else if (idx == 0)
            {
                ListNhac.SelectedIndex = ListNhac.Items.Count - 1; // Vòng lặp
            }
        }

        private void Saudo_Click(object sender, EventArgs e)
        {
            if (ListNhac.Items.Count == 0) return;

            int idx = ListNhac.SelectedIndex;

            if (idx < 0 && ListNhac.Items.Count > 0)
                ListNhac.SelectedIndex = 0;
            else if (idx < ListNhac.Items.Count - 1)
                ListNhac.SelectedIndex = idx + 1; // Nhảy vệt xanh (sẽ tự kích hoạt nhạc)
            else
                ListNhac.SelectedIndex = 0; // Vòng lặp
        }

        private void play_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1 != null && axWindowsMediaPlayer1.playState == WMPPlayState.wmppsPlaying) return;

            int sel = ListNhac.SelectedIndex;

            if (sel >= 0 && sel < ListNhac.Items.Count)
            {
                int realIdx = displayedIndices[sel]; // Dịch ngược Index

                if (axWindowsMediaPlayer1 != null && string.Equals(axWindowsMediaPlayer1.URL, filePaths[realIdx], StringComparison.OrdinalIgnoreCase)
                    && axWindowsMediaPlayer1.playState == WMPPlayState.wmppsPaused)
                {
                    axWindowsMediaPlayer1.Ctlcontrols.play();
                    return;
                }
                PlayAtIndex(realIdx);
                return;
            }

            if (ListNhac.Items.Count > 0 && ListNhac.SelectedIndex == -1)
            {
                ListNhac.SelectedIndex = 0;
            }
        }

        private void pause_Click(object sender, EventArgs e)
        {
            if (axWindowsMediaPlayer1 != null && axWindowsMediaPlayer1.Ctlcontrols != null)
            {
                axWindowsMediaPlayer1.Ctlcontrols.pause();
            }
        }

        private void AxWindowsMediaPlayer1_PositionChange(object sender, AxWMPLib._WMPOCXEvents_PositionChangeEvent e)
        {
            if (player != null) player.SetCurrentPosition((int)e.newPosition);
        }

        private void PlayAtIndex(int realIdx)
        {
            if (realIdx < 0 || realIdx >= filePaths.Count) return;

            player.SetCurrentTrackAt(realIdx);
            this.MusicPlayomg.Text = Path.GetFileName(filePaths[realIdx]);

            if (axWindowsMediaPlayer1 == null) return;
            var ctl = axWindowsMediaPlayer1.Ctlcontrols;

            bool sameUrl = string.Equals(axWindowsMediaPlayer1.URL, filePaths[realIdx], StringComparison.OrdinalIgnoreCase);
            if (sameUrl && axWindowsMediaPlayer1.playState == WMPPlayState.wmppsPaused)
            {
                ctl.play();
                return;
            }

            if (ctl != null) ctl.stop();

            axWindowsMediaPlayer1.URL = filePaths[realIdx];
            if (ctl != null) ctl.play();
        }

        private void Exit_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn có muốn thoát không :(?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
            if (result == DialogResult.Yes) this.Close();
        }

        private void MusicPlayomg_TextChanged(object sender, EventArgs e) { }

        private void TxtSearch_TextChanged_1(object sender, EventArgs e)
        {
            RefreshListBox();
        }
        private void RefreshListBox()
        {
            suppressListSelectionPlayback = true; // Khóa nhạc để không phát lung tung khi load

            ListNhac.Items.Clear();
            displayedIndices.Clear();

            // Lấy chữ từ TextBox bạn kéo thả
            string keyword = TxtSearch != null ? TxtSearch.Text.ToLower() : "";

            for (int i = 0; i < filePaths.Count; i++)
            {
                string fileName = Path.GetFileName(filePaths[i]);

                // Nếu ô tìm kiếm trống, hoặc tên file có chứa từ khóa
                if (string.IsNullOrEmpty(keyword) || fileName.ToLower().Contains(keyword))
                {
                    ListNhac.Items.Add(fileName); // Đưa lên giao diện
                    displayedIndices.Add(i);      // Lưu lại vị trí GỐC
                }
            }

            suppressListSelectionPlayback = false; // Mở khóa
        }

        private void Them_Anh_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFile = new OpenFileDialog();
            // Chỉ lọc ra các file ảnh (bao gồm cả gif)
            openFile.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFile.ShowDialog() == DialogResult.OK)
            {
                // 1. Dọn dẹp ảnh cũ (nếu có) để giải phóng bộ nhớ
                if (pictureBox1.Image != null)
                {
                    pictureBox1.Image.Dispose();
                }

                // 2. Load ảnh mới (kể cả GIF động) vào PictureBox
                pictureBox1.Image = Image.FromFile(openFile.FileName);

                // 3. Chỉnh cho ảnh vừa vặn với khung
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }
    }
}