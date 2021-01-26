using PleerMusic.App.UserControls;
using PleerMusic.DataLayer.Context;
using PleerMusic.ViewModels.MusicViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using PleerMusic.DataLayer.Models;
using PleerMusic.Utility.Image;
using PleerMusic.App.FormSongs;

namespace PleerMusic.App
{
    public static class ConvertMusicToControlMusic
    {

        public static int max
        {
            get
            {

                return _maxValue;
            }
        }

        public static int Positionvalue
        {
            get
            {
                return _positionValue;
            }

        }

        private static int _maxValue = 0;
        private static int _positionValue = 0;

        public async static Task<List<Control>> Shows(string where = null)
        {
            List<vmMusic> vmMusics = await GetDateFromDb();

            _maxValue = vmMusics.Count;

            return await (ucMusics(vmMusics.OrderByDescending(m => m.MusicName).ToList()));


        }

        private async static Task<List<vmMusic>> GetDateFromDb(string where = null)
        {
            return await Task<List<vmMusic>>.Run(() =>
            {
                using (uowPleerMusic db = new uowPleerMusic())
                {




                    List<vmMusic> musics = db.pMusic.GetAll().ToList()
                    .Select(
                        m =>
                        new vmMusic
                        {
                            AlbumThisMusic = ((AlbumMusic)(db.pMusic.GetAll(m1 => m1.MusicID == m.MusicID, "AlbumThisMusic"))?.FirstOrDefault().AlbumThisMusic).NameAlmum,
                            MusicAddress = m.MusicAddress,
                            MusicName = m.MusicName,
                            SingerThisMusic = (mergeNameSinger((List<Singer>)(db.pMusic.GetAll(m1 => m.MusicID == m1.MusicID, "SingerThisMusic")).FirstOrDefault().SingerThisMusic)).ToString(),
                            MusicID = m.MusicID
                        }).ToList();



                    return musics;

                }
            });
        }

        private async static Task<List<Control>> ucMusics(List<vmMusic> musics)
        {

            return await Task<List<Control>>.Run(() =>
            {
                List<Control> controls = new List<Control>();

                Label label1 = new Label();
                label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
                label1.Dock = System.Windows.Forms.DockStyle.Top;
                label1.ForeColor = System.Drawing.Color.White;
                label1.Location = new System.Drawing.Point(0, 43);
                label1.Name = "label1";
                label1.Size = new System.Drawing.Size(341, 13);
                label1.TabIndex = 2;
                label1.Text = _maxValue.ToString();
                label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                controls.Add(label1);



                Panel p1 = new Panel();
                p1.Dock = DockStyle.Top;
                p1.BackColor = System.Drawing.Color.Black;
                p1.Height = 2;
                p1.TabIndex = 2;
                controls.Add(p1);

                foreach (var m in musics)
                {

                    var ucMusic = new ucMusicShow();
                    ucMusic.lblNameMusic.Text = m.MusicName;
                    ucMusic.lblNameSinger.Text = m.SingerThisMusic;
                    ucMusic.Dock = DockStyle.Top;
                    ucMusic.TabIndex = 1;
                    ucMusic.Tag = m.MusicAddress;
                    ucMusic.pcMusicImage.Name = ucMusic.lblNameSinger.Name = ucMusic.lblNameMusic.Name = m.MusicAddress;

                    ucMusic.pcMusicImage.Tag = ucMusic.lblNameSinger.Tag = ucMusic.lblNameMusic.Tag = ((frmPleerMusic)(Application.OpenForms["frmPleerMusic"])).Addresses.Count;

                    ((frmPleerMusic)(Application.OpenForms["frmPleerMusic"])).Addresses.Add(m.MusicAddress);



                    controls.Add(ucMusic);

                    ucMusic.pcMusicImage.Image = ImageControl.GetImageMusic(m.MusicAddress, 54, 54);

                    Panel p = new Panel();
                    p.Dock = DockStyle.Top;
                    p.BackColor = System.Drawing.Color.Black;
                    p.Height = 2;
                    p.TabIndex = 2;


                    _positionValue = (int)ucMusic.lblNameMusic.Tag;

                    controls.Add(p);

                }
                return controls;


            });
        }

        private static string mergeNameSinger(List<Singer> nameSinger)
        {
            string names = "";

            foreach (Singer singer in nameSinger)
            {
                names += singer.SignerName + " - ";
            }
            names = names.Remove(names.Length - 3);
            return names;


        }

        private static void SelectingucMusicTofrmSongs(Control c)
        {

        }


    }
}



/*
 
 
 

 
 */