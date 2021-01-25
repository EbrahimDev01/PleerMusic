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
            PrepareforPlayMusic(((Control)sender).Name);
            GetNumberControls(((Control)sender).Name);
        }
        private void PrepareforPlayMusic(string address)
        {

            PlayMusicContorl.Address = address;
            PlayMusicContorl.StartUse();
            ((frmPleerMusic)(Application.OpenForms["frmPleerMusic"])).SetDataMusic();


        }

        private void GetNumberControls(string address)
        {
            frmSongs frm = ((frmSongs)(Application.OpenForms["frmSongs"]));
            int i = 1;
            foreach (var item in frm.Controls)
            {
                if (item is ucMusicShow)
                {
                    if (((ucMusicShow)item).Tag.ToString() == address)
                    {
                        ((frmPleerMusic)(Application.OpenForms["frmPleerMusic"])).SelectedMusicNumber = frm.Controls.Count - i;
                        break;
                    }

                }
                i++;
            }

        }

    }
}
