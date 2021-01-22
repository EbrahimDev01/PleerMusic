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

namespace PleerMusic.App
{
    public static class ConvertMusicToControlMusic
    {

        public async static Task<List<Control>> Shows(string where = null)
        {
            List<vmMusic> vmMusics = await GetDateFromDb();

            return await ucMusics(vmMusics);

        }

        private async static Task<List<vmMusic>> GetDateFromDb(string where = null)
        {
            return await Task<List<vmMusic>>.Run(() =>
            {
                using (uowPleerMusic db = new uowPleerMusic())
                {
                    return db.pMusic.GetAll()
                        .Select(
                        m =>
                        new vmMusic
                        {
                            AlbumThisMusic = (m.AlbumThisMusic == null) ? "" : m.AlbumThisMusic.NameAlmum,
                            MusicAddress = m.MusicAddress,
                            MusicName = m.MusicName,
                            SingerThisMusic = (m.SingerThisMusic == null) ? "" : m.SingerThisMusic.SignerName,
                            MusicID = m.MusicID
                        }).ToList();
                }
            });
        }

        private async static Task<List<Control>> ucMusics(List<vmMusic> musics)
        {
            return await Task<List<Control>>.Run(() =>
                {
                    List<Control> controls = new List<Control>();
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
                        controls.Add(ucMusic);
                        ucMusic.TabIndex = 1;

                        Panel p = new Panel();
                        p.Dock = DockStyle.Top;
                        p.BackColor = System.Drawing.Color.Black;
                        p.Height = 2;
                        p.TabIndex = 2;
                        controls.Add(p);


                    }
                    
                    return controls;
                });
        }

    }
}
