

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PleerMusic.Utility.UserControls;
using PleerMusic.ViewModels.MusicViewMosels;

namespace PleerMusic.Utility.MusicControl
{
    public class MusicsControl
    {
        public static IEnumerable<UserMusicControl> musicsControls(List<MusicModel> musics)
        {
            foreach (MusicModel m in musics)
            {
                UserMusicControl musicsControl = new UserMusicControl();

                musicsControl.lblNameMusic.Text = m.MusicName;
                musicsControl.lblNameSonger.Text = m.SingerThisMusic;

                yield return musicsControl;
            }
            
        }
    }
}
