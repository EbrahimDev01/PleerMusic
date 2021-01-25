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
using PleerMusic.App.FormSongs;

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
            ((frmPleerMusic)(Application.OpenForms["frmPleerMusic"])).SelectedMusicNumber = (int)((Control)sender).Tag;
            PrepareforPlayMusic(((Control)sender).Name);
        }
        private async void PrepareforPlayMusic(string address)
        {

            PlayMusicContorl.Address = address;
            PlayMusicContorl.StartUse();

            await ((frmPleerMusic)(Application.OpenForms["frmPleerMusic"])).SetDataMusic();
            PlayMusicContorl.PlayMusic();

        }


    }
}
