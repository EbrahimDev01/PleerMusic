using PleerMusic.DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Id3Lib.Exceptions;
using TagLib;
using System.Windows.Forms;
using PleerMusic.DataLayer.Context;

namespace PleerMusic.Utility.MusicControl
{
    public class ConvertAddresToClass
    {

        public static async Task<List<(Music music, AlbumMusic album, Singer singer)>> ToClass(List<string> listAddress)
        {


            using (uowPleerMusic db = new uowPleerMusic())
            {
                foreach (var item in db.pMusic.GetAll().ToList())
                {

                    listAddress.Remove(item.MusicAddress.ToString());
                    if (listAddress.Count == 0)
                        return null;

                }
            }



            List<(Music music, AlbumMusic album, Singer singer)> lsitClass = new List<(Music music, AlbumMusic album, Singer singer)>();



            await Task.Run(() =>
            {
                foreach (string addres in listAddress)
                {
                    try
                    {
                        using (TagLib.File file = TagLib.File.Create(addres))
                        {
                            string name = "";

                            using (OpenFileDialog openFile = new OpenFileDialog())
                            {
                                openFile.FileName = addres;
                                int extensionLength = System.IO.Path.GetExtension(addres).Length;

                                name = openFile.SafeFileName.Remove(openFile.SafeFileName.Length - extensionLength);

                            }

                            Music music = new Music();
                            music.MusicAddress = addres;
                            music.MusicName = (file.Tag.Title == null) ? name : file.Tag.Title;

                            AlbumMusic albumMusic = new AlbumMusic();
                            albumMusic.NameAlmum = (file.Tag.Album == null) ? "Singel" : file.Tag.Album;

                            Singer singer = new Singer();
                            List<Singer> singers = new List<Singer>();


                            music.AlbumThisMusic = albumMusic;

                            albumMusic.SingersThisAlbum = music.SingerThisMusic = singers;

                            singer.MusicsThisMusic = albumMusic.MusicOfThisAlbum = new List<Music>();

                            singer.AlbumsThisSinger = new List<AlbumMusic>();


                            albumMusic.MusicOfThisAlbum.Add(music);



                            foreach (var item in file.Tag.Artists.ToList())
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
                    catch
                    {


                    }

                }
            });
            return lsitClass;

        }


    }
}

