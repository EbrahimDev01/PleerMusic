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
            this.SuspendLayout();
            // 
            // lblNameMusic
            // 
            this.lblNameMusic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblNameMusic.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameMusic.Location = new System.Drawing.Point(0, 0);
            this.lblNameMusic.Name = "lblNameMusic";
            this.lblNameMusic.Size = new System.Drawing.Size(341, 31);
            this.lblNameMusic.TabIndex = 0;
            this.lblNameMusic.Text = "label1";
            // 
            // lblNameSinger
            // 
            this.lblNameSinger.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblNameSinger.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameSinger.Location = new System.Drawing.Point(0, 31);
            this.lblNameSinger.Name = "lblNameSinger";
            this.lblNameSinger.Size = new System.Drawing.Size(341, 23);
            this.lblNameSinger.TabIndex = 1;
            this.lblNameSinger.Text = "label2";
            // 
            // ucMusicShow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblNameMusic);
            this.Controls.Add(this.lblNameSinger);
            this.Name = "ucMusicShow";
            this.Size = new System.Drawing.Size(341, 54);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblNameMusic;
        private System.Windows.Forms.Label lblNameSinger;
    }
}
