namespace PleerMusic.App.UserControls
{
    partial class ucMusicShow
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNameMusic = new System.Windows.Forms.Label();
            this.lblNameSinger = new System.Windows.Forms.Label();
            this.pcMusicImage = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcMusicImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNameMusic
            // 
            this.lblNameMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameMusic.Location = new System.Drawing.Point(54, 0);
            this.lblNameMusic.Name = "lblNameMusic";
            this.lblNameMusic.Size = new System.Drawing.Size(287, 31);
            this.lblNameMusic.TabIndex = 0;
            this.lblNameMusic.Text = "label1";
            this.lblNameMusic.Click += new System.EventHandler(this.ClickSelectMusic);
            // 
            // lblNameSinger
            // 
            this.lblNameSinger.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNameSinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSinger.Location = new System.Drawing.Point(54, 31);
            this.lblNameSinger.Name = "lblNameSinger";
            this.lblNameSinger.Size = new System.Drawing.Size(287, 23);
            this.lblNameSinger.TabIndex = 1;
            this.lblNameSinger.Text = "label2";
            this.lblNameSinger.Click += new System.EventHandler(this.ClickSelectMusic);
            // 
            // pcMusicImage
            // 
            this.pcMusicImage.Dock = System.Windows.Forms.DockStyle.Left;
            this.pcMusicImage.Location = new System.Drawing.Point(0, 0);
            this.pcMusicImage.Name = "pcMusicImage";
            this.pcMusicImage.Size = new System.Drawing.Size(54, 54);
            this.pcMusicImage.TabIndex = 2;
            this.pcMusicImage.TabStop = false;
            this.pcMusicImage.Click += new System.EventHandler(this.ClickSelectMusic);
            // 
            // ucMusicShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNameMusic);
            this.Controls.Add(this.lblNameSinger);
            this.Controls.Add(this.pcMusicImage);
            this.Name = "ucMusicShow";
            this.Size = new System.Drawing.Size(341, 54);
            ((System.ComponentModel.ISupportInitialize)(this.pcMusicImage)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblNameMusic;
        public System.Windows.Forms.Label lblNameSinger;
        public System.Windows.Forms.PictureBox pcMusicImage;
    }
}
