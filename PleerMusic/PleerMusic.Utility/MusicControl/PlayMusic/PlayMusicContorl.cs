using System;
using System.Collections.Generic;
using System.Drawing;

using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using WMPLib;

namespace PleerMusic.App.Controls.PlayMusic
{
    public class PlayMusicContorl : IDisposable
    {


        public static string Address
        {
            set
            {
                if (value != null)
                {
                    _address = value;
                }
                else throw new Exception("Null Value");
            }
            get { return _address; }

        }
        private static string _address;

        private static AudioFileReader audioFileReader = null;

        private static WaveOut wave = null;

        public static bool IsPlay
        {
            get
            {
                if (wave == null)
                {
                    return false;
                }
                return (wave.PlaybackState.ToString() != "Stopped") ? true : false;

            }
        }




        public static void PlayMusic()
        {
            try
            {
                wave?.Play();
            }
            catch
            {
            }


        }

        public static void StopMusic()
        {
            try
            {

                wave?.Stop();
            }
            catch
            {
            }
        }

        public static void VolumeMusic(int value)
        {
            wave.Volume = (value / 100);


        }

        public static void StartUse()
        {
            try
            {
                audioFileReader = new AudioFileReader(_address);
                wave = new WaveOut();
                wave?.Init(audioFileReader);

            }
            catch
            {
            }
        }


        public static Bitmap Image(int width = 116, int height = 116)
        {
            try
            {
                using (TagLib.File file = TagLib.File.Create(_address))
                {
                    using (var mStream = new MemoryStream())
                    {
                        var firstPicture = file.Tag.Pictures.FirstOrDefault();
                        if (firstPicture != null)
                        {
                            byte[] pData = firstPicture.Data.Data;
                            mStream.Write(pData, 0, Convert.ToInt32(pData.Length));
                            pData = null;
                            Bitmap bm = new Bitmap(mStream, false);

                            mStream.Dispose();
                            
                            Bitmap bmImage = ResizeImage(bm, width, height);
                            bm.Dispose();
                            return bmImage;
                        }
                    }
                }
            }
            catch
            {
            }
            return null;
        }

        private static Bitmap ResizeImage(Bitmap bm, int width, int height)
        {
            throw new NotImplementedException();
        }

        public static void DisposeInstance()
        {
            wave?.Dispose();
            audioFileReader?.Dispose();
            wave = null;
            audioFileReader = null;
            //  Address = null;
            _address = null;
        }

        public void Dispose()
        {

        }
    }
}
