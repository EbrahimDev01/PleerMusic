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
            CheckIsExist(Convert.ToInt32(((Button)sender).Tag));
        }


        /// <summary>
        /// Check For Is Form In plList Existr Or Repetitious 
        /// </summary>
        /// <param name="tagForm"></param>
        private void CheckIsExist(int tagForm)
        {

            if (plListMusic.Controls.Count == 0)
            {
                SelectForms(tagForm);
            }

            else if (tagForm != Convert.ToInt32(plListMusic.Controls[0].Tag))
            {
                plListMusic.Controls.Clear();
                SelectForms(tagForm);

            }


        }


        /// <summary>
        /// Choose between forms For Show in Panel List Music
        /// </summary>
        /// <param name="tagForm">Number Form</param>
        private void SelectForms(int tagForm)
        {


            switch (tagForm)
            {

                case 1:
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
