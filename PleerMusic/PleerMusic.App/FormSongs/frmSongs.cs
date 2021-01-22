
using PleerMusic.DataLayer.Context;
using PleerMusic.Utility.MusicControl;
using PleerMusic.Utility.UserControls;
using PleerMusic.ViewModels.MusicViewMosels;
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

        private void frmSongs_Load(object sender, EventArgs e)
        {

        }

        private void ListMusicBind()
        {
            List<UserMusicControl> musicControls;
            using (uowPleerMusic db = new uowPleerMusic())
            {
                List<MusicModel> musics = db.pMusic.GetAll().Select(
                    m =>
                    new MusicModel
                    {
                        MusicID = m.MusicID,
                        MusicAddress = m.MusicAddress,
                        MusicName = m.MusicName,
                        AlbumThisMusic = m.AlbumThisMusic.NameAlmum,
                        SingerThisMusic = m.SingerThisMusic.SignerName

                    }

                ).ToList();

                musicControls = MusicsControl.musicsControls(musics).ToList();

            }
            this.Controls.AddRange(musicControls.ToArray());
        }


    }
}
