using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PleerMusic.DataLayer.Models
{
    public class Music
    {

        [Key]
        public int MusicID { get; set; }

        public string MusicName { set; get; }

        public string MusicAddress { get; set; }

        public AlbumMusic AlbumThisMusic { get; set; }

        public Singer SingerThisMusic { set; get; }


    }
}
