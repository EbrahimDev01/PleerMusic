using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PleerMusic.DataLayer.Models
{
    public class AlbumMusic
    {

        public int AlbumMusicID { get; set; }

        public List<Music> MusicOfThisAlbum { get; set; }

        public List<Singer> SingersThisAlbum { get; set; }

    }
}
