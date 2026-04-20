

namespace DoAnNhom
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            ListNhac = new ListBox();
            history = new ListBox();
            textBox1 = new TextBox();
            MusicPlayomg = new TextBox();
            playing = new TextBox();
            Exit = new Button();
            axWindowsMediaPlayer1 = new AxWMPLib.AxWindowsMediaPlayer();
            previous = new Button();
            play = new Button();
            pause = new Button();
            ADD = new Button();
            Remove = new Button();
            KeoLen = new Button();
            KeoXuong = new Button();
            Saudo = new Button();
            label1 = new Label();
            TxtSearch = new TextBox();
            pictureBox1 = new PictureBox();
            Them_Anh = new Button();
            pictureBox2 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ListNhac
            // 
            ListNhac.BackColor = Color.MistyRose;
            ListNhac.Font = new Font("Minecraft", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ListNhac.FormattingEnabled = true;
            ListNhac.Location = new Point(702, 54);
            ListNhac.Name = "ListNhac";
            ListNhac.Size = new Size(314, 498);
            ListNhac.TabIndex = 0;
            ListNhac.SelectedIndexChanged += ListNhac_SelectedIndexChanged;
            // 
            // history
            // 
            history.Font = new Font("Minecraft", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            history.FormattingEnabled = true;
            history.Location = new Point(702, 54);
            history.Name = "history";
            history.Size = new Size(314, 498);
            history.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.Bisque;
            textBox1.Font = new Font("Minecraft", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.Location = new Point(780, 19);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 29);
            textBox1.TabIndex = 2;
            textBox1.Text = "Your List";
            // 
            // MusicPlayomg
            // 
            MusicPlayomg.BackColor = Color.YellowGreen;
            MusicPlayomg.Font = new Font("Minecraft", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MusicPlayomg.Location = new Point(111, 601);
            MusicPlayomg.Multiline = true;
            MusicPlayomg.Name = "MusicPlayomg";
            MusicPlayomg.Size = new Size(563, 40);
            MusicPlayomg.TabIndex = 3;
            MusicPlayomg.TextChanged += MusicPlayomg_TextChanged;
            // 
            // playing
            // 
            playing.BackColor = Color.Pink;
            playing.Font = new Font("Minecraft", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            playing.Location = new Point(12, 601);
            playing.Multiline = true;
            playing.Name = "playing";
            playing.Size = new Size(80, 40);
            playing.TabIndex = 4;
            playing.Text = "Playing";
            // 
            // Exit
            // 
            Exit.BackgroundImage = Properties.Resources._2de928a6b9fe4026caeec0fd810062f1c251fb97;
            Exit.BackgroundImageLayout = ImageLayout.Stretch;
            Exit.Location = new Point(1009, 601);
            Exit.Name = "Exit";
            Exit.Size = new Size(50, 50);
            Exit.TabIndex = 5;
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(12, 12);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(662, 499);
            axWindowsMediaPlayer1.TabIndex = 7;
            // 
            // previous
            // 
            previous.BackgroundImage = Properties.Resources.previous;
            previous.BackgroundImageLayout = ImageLayout.Stretch;
            previous.Location = new Point(25, 489);
            previous.Name = "previous";
            previous.Size = new Size(80, 78);
            previous.TabIndex = 9;
            previous.UseVisualStyleBackColor = true;
            previous.Click += previous_Click;
            // 
            // play
            // 
            play.BackgroundImage = Properties.Resources.play;
            play.BackgroundImageLayout = ImageLayout.Stretch;
            play.Location = new Point(132, 489);
            play.Name = "play";
            play.Size = new Size(80, 78);
            play.TabIndex = 10;
            play.UseVisualStyleBackColor = true;
            play.Click += play_Click;
            // 
            // pause
            // 
            pause.BackgroundImage = Properties.Resources.stop;
            pause.BackgroundImageLayout = ImageLayout.Stretch;
            pause.Location = new Point(252, 489);
            pause.Name = "pause";
            pause.Size = new Size(83, 78);
            pause.TabIndex = 11;
            pause.UseVisualStyleBackColor = true;
            pause.Click += pause_Click;
            // 
            // ADD
            // 
            ADD.BackColor = Color.Bisque;
            ADD.Font = new Font("Minecraft", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ADD.Location = new Point(702, 479);
            ADD.Name = "ADD";
            ADD.Size = new Size(162, 73);
            ADD.TabIndex = 13;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = false;
            ADD.Click += ADD_Click;
            // 
            // Remove
            // 
            Remove.BackColor = Color.Bisque;
            Remove.Font = new Font("Minecraft", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Remove.Location = new Point(870, 479);
            Remove.Name = "Remove";
            Remove.Size = new Size(146, 73);
            Remove.TabIndex = 14;
            Remove.Text = "REMOVE";
            Remove.UseVisualStyleBackColor = false;
            Remove.Click += Remove_Click;
            // 
            // KeoLen
            // 
            KeoLen.BackgroundImage = Properties.Resources.go_up;
            KeoLen.BackgroundImageLayout = ImageLayout.Stretch;
            KeoLen.Location = new Point(965, 218);
            KeoLen.Name = "KeoLen";
            KeoLen.Size = new Size(51, 56);
            KeoLen.TabIndex = 15;
            KeoLen.UseVisualStyleBackColor = true;
            KeoLen.Click += KeoLen_Click;
            // 
            // KeoXuong
            // 
            KeoXuong.BackgroundImage = Properties.Resources.go_down;
            KeoXuong.BackgroundImageLayout = ImageLayout.Stretch;
            KeoXuong.Location = new Point(965, 280);
            KeoXuong.Name = "KeoXuong";
            KeoXuong.Size = new Size(51, 66);
            KeoXuong.TabIndex = 16;
            KeoXuong.UseVisualStyleBackColor = true;
            KeoXuong.Click += KeoXuong_Click;
            // 
            // Saudo
            // 
            Saudo.BackColor = SystemColors.ActiveCaption;
            Saudo.BackgroundImage = Properties.Resources.next;
            Saudo.BackgroundImageLayout = ImageLayout.Stretch;
            Saudo.Location = new Point(375, 489);
            Saudo.Name = "Saudo";
            Saudo.Size = new Size(86, 78);
            Saudo.TabIndex = 18;
            Saudo.UseVisualStyleBackColor = false;
            Saudo.Click += Saudo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.MistyRose;
            label1.Font = new Font("Minecraft", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(701, 563);
            label1.Name = "label1";
            label1.Size = new Size(83, 19);
            label1.TabIndex = 21;
            label1.Text = "Search";
            // 
            // TxtSearch
            // 
            TxtSearch.BackColor = Color.PeachPuff;
            TxtSearch.Font = new Font("Minecraft", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            TxtSearch.Location = new Point(701, 585);
            TxtSearch.Multiline = true;
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(272, 28);
            TxtSearch.TabIndex = 22;
            TxtSearch.TextChanged += TxtSearch_TextChanged_1;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(662, 457);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // Them_Anh
            // 
            Them_Anh.BackgroundImage = Properties.Resources.them_anh;
            Them_Anh.BackgroundImageLayout = ImageLayout.Stretch;
            Them_Anh.Location = new Point(619, 530);
            Them_Anh.Name = "Them_Anh";
            Them_Anh.Size = new Size(55, 52);
            Them_Anh.TabIndex = 24;
            Them_Anh.UseVisualStyleBackColor = true;
            Them_Anh.Click += Them_Anh_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = Properties.Resources.Background;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(12, 479);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(662, 103);
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BACKGROUND__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1055, 653);
            Controls.Add(Them_Anh);
            Controls.Add(Saudo);
            Controls.Add(pause);
            Controls.Add(play);
            Controls.Add(previous);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Controls.Add(TxtSearch);
            Controls.Add(label1);
            Controls.Add(KeoXuong);
            Controls.Add(KeoLen);
            Controls.Add(Remove);
            Controls.Add(ADD);
            Controls.Add(Exit);
            Controls.Add(playing);
            Controls.Add(MusicPlayomg);
            Controls.Add(textBox1);
            Controls.Add(ListNhac);
            Controls.Add(history);
            Controls.Add(axWindowsMediaPlayer1);
            Name = "Form1";
            Text = "McPlayList";
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ListNhac;
        private ListBox history;
        private TextBox textBox1;
        private TextBox MusicPlayomg;
        private TextBox playing;
        private Button Exit;
        private AxWMPLib.AxWindowsMediaPlayer axWindowsMediaPlayer1;
        private Button previous;
        private Button play;
        private Button pause;
        private Button ADD;
        private Button Remove;
        private Button KeoLen;
        private Button KeoXuong;
        private Button Saudo;
        private MenuStrip menuStrip1;
        private Label label1;
        private TextBox TxtSearch;
        private PictureBox pictureBox1;
        private Button Them_Anh;
        private PictureBox pictureBox2;
    }
}
