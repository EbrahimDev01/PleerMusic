namespace PleerMusic.Utility.UserControls
{
    partial class UserMusicControl
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
            this.lblNameSonger = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNameMusic
            // 
            this.lblNameMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameMusic.Location = new System.Drawing.Point(0, 0);
            this.lblNameMusic.Name = "lblNameMusic";
            this.lblNameMusic.Size = new System.Drawing.Size(341, 32);
            this.lblNameMusic.TabIndex = 0;
            this.lblNameMusic.Text = "Name Music";
            this.lblNameMusic.Click += new System.EventHandler(this.lblNameMusic_Click);
            // 
            // lblNameSonger
            // 
            this.lblNameSonger.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNameSonger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSonger.Location = new System.Drawing.Point(0, 32);
            this.lblNameSonger.Name = "lblNameSonger";
            this.lblNameSonger.Size = new System.Drawing.Size(341, 16);
            this.lblNameSonger.TabIndex = 1;
            this.lblNameSonger.Text = "Name Songer";
            // 
            // MusicControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNameMusic);
            this.Controls.Add(this.lblNameSonger);
            this.Name = "MusicControl";
            this.Size = new System.Drawing.Size(341, 48);
            this.ResumeLayout(false);

        }

        #endregion

        public System.Windows.Forms.Label lblNameMusic;
        public System.Windows.Forms.Label lblNameSonger;
    }
}
