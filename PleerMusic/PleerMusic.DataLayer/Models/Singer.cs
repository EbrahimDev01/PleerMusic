using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PleerMusic.DataLayer.Models
{
    public class Singer
    {

        public int SingerID { get; set; }

        public  string SignerName { set; get; }

        public List<AlbumMusic> AlbumsThisSinger { get; set; }

        public List<Music> MusicsThisMusic { get; set; }

    }
}
