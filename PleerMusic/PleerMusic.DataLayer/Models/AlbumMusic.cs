using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PleerMusic.DataLayer.Models
{
    public class AlbumMusic
    {
        [Key]
        public int AlbumMusicID { get; set; }

        public string NameAlmum { set; get; }

        public List<Music> MusicOfThisAlbum { get; set; }

        public List<Singer> SingersThisAlbum { get; set; }

    }
}
