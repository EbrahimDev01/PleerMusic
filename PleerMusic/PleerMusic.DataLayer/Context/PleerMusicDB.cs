using PleerMusic.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PleerMusic.DataLayer.Context
{
    public class PleerMusicDB : DbContext
    {

        public PleerMusicDB() : base("name=PleerMusicDB") { }

        public DbSet<Music> Musics { get; set; }

        public DbSet<Singer> Singers { get; set; }

        public DbSet<AlbumMusic> AlbumMusics { get; set; }

    }
}
