
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
            await ListMusicBind();
        }

        private async Task ListMusicBind()
        {
            Controls.AddRange((await ConvertMusicToControlMusic.Shows()).ToArray());
        }


    }
}
