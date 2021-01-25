namespace PleerMusic.App
{
    partial class frmPleerMusic
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.plTopBar = new System.Windows.Forms.Panel();
            this.btnFolders = new System.Windows.Forms.Button();
            this.btnArtists = new System.Windows.Forms.Button();
            this.btnAlbums = new System.Windows.Forms.Button();
            this.btnPlayLists = new System.Windows.Forms.Button();
            this.btnSongs = new System.Windows.Forms.Button();
            this.plControl = new System.Windows.Forms.Panel();
            this.trbVolume = new System.Windows.Forms.TrackBar();
            this.panel1 = new System.Windows.Forms.Panel();
            this.trbTimeMusic = new System.Windows.Forms.TrackBar();
            this.lblPositionTime = new System.Windows.Forms.Label();
            this.lblMaxTime = new System.Windows.Forms.Label();
            this.btnPrevious = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblNameMusic = new System.Windows.Forms.Label();
            this.pcMusicImage = new System.Windows.Forms.PictureBox();
            this.plListMusic = new System.Windows.Forms.Panel();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.moreToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.addMusicToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.timShowPositionNowMusic = new System.Windows.Forms.Timer(this.components);
            this.plTopBar.SuspendLayout();
            this.plControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbVolume)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trbTimeMusic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMusicImage)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // plTopBar
            // 
            this.plTopBar.AutoScroll = true;
            this.plTopBar.Controls.Add(this.btnFolders);
            this.plTopBar.Controls.Add(this.btnArtists);
            this.plTopBar.Controls.Add(this.btnAlbums);
            this.plTopBar.Controls.Add(this.btnPlayLists);
            this.plTopBar.Controls.Add(this.btnSongs);
            this.plTopBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.plTopBar.Location = new System.Drawing.Point(0, 24);
            this.plTopBar.Name = "plTopBar";
            this.plTopBar.Size = new System.Drawing.Size(390, 78);
            this.plTopBar.TabIndex = 0;
            // 
            // btnFolders
            // 
            this.btnFolders.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFolders.Location = new System.Drawing.Point(312, 0);
            this.btnFolders.Name = "btnFolders";
            this.btnFolders.Size = new System.Drawing.Size(78, 78);
            this.btnFolders.TabIndex = 4;
            this.btnFolders.Text = "Folders";
            this.btnFolders.UseVisualStyleBackColor = true;
            this.btnFolders.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnArtists
            // 
            this.btnArtists.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnArtists.Location = new System.Drawing.Point(234, 0);
            this.btnArtists.Name = "btnArtists";
            this.btnArtists.Size = new System.Drawing.Size(78, 78);
            this.btnArtists.TabIndex = 3;
            this.btnArtists.Text = "Artists";
            this.btnArtists.UseVisualStyleBackColor = true;
            this.btnArtists.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAlbums
            // 
            this.btnAlbums.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAlbums.Location = new System.Drawing.Point(156, 0);
            this.btnAlbums.Name = "btnAlbums";
            this.btnAlbums.Size = new System.Drawing.Size(78, 78);
            this.btnAlbums.TabIndex = 2;
            this.btnAlbums.Text = "Albums";
            this.btnAlbums.UseVisualStyleBackColor = true;
            this.btnAlbums.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnPlayLists
            // 
            this.btnPlayLists.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnPlayLists.Location = new System.Drawing.Point(78, 0);
            this.btnPlayLists.Name = "btnPlayLists";
            this.btnPlayLists.Size = new System.Drawing.Size(78, 78);
            this.btnPlayLists.TabIndex = 1;
            this.btnPlayLists.Text = "PlayLists";
            this.btnPlayLists.UseVisualStyleBackColor = true;
            this.btnPlayLists.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSongs
            // 
            this.btnSongs.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSongs.Location = new System.Drawing.Point(0, 0);
            this.btnSongs.Name = "btnSongs";
            this.btnSongs.Size = new System.Drawing.Size(78, 78);
            this.btnSongs.TabIndex = 0;
            this.btnSongs.Tag = "1";
            this.btnSongs.Text = "Songs";
            this.btnSongs.UseVisualStyleBackColor = true;
            this.btnSongs.Click += new System.EventHandler(this.button1_Click);
            // 
            // plControl
            // 
            this.plControl.Controls.Add(this.trbVolume);
            this.plControl.Controls.Add(this.panel1);
            this.plControl.Controls.Add(this.btnPrevious);
            this.plControl.Controls.Add(this.btnPlay);
            this.plControl.Controls.Add(this.btnNext);
            this.plControl.Controls.Add(this.lblNameMusic);
            this.plControl.Controls.Add(this.pcMusicImage);
            this.plControl.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.plControl.Location = new System.Drawing.Point(0, 518);
            this.plControl.Name = "plControl";
            this.plControl.Size = new System.Drawing.Size(390, 116);
            this.plControl.TabIndex = 2;
            // 
            // trbVolume
            // 
            this.trbVolume.AutoSize = false;
            this.trbVolume.LargeChange = 1;
            this.trbVolume.Location = new System.Drawing.Point(136, 54);
            this.trbVolume.Maximum = 100;
            this.trbVolume.Name = "trbVolume";
            this.trbVolume.Size = new System.Drawing.Size(113, 21);
            this.trbVolume.TabIndex = 5;
            this.trbVolume.Value = 50;
            this.trbVolume.Scroll += new System.EventHandler(this.trbVolume_Scroll);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.trbTimeMusic);
            this.panel1.Controls.Add(this.lblPositionTime);
            this.panel1.Controls.Add(this.lblMaxTime);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(116, 16);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(274, 32);
            this.panel1.TabIndex = 2;
            // 
            // trbTimeMusic
            // 
            this.trbTimeMusic.AutoSize = false;
            this.trbTimeMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.trbTimeMusic.Location = new System.Drawing.Point(49, 0);
            this.trbTimeMusic.Maximum = 2147483647;
            this.trbTimeMusic.Name = "trbTimeMusic";
            this.trbTimeMusic.Size = new System.Drawing.Size(176, 32);
            this.trbTimeMusic.TabIndex = 1;
            this.trbTimeMusic.Scroll += new System.EventHandler(this.trbTimeMusic_Scroll);
            // 
            // lblPositionTime
            // 
            this.lblPositionTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblPositionTime.Location = new System.Drawing.Point(0, 0);
            this.lblPositionTime.Name = "lblPositionTime";
            this.lblPositionTime.Size = new System.Drawing.Size(49, 32);
            this.lblPositionTime.TabIndex = 2;
            this.lblPositionTime.Text = "00:00:00";
            this.lblPositionTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblMaxTime
            // 
            this.lblMaxTime.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblMaxTime.Location = new System.Drawing.Point(225, 0);
            this.lblMaxTime.Name = "lblMaxTime";
            this.lblMaxTime.Size = new System.Drawing.Size(49, 32);
            this.lblMaxTime.TabIndex = 1;
            this.lblMaxTime.Text = "00:00:00";
            this.lblMaxTime.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnPrevious
            // 
            this.btnPrevious.Location = new System.Drawing.Point(135, 81);
            this.btnPrevious.Name = "btnPrevious";
            this.btnPrevious.Size = new System.Drawing.Size(75, 23);
            this.btnPrevious.TabIndex = 4;
            this.btnPrevious.Text = "Previous";
            this.btnPrevious.UseVisualStyleBackColor = true;
            this.btnPrevious.Click += new System.EventHandler(this.btnPrevious_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Location = new System.Drawing.Point(216, 81);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(75, 23);
            this.btnPlay.TabIndex = 3;
            this.btnPlay.Text = "Play";
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnNext
            // 
            this.btnNext.Location = new System.Drawing.Point(297, 81);
            this.btnNext.Name = "btnNext";
            this.btnNext.Size = new System.Drawing.Size(75, 23);
            this.btnNext.TabIndex = 2;
            this.btnNext.Text = "Next";
            this.btnNext.UseVisualStyleBackColor = true;
            this.btnNext.Click += new System.EventHandler(this.btnNext_Click);
            // 
            // lblNameMusic
            // 
            this.lblNameMusic.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblNameMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameMusic.Location = new System.Drawing.Point(116, 0);
            this.lblNameMusic.Name = "lblNameMusic";
            this.lblNameMusic.Size = new System.Drawing.Size(274, 16);
            this.lblNameMusic.TabIndex = 0;
            this.lblNameMusic.Text = "label1";
            // 
            // pcMusicImage
            // 
            this.pcMusicImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcMusicImage.Location = new System.Drawing.Point(0, 0);
            this.pcMusicImage.Name = "pcMusicImage";
            this.pcMusicImage.Size = new System.Drawing.Size(116, 116);
            this.pcMusicImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcMusicImage.TabIndex = 0;
            this.pcMusicImage.TabStop = false;
            // 
            // plListMusic
            // 
            this.plListMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.plListMusic.Location = new System.Drawing.Point(0, 102);
            this.plListMusic.Name = "plListMusic";
            this.plListMusic.Size = new System.Drawing.Size(390, 416);
            this.plListMusic.TabIndex = 3;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.moreToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(390, 24);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // moreToolStripMenuItem
            // 
            this.moreToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addMusicToolStripMenuItem1});
            this.moreToolStripMenuItem.Name = "moreToolStripMenuItem";
            this.moreToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.moreToolStripMenuItem.Text = "More";
            this.moreToolStripMenuItem.Click += new System.EventHandler(this.moreToolStripMenuItem_Click);
            // 
            // addMusicToolStripMenuItem1
            // 
            this.addMusicToolStripMenuItem1.Name = "addMusicToolStripMenuItem1";
            this.addMusicToolStripMenuItem1.Size = new System.Drawing.Size(131, 22);
            this.addMusicToolStripMenuItem1.Text = "Add Music";
            this.addMusicToolStripMenuItem1.Click += new System.EventHandler(this.addMusicToolStripMenuItem1_Click);
            // 
            // timShowPositionNowMusic
            // 
            this.timShowPositionNowMusic.Interval = 700;
            this.timShowPositionNowMusic.Tick += new System.EventHandler(this.timShowPositionNowMusic_Tick);
            // 
            // frmPleerMusic
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 634);
            this.Controls.Add(this.plListMusic);
            this.Controls.Add(this.plControl);
            this.Controls.Add(this.plTopBar);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPleerMusic";
            this.Text = "PleerMusic";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.plTopBar.ResumeLayout(false);
            this.plControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trbVolume)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trbTimeMusic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcMusicImage)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }


        #endregion

        private System.Windows.Forms.Panel plTopBar;
        private System.Windows.Forms.Panel plControl;
        private System.Windows.Forms.Panel plListMusic;
        private System.Windows.Forms.Button btnPrevious;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSongs;
        private System.Windows.Forms.Button btnArtists;
        private System.Windows.Forms.Button btnAlbums;
        private System.Windows.Forms.Button btnPlayLists;
        private System.Windows.Forms.Button btnFolders;
        private System.Windows.Forms.Label lblNameMusic;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem moreToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem addMusicToolStripMenuItem1;
        public System.Windows.Forms.PictureBox pcMusicImage;
        public System.Windows.Forms.Label lblMaxTime;
        public System.Windows.Forms.Timer timShowPositionNowMusic;
        public System.Windows.Forms.Label lblPositionTime;
        public System.Windows.Forms.TrackBar trbTimeMusic;
        public System.Windows.Forms.TrackBar trbVolume;
    }
}

