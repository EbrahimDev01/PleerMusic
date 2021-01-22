using PleerMusic.DataLayer.Context;
using PleerMusic.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            AlbumMusic a = new AlbumMusic()
            {
                NameAlmum = "ss"
            };




            Music m = new Music()
            {
                MusicAddress = "dd",
                MusicName = "aa",

            };

            Singer s = new Singer()
            {
                SignerName = "bb"
            };

            uowPleerMusic pm = new uowPleerMusic();
            pm.pMusic.Insert(m);
            pm.pAlbumMusic.Insert(a);
            pm.pSinger.Insert(s);

            pm.Save();


        }
    }
}
