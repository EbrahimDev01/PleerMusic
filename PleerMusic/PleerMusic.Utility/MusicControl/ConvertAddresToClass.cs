using PleerMusic.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Id3Lib.Exceptions;
using TagLib;
using System.Windows.Forms;

namespace PleerMusic.Utility.MusicControl
{
    public class ConvertAddresToClass
    {

        public static async Task<List<(Music music, AlbumMusic album, Singer singer)>> ToClass(List<string> listAddress)
        {


            List<(Music music, AlbumMusic album, Singer singer)> lsitClass = new List<(Music music, AlbumMusic album, Singer singer)>();

            await Task.Run(() =>
            {


                foreach (string addres in listAddress)
                {
                    using (File file = File.Create(addres))
                    {

                        Music music = new Music();
                        music.MusicAddress = addres;
                        music.MusicName = file.Tag.Title;

                        AlbumMusic albumMusic = new AlbumMusic();
                        albumMusic.NameAlmum = (file.Tag.Album == null) ? "Singel" : file.Tag.Album;

                        Singer singer = new Singer();
                        List<Singer> singers = new List<Singer>();


                        music.AlbumThisMusic = albumMusic;

                        albumMusic.SingersThisAlbum = music.SingerThisMusic = singers;

                        singer.MusicsThisMusic = albumMusic.MusicOfThisAlbum = new List<Music>();

                        singer.AlbumsThisSinger = new List<AlbumMusic>();


                        albumMusic.MusicOfThisAlbum.Add(music);



                        foreach (var item in file.Tag.Artists)
                        {

                            singer.SignerName = item;
                            singer.AlbumsThisSinger.Add(albumMusic);
                            singer.MusicsThisMusic.Add(music);

                            singers.Add(singer);
                        }


                        (Music music, AlbumMusic album, Singer singer) tupl = (music, albumMusic, singer);

                        lsitClass.Add(tupl);

                    }
                }
            });
            return lsitClass;
        }


    }
}

