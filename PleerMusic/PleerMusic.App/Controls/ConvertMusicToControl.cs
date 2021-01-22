using PleerMusic.App.UserControls;
using PleerMusic.DataLayer.Context;
using PleerMusic.ViewModels.MusicViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace PleerMusic.App
{
    public static class ConvertMusicToControlMusic
    {

        public static ucMusicShow[] Shows(string where = null)
        {
            List<vmMusic> vmMusics = GetDateFromDb();

            return ucMusics(vmMusics).ToArray();

        }

        private static List<vmMusic> GetDateFromDb(string where = null)
        {
            using (uowPleerMusic db = new uowPleerMusic())
            {
                return db.pMusic.GetAll()
                    .Select(
                    m =>
                    new vmMusic
                    {
                        AlbumThisMusic = (m.AlbumThisMusic==null)?"":m.AlbumThisMusic.NameAlmum,
                        MusicAddress = m.MusicAddress,
                        MusicName = m.MusicName,
                        SingerThisMusic = (m.SingerThisMusic == null) ? "" : m.SingerThisMusic.SignerName,
                        MusicID = m.MusicID
                    }).ToList();
            }
        }

        private static IEnumerable<ucMusicShow> ucMusics(List<vmMusic> musics)
        {
            foreach (var m in musics)
            {
                var ucMusic = new ucMusicShow();
                ucMusic.lblNameMusic.Text = m.MusicName;
                ucMusic.lblNameSinger.Text = m.SingerThisMusic;

                yield return ucMusic;
            }

        }

    }
}
