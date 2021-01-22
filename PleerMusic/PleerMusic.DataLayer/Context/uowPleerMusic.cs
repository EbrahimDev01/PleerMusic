using PleerMusic.DataLayer.Models;

using PleerMusic.DataLayer.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PleerMusic.DataLayer.Context
{
    public class uowPleerMusic : IDisposable
    {

        private PleerMusicDB Db;

        public uowPleerMusic()
        {
            Db = new PleerMusicDB();
        }


        private PleerMusicGeneric<Music> _music;

        public PleerMusicGeneric<Music> pMusic
        {
            get
            {
                if (_music == null)
                {
                    _music = new PleerMusicGeneric<Music>(Db);
                }
                return _music;
            }
        }


        private PleerMusicGeneric<AlbumMusic> _albummusic;

        public PleerMusicGeneric<AlbumMusic> pAlbumMusic
        {
            get
            {
                if (_albummusic == null)
                {
                    _albummusic = new PleerMusicGeneric<AlbumMusic>(Db);
                }
                return _albummusic;
            }
        }




        private PleerMusicGeneric<Singer> _singer;

        public PleerMusicGeneric<Singer> pSinger
        {
            get
            {
                if (_singer == null)
                {
                    _singer = new PleerMusicGeneric<Singer>(Db);
                }
                return _singer;
            }
        }


        public void Save()
        {
            Db?.SaveChanges();
        }

        public void Dispose()
        {
            Db?.Dispose();
        }
    }
}
