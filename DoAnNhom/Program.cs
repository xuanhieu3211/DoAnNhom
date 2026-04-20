using DoAnNhom;
using MCplaylist;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using WMPLib; // Thư viện điều khiển Windows Media Player ngầm

namespace MCplaylist
{// --- 1. SINGLE LINKED LIST (Dùng cho Lịch sử nghe nhạc) ---
    public class SNode
    {
        public object data;
        public SNode link;
        public SNode(object data) { this.data = data; this.link = null; }
    }
    public class SingleLinkedList
    {
        public SNode header;
        public SingleLinkedList() { this.header = new SNode("HistoryHeader"); }

        // Thêm bài mới vào ĐẦU danh sách (Bài vừa nghe xong hiện lên trên cùng)
        public void AddFirst(string filePath)
        {
            SNode newNode = new SNode(filePath);
            newNode.link = header.link;
            header.link = newNode;
        }
    }
    public class Playlist
    {
        private List<string> tracks = new List<string>();

        public int CurrentIndex { get; private set; } = -1;

        public void Add(string filePath)
        {
            // Nếu filePath hợp lệ thì mới thêm vào
            if (filePath != null)
            {
                tracks.Add(filePath);

                if (CurrentIndex == -1)
                {
                    CurrentIndex = 0;
                }
            }
        }
        public int Count => tracks.Count;
        public string GetAt(int index) => (index >= 0 && index < tracks.Count) ? tracks[index] : null;
    }
    // 1. LỚP NODE: Đóng vai trò là một "mắt xích" trong danh sách
    public class DNode
    {
        public object data;   // Biến lưu trữ đường dẫn tệp nhạc (Path)
        public DNode next;    // Con trỏ trỏ đến bài hát tiếp theo
        public DNode prev;    // Con trỏ trỏ về bài hát phía trước

        // Hàm khởi tạo Node với dữ liệu truyền vào
        public DNode(object data)
        {
            this.data = data;
            this.next = null;
            this.prev = null;
        }
    }
    // 2. LỚP DANH SÁCH LIÊN KẾT ĐÔI: Quản lý toàn bộ hàng đợi nhạc
    public class DoubleLinkedList
    {
        public DNode header;       // Nút gốc (làm mốc định vị đầu danh sách)
        public DNode currentTrack; // Biến lưu trữ bài hát đang được chọn để phát

        public DoubleLinkedList()
        {
            this.header = new DNode("Header"); // Khởi tạo mốc giả (Header)
            this.currentTrack = null;          // Ban đầu chưa có bài nào phát
        }

        // Hàm thêm một bài hát mới vào cuối danh sách
        public void AddTrack(string filePath)
        {
            DNode current = header;
            // Duyệt từ đầu đến cuối danh sách để tìm nút cuối cùng
            while (current.next != null) current = current.next;

            DNode newNode = new DNode(filePath); // Tạo nút mới chứa đường dẫn nhạc
            newNode.prev = current;              // Nối ngược về nút cũ
            current.next = newNode;              // Nút cũ nối tiến đến nút mới

            // Nếu đây là bài đầu tiên được thêm, chọn nó làm bài phát mặc định
            if (currentTrack == null) currentTrack = newNode;
        }
    }
    // 3. LỚP QUẢN LÝ PHÁT NHẠC (MODEL): Kết nối Logic và Trình phát WMP
    public class MyPlaylistManager
    {
        private DoubleLinkedList playlist;  // Đối tượng quản lý danh sách nhạc
        private WindowsMediaPlayer wmpEngine; // Đối tượng điều khiển trình phát ngầm
                                              // 1. Lấy tổng thời lượng bài hát (tính bằng giây)
        public double GetDuration()
        {
            if (wmpEngine.currentMedia != null)
                return wmpEngine.currentMedia.duration;
            return 0;
        }

        // 2. Lấy vị trí thời gian hiện tại (tính bằng giây)
        public double GetCurrentPosition()
        {
            if (wmpEngine.currentMedia != null)
                return wmpEngine.controls.currentPosition;
            return 0;
        }

        // 3. Tua bài hát đến một vị trí cụ thể (tính bằng giây)
        public void SetCurrentPosition(double positionSeconds)
        {
            if (wmpEngine.currentMedia != null)
                wmpEngine.controls.currentPosition = positionSeconds;
        }
        public MyPlaylistManager()
        {
            playlist = new DoubleLinkedList();    // Khởi tạo danh sách
            wmpEngine = new WindowsMediaPlayer(); // Khởi tạo bộ máy WMP
            wmpEngine.settings.autoStart = false; // Tắt chế độ tự phát khi vừa nạp file
        }

