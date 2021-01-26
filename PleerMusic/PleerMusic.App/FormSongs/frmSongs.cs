
using PleerMusic.DataLayer.Context;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PleerMusic.App.FormSongs
{
    public partial class frmSongs : Form
    {
        public frmSongs()
        {
            InitializeComponent();

        }

        private async void frmSongs_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;
            await ListMusicBind();
        }

        private async Task ListMusicBind()
        {

            Controls.AddRange((await ConvertMusicToControlMusic.Shows()).ToArray());
            EndLoad();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            try
            {
                if (ConvertMusicToControlMusic.max > 0)
                {
                    progressBar1.Value = (int)((ConvertMusicToControlMusic.Positionvalue * 100) / ConvertMusicToControlMusic.max);

                }
                else progressBar1.Value = 0;
            }
            catch
            {
                progressBar1.Value = 0;


            }
        }


        private void EndLoad()
        {
            progressBar1.Hide();
            timer1.Enabled = false;
        }

    }
}
