using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PleerMusic.App.Controls.PlayMusic;

namespace PleerMusic.App.UserControls
{
    public partial class ucMusicShow : UserControl
    {
        public ucMusicShow()
        {
            InitializeComponent();
        }

        private void ClickSelectMusic(object sender, EventArgs e)
        {
            PrepareforPlayMusic(((Label)sender).Name);
        }
        private void PrepareforPlayMusic(string address)
        {
            PlayMusicContorl.DisposeInstance();
            PlayMusicContorl.Address = address;
            PlayMusicContorl.StartUse();
            PlayMusicContorl.PlayMusic();
            PlayMusicContorl.VolumeMusic(50);
            ((frmPleerMusic)(Application.OpenForms["frmPleerMusic"])).pcMusicImage.Image = PlayMusicContorl.GetImageMusic();
            ((frmPleerMusic)(Application.OpenForms["frmPleerMusic"])).lblMaxTime.Text = PlayMusicContorl.TotalTime;


        }
    }
}
