using System;
using System.Collections.Generic;
using System.Drawing;

using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;
using PleerMusic.Utility.Image;
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

        public static Bitmap GetImageMusic(int width = 116, int height = 116)
        {

            return ImageControl.GetImageMusic(_address, width, height);
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
