using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PleerMusic.ViewModels.MusicViewModel
{
    public class vmMusic
    {
        public int MusicID { get; set; }

        public string MusicName { set; get; }

        public string MusicAddress { get; set; }

        public string AlbumThisMusic { get; set; }

        public string SingerThisMusic { set; get; }
    }
}
