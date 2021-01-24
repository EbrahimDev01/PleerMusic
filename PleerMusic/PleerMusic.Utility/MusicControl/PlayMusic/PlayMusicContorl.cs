using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using WMPLib;

namespace PleerMusic.App.Controls.PlayMusic
{
    public static class PlayMusicContorl
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
                wave.Play();
            }
            catch
            {
            }


        }

        public static void StopMusic()
        {
            try
            {

                wave.Stop();
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
                wave.Init(audioFileReader);

            }
            catch
            {
            }
        }

        public static Bitmap Image()
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
                            var bm = new Bitmap(mStream, false);
                            mStream.Dispose();
                            return bm;
                        }
                    }
                }
            }
            catch
            {
            }
            return null;
        }
    }
}
