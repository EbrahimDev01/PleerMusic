using PleerMusic.App.FormSongs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PleerMusic.App
{
    public partial class PleerMusic : Form
    {
        public PleerMusic()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectForms(((Button)sender).Text);
        }



        private void SelectForms(string nameForm)
        {
            switch (nameForm)
            {

                case "Songs":
                    {
                        frmSongs songs = new frmSongs();
                        songs.TopLevel = false;
                        songs.Dock = DockStyle.Fill;
                        this.plListMusic.Controls.Add(songs);
                        songs.Show();
                        break;
                    }

                default:
                    break;

            }
        }


    }
}
