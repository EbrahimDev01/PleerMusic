using System;
using System.Collections.Generic;
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


        public static void PlayMusic()
        {

            wave.Play();
        }

        public static void StopMusic()
        {
            wave.Stop();
        }

        public static void VolumeMusic(int value)
        {
            wave.Volume = (value / 100);


        }

        public static void StartUse()
        {
            audioFileReader = new AudioFileReader(_address);
            wave = new WaveOut();
            wave.Init(audioFileReader);
        }

    }
}
