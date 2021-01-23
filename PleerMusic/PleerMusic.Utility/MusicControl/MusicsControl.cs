using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using PleerMusic.Utility.UserControls;
using PleerMusic.ViewModels.MusicViewModel;

namespace PleerMusic.Utility.MusicControl
{
    public class MusicsControl
    {
        public static IEnumerable<UserMusicControl> musicsControls(List<vmMusic> musics)
        {
            foreach (vmMusic m in musics)
            {
                UserMusicControl musicsControl = new UserMusicControl();

                musicsControl.lblNameMusic.Text = m.MusicName;
                musicsControl.lblNameSonger.Text = m.SingerThisMusic;

                yield return musicsControl;
            }

        }
    }
}
