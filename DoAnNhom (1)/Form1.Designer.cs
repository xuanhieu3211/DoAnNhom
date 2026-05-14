

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
            KeoXuong = new Button();
            Saudo = new Button();
            label1 = new Label();
            TxtSearch = new TextBox();
            pictureBox1 = new PictureBox();
            Them_Anh = new Button();
            pictureBox2 = new PictureBox();
            KeoLen = new Button();
            ((System.ComponentModel.ISupportInitialize)axWindowsMediaPlayer1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // ListNhac
            // 
            ListNhac.BackColor = Color.Gray;
            ListNhac.Font = new Font("Minecraft", 8.25F, FontStyle.Bold, GraphicsUnit.Point, 163);
            ListNhac.ForeColor = SystemColors.ButtonHighlight;
            ListNhac.FormattingEnabled = true;
            ListNhac.Location = new Point(702, 44);
            ListNhac.Name = "ListNhac";
            ListNhac.Size = new Size(316, 460);
            ListNhac.TabIndex = 0;
            ListNhac.SelectedIndexChanged += ListNhac_SelectedIndexChanged;
            // 
            // history
            // 
            history.Font = new Font("Minecraft", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            history.FormattingEnabled = true;
            history.Location = new Point(702, 44);
            history.Name = "history";
            history.Size = new Size(314, 498);
            history.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.DarkOliveGreen;
            textBox1.Font = new Font("Minecraft", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            textBox1.ForeColor = SystemColors.Info;
            textBox1.Location = new Point(804, 17);
            textBox1.Multiline = true;
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(117, 21);
            textBox1.TabIndex = 2;
            textBox1.Text = " Your List";
            // 
            // MusicPlayomg
            // 
            MusicPlayomg.BackColor = Color.LemonChiffon;
            MusicPlayomg.Font = new Font("Minecraft", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            MusicPlayomg.Location = new Point(111, 601);
            MusicPlayomg.Multiline = true;
            MusicPlayomg.Name = "MusicPlayomg";
            MusicPlayomg.Size = new Size(563, 40);
            MusicPlayomg.TabIndex = 3;
            MusicPlayomg.TextChanged += MusicPlayomg_TextChanged;
            // 
            // playing
            // 
            playing.BackColor = Color.DarkOliveGreen;
            playing.Font = new Font("Minecraft", 9.75F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point, 163);
            playing.Location = new Point(12, 601);
            playing.Multiline = true;
            playing.Name = "playing";
            playing.Size = new Size(93, 40);
            playing.TabIndex = 4;
            playing.Text = " Playing";
            // 
            // Exit
            // 
            Exit.BackgroundImage = Properties.Resources._2de928a6b9fe4026caeec0fd810062f1c251fb97;
            Exit.BackgroundImageLayout = ImageLayout.Stretch;
            Exit.FlatStyle = FlatStyle.Flat;
            Exit.Location = new Point(1038, 609);
            Exit.Name = "Exit";
            Exit.Size = new Size(43, 40);
            Exit.TabIndex = 5;
            Exit.UseVisualStyleBackColor = true;
            Exit.Click += Exit_Click;
            // 
            // axWindowsMediaPlayer1
            // 
            axWindowsMediaPlayer1.Enabled = true;
            axWindowsMediaPlayer1.Location = new Point(12, 13);
            axWindowsMediaPlayer1.Name = "axWindowsMediaPlayer1";
            axWindowsMediaPlayer1.OcxState = (AxHost.State)resources.GetObject("axWindowsMediaPlayer1.OcxState");
            axWindowsMediaPlayer1.Size = new Size(662, 499);
            axWindowsMediaPlayer1.TabIndex = 7;
            // 
            // previous
            // 
            previous.BackgroundImage = (Image)resources.GetObject("previous.BackgroundImage");
            previous.BackgroundImageLayout = ImageLayout.Stretch;
            previous.FlatStyle = FlatStyle.Flat;
            previous.ForeColor = SystemColors.ButtonHighlight;
            previous.Location = new Point(118, 504);
            previous.Name = "previous";
            previous.Size = new Size(76, 63);
            previous.TabIndex = 9;
            previous.UseVisualStyleBackColor = true;
            previous.Click += previous_Click;
            // 
            // play
            // 
            play.BackgroundImage = Properties.Resources.play;
            play.BackgroundImageLayout = ImageLayout.Stretch;
            play.FlatStyle = FlatStyle.Flat;
            play.ForeColor = SystemColors.ControlLightLight;
            play.Location = new Point(227, 498);
            play.Name = "play";
            play.Size = new Size(68, 69);
            play.TabIndex = 10;
            play.UseVisualStyleBackColor = true;
            play.Click += play_Click;
            // 
            // pause
            // 
            pause.BackgroundImage = Properties.Resources.stop;
            pause.BackgroundImageLayout = ImageLayout.Stretch;
            pause.FlatStyle = FlatStyle.Flat;
            pause.ForeColor = SystemColors.ButtonHighlight;
            pause.Location = new Point(331, 499);
            pause.Name = "pause";
            pause.Size = new Size(68, 69);
            pause.TabIndex = 11;
            pause.UseVisualStyleBackColor = true;
            pause.Click += pause_Click;
            // 
            // ADD
            // 
            ADD.BackColor = Color.DarkOliveGreen;
            ADD.FlatStyle = FlatStyle.Flat;
            ADD.Font = new Font("Minecraft", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ADD.Location = new Point(704, 491);
            ADD.Name = "ADD";
            ADD.Size = new Size(143, 48);
            ADD.TabIndex = 13;
            ADD.Text = "ADD";
            ADD.UseVisualStyleBackColor = false;
            ADD.Click += ADD_Click;
            // 
            // Remove
            // 
            Remove.AccessibleRole = AccessibleRole.None;
            Remove.BackColor = Color.DarkOliveGreen;
            Remove.FlatStyle = FlatStyle.Popup;
            Remove.Font = new Font("Minecraft", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Remove.Location = new Point(845, 491);
            Remove.Name = "Remove";
            Remove.Size = new Size(173, 48);
            Remove.TabIndex = 14;
            Remove.Text = "REMOVE";
            Remove.UseVisualStyleBackColor = false;
            Remove.Click += Remove_Click;
            // 
            // KeoXuong
            // 
            KeoXuong.BackColor = SystemColors.ButtonShadow;
            KeoXuong.BackgroundImage = (Image)resources.GetObject("KeoXuong.BackgroundImage");
            KeoXuong.BackgroundImageLayout = ImageLayout.Stretch;
            KeoXuong.FlatStyle = FlatStyle.Flat;
            KeoXuong.ForeColor = Color.DarkOliveGreen;
            KeoXuong.Location = new Point(1022, 301);
            KeoXuong.Name = "KeoXuong";
            KeoXuong.Size = new Size(41, 68);
            KeoXuong.TabIndex = 16;
            KeoXuong.UseVisualStyleBackColor = false;
            KeoXuong.Click += KeoXuong_Click;
            // 
            // Saudo
            // 
            Saudo.BackColor = SystemColors.Control;
            Saudo.BackgroundImage = Properties.Resources.next;
            Saudo.BackgroundImageLayout = ImageLayout.Stretch;
            Saudo.FlatStyle = FlatStyle.Flat;
            Saudo.ForeColor = SystemColors.ButtonHighlight;
            Saudo.Location = new Point(436, 504);
            Saudo.Name = "Saudo";
            Saudo.Size = new Size(76, 63);
            Saudo.TabIndex = 18;
            Saudo.UseVisualStyleBackColor = false;
            Saudo.Click += Saudo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Orange;
            label1.BorderStyle = BorderStyle.FixedSingle;
            label1.Font = new Font("Minecraft", 12.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(701, 552);
            label1.Name = "label1";
            label1.Size = new Size(78, 19);
            label1.TabIndex = 21;
            label1.Text = "Search";
            // 
            // TxtSearch
            // 
            TxtSearch.BackColor = Color.Beige;
            TxtSearch.Font = new Font("Minecraft", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 163);
            TxtSearch.Location = new Point(701, 574);
            TxtSearch.Multiline = true;
            TxtSearch.Name = "TxtSearch";
            TxtSearch.Size = new Size(313, 32);
            TxtSearch.TabIndex = 22;
            TxtSearch.TextChanged += TxtSearch_TextChanged_1;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ControlDark;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(662, 457);
            pictureBox1.TabIndex = 23;
            pictureBox1.TabStop = false;
            // 
            // Them_Anh
            // 
            Them_Anh.BackgroundImage = (Image)resources.GetObject("Them_Anh.BackgroundImage");
            Them_Anh.BackgroundImageLayout = ImageLayout.Stretch;
            Them_Anh.FlatStyle = FlatStyle.Flat;
            Them_Anh.ForeColor = SystemColors.ControlLightLight;
            Them_Anh.Location = new Point(575, 488);
            Them_Anh.Name = "Them_Anh";
            Them_Anh.Size = new Size(88, 88);
            Them_Anh.TabIndex = 24;
            Them_Anh.UseVisualStyleBackColor = true;
            Them_Anh.Click += Them_Anh_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = SystemColors.ButtonHighlight;
            pictureBox2.BackgroundImageLayout = ImageLayout.Stretch;
            pictureBox2.Location = new Point(12, 480);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(662, 103);
            pictureBox2.TabIndex = 25;
            pictureBox2.TabStop = false;
            // 
            // KeoLen
            // 
            KeoLen.BackColor = Color.Azure;
            KeoLen.BackgroundImage = (Image)resources.GetObject("KeoLen.BackgroundImage");
            KeoLen.BackgroundImageLayout = ImageLayout.Stretch;
            KeoLen.FlatStyle = FlatStyle.Flat;
            KeoLen.ForeColor = Color.DarkGreen;
            KeoLen.Location = new Point(1022, 203);
            KeoLen.Name = "KeoLen";
            KeoLen.Size = new Size(41, 68);
            KeoLen.TabIndex = 15;
            KeoLen.UseVisualStyleBackColor = false;
            KeoLen.Click += KeoLen_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.BACKGROUND__2_;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1085, 653);
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
        private Button KeoXuong;
        private Button Saudo;
        private MenuStrip menuStrip1;
        private Label label1;
        private TextBox TxtSearch;
        private PictureBox pictureBox1;
        private Button Them_Anh;
        private PictureBox pictureBox2;
        private Button KeoLen;
    }
}