        public DNode Find(object value)
        {
            if (playlist == null || playlist.header == null) return null;
            DNode current = playlist.header;
            while (current != null && !object.Equals(current.data, value))
                current = current.next;
            return current;
        }
        public void Insert(object newdata, object afterelement)
        {
            DNode afterNode = Find(afterelement);
            if (afterNode != null)
            {
                DNode newNode = new DNode(newdata);
                newNode.next = afterNode.next;
                newNode.prev = afterNode;
                if (afterNode.next != null) afterNode.next.prev = newNode;
                afterNode.next = newNode;
            }
        }
        // Hàm gọi từ Form để thêm nhạc
        public void AddMusic(string filePath) => playlist.AddTrack(filePath);

        // Hàm thực hiện phát nhạc của bài hiện tại
        public void Play()
        {
            if (playlist.currentTrack != null)
            {
                // Nạp đường dẫn file từ Node vào WMP và ra lệnh Play
                wmpEngine.URL = playlist.currentTrack.data.ToString();
                wmpEngine.controls.play();
            }
        }
        // Hàm tạm dừng nhạc
        public void Pause() => wmpEngine.controls.pause();

        // Hàm chuyển sang bài tiếp theo
        public void NextTrack()
        {
            // Kiểm tra nếu có bài tiếp theo thì mới chuyển
            if (playlist.currentTrack != null && playlist.currentTrack.next != null)
            {
                playlist.currentTrack = playlist.currentTrack.next; // Dịch chuyển con trỏ
                Play(); // Phát bài mới ngay lập tức
            }
        }
        // Hàm quay lại bài trước đó
        public void PreviousTrack()
        {
            // Kiểm tra bài trước tồn tại và không phải là nút Header giả
            if (playlist.currentTrack != null && playlist.currentTrack.prev != null && playlist.currentTrack.prev != playlist.header)
            {
                playlist.currentTrack = playlist.currentTrack.prev; // Dịch chuyển con trỏ lùi lại
                Play(); // Phát bài
            }
        }
        // --- THÊM VÀO TRONG CLASS MyPlaylistManager ---

        // Hàm 1: Xóa bài hát tại một vị trí (Index) cụ thể
        public void RemoveTrackAt(int index)
        {
            if (playlist.header.next == null) return; // Danh sách trống

            DNode current = playlist.header.next; // Bắt đầu từ Node đầu tiên có dữ liệu (bỏ qua Header)
            int count = 0;

            while (current != null)
            {
                if (count == index)
                {
                    // Ngắt kết nối để xóa Node
                    if (current.prev != null) current.prev.next = current.next;
                    if (current.next != null) current.next.prev = current.prev;

                    // Nếu bài đang phát bị xóa, chuyển sang bài tiếp theo (hoặc lùi lại nếu là bài cuối)
                    if (playlist.currentTrack == current)
                    {
                        Pause(); // Dừng nhạc
                        playlist.currentTrack = current.next ?? current.prev; // Ưu tiên bài sau, không có thì lùi

                        // Nếu danh sách không rỗng (khác header) thì phát tiếp
                        if (playlist.currentTrack != playlist.header && playlist.currentTrack != null)
                        {
                            Play();
                        }
                    }
                    return;
                }
                count++;
                current = current.next;
            }
        }

        // Hàm 2: Phát bài hát khi click chọn trên ListBox
        public void PlayTrackAt(int index)
        {
            DNode current = playlist.header.next;
            int count = 0;
            while (current != null)
            {
                if (count == index)
                {
                    playlist.currentTrack = current; // Đặt con trỏ vào bài được chọn
                    // NOTE: Do not auto-play here when called from UI that manages playback control.
                    // Use Play() explicitly to start playback.
                    return;
                }
                count++;
                current = current.next;
            }
        }

        // Set current track pointer without starting playback (UI will handle actual playback)
        public void SetCurrentTrackAt(int index)
        {
            DNode current = playlist.header.next;
            int count = 0;
            while (current != null)
            {
                if (count == index)
                {
                    playlist.currentTrack = current;
                    return;
                }
                count++;
                current = current.next;
            }
        }
    }
    // 4. LỚP CHƯƠNG TRÌNH CHÍNH: Điểm khởi chạy của Windows Forms
    internal static class Program
    {
        [STAThread] // Thuộc tính bắt buộc để chạy giao diện Windows mượt mà
        static void Main()
        {
            Application.SetCompatibleTextRenderingDefault(false);

            Application.Run(new Form1());
        }
    }
}