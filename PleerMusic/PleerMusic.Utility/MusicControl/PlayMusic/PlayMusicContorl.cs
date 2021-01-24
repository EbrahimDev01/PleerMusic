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

        private static string _address;


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

        public static string TotalTime
        {
            get
            {
                if (wave == null)
                {
                    return "00:00:00";
                }

                return audioFileReader.TotalTime.Hours.ToString("00") + ":" + audioFileReader.TotalTime.Minutes.ToString("00") + ":" + audioFileReader.TotalTime.Seconds.ToString("00");
            }
        }

        public static string PositonTime
        {
            get
            {
                if (wave == null)
                {
                    return "00:00:00";
                }
                return audioFileReader.CurrentTime.Hours.ToString("00") + ":" + audioFileReader.CurrentTime.Minutes.ToString("00") + ":" + audioFileReader.CurrentTime.Seconds.ToString("00");
            }
        }

        public static int TimeShift
        {
            get
            {
                return (int)(audioFileReader.Position / 10);
            }
            set
            {

                audioFileReader.Position = (value * 10);
            }
        }

        public static int MaxLength
        {
            get
            {
                if (wave == null)
                {
                    return 0;
                }
                return (int)(audioFileReader.Length / 10);
            }
        }


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

        public static void VolumeMusic(float value)
        {
            float volum = (value / 100);
            wave.Volume = volum;
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
