﻿using PleerMusic.App.Controls.PlayMusic;
using PleerMusic.App.FormSongs;
using PleerMusic.App.UserControls;
using PleerMusic.DataLayer.Context;
using PleerMusic.DataLayer.Models;
using PleerMusic.Utility.MusicControl;
using PleerMusic.ViewModels;
using PleerMusic.ViewModels.MusicViewModel;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PleerMusic.App
{
    public partial class frmPleerMusic : Form
    {
        public frmPleerMusic()
        {
            InitializeComponent();
            CheckIsExist(_numberForm);
        }

        public List<string> Addresses = new List<string>();

        private List<int> _randomNumbers = new List<int>();

        private async void Form1_Load(object sender, EventArgs e)
        {

            // CheckIsExist(_numberForm);
            await CheckFileDelete.DeleteAddressesFromDb();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            CheckIsExist(Convert.ToInt32(((Button)sender).Tag));
        }

        private int _numberForm = 1;



        /// <summary>
        /// Check For Is Form In plList Existr Or Repetitious 
        /// </summary>
        /// <param name="tagForm"></param>
        private void CheckIsExist(int tagForm)
        {

            if (plListMusic.Controls.Count == 0)
            {
                SelectForms(tagForm);
            }

            else if (tagForm != Convert.ToInt32(plListMusic.Controls[0].Tag))
            {
                plListMusic.Controls.Clear();
                SelectForms(tagForm);

            }


        }


        /// <summary>
        /// Choose between forms For Show in Panel List Music
        /// </summary>
        /// <param name="tagForm">Number Form</param>
        private void SelectForms(int tagForm)
        {

            _numberForm = tagForm;
            switch (tagForm)
            {

                case 1:
                    {
                        frmSongs songs = new frmSongs();
                        songs.TopLevel = false;
                        songs.Dock = DockStyle.Fill;
                        this.plListMusic.Controls.Add(songs);
                        songs.Show();

                        break;
                    }


            }
        }

        private async void addMusicToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            List<string> musicList = SelectMusic();


            if (musicList != null)
            {

                List<(Music music, AlbumMusic album, Singer singer)> listClass = await ConvertAddresToClass.ToClass(musicList);

                if (listClass != null)
                    await InsertMusicsToDb(listClass);
                musicList = null;
                listClass = null;
            }
        }

        private List<string> SelectMusic()
        {

            using (OpenFileDialog openFile = new OpenFileDialog())
            {

                openFile.Multiselect = true;

                if (openFile.ShowDialog() == DialogResult.OK)
                {



                    return openFile.FileNames.ToList();
                }
            }
            return null;
        }

        private async Task InsertMusicsToDb(List<(Music music, AlbumMusic album, Singer singer)> listClass)
        {

            using (uowPleerMusic db = new uowPleerMusic())
            {
                await Task.Run(() =>
                {
                    foreach ((Music music, AlbumMusic album, Singer singer) item in listClass)
                    {
                        db.pAlbumMusic.Insert(item.album);
                        db.pMusic.Insert(item.music);
                        db.pSinger.Insert(item.singer);

                        db.Save();
                    }

                });
            }
            plListMusic.Controls.Clear();
            CheckIsExist(_numberForm);

        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            PlayOrStop();
        }

        private void PlayOrStop()
        {

            if (PlayMusicContorl.IsPlay)
            {
                PlayMusicContorl.StopMusic();
                btnPlay.Text = "Stop";
            }
            else
            {
                PlayMusicContorl.PlayMusic();
                btnPlay.Text = "Play";
            }
        }

        private void moreToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void trbVolume_Scroll(object sender, EventArgs e)
        {
            PlayMusicContorl.VolumeMusic((float)trbVolume.Value);
        }

        private void timShowPositionNowMusic_Tick(object sender, EventArgs e)
        {
            lblPositionTime.Text = PlayMusicContorl.PositonTime.ToString();
            trbTimeMusic.Value = PlayMusicContorl.TimeShift;
            if (PlayMusicContorl.TimeShift >= PlayMusicContorl.MaxLength)
            {
                SelectedMusicNumber--;
                SelectMusicInList();
            }

        }

        private void trbTimeMusic_Scroll(object sender, EventArgs e)
        {
            PlayMusicContorl.TimeShift = trbTimeMusic.Value;
        }


        public int SelectedMusicNumber = 1;

        private async void SelectMusicInList()
        {

            if (Addresses.Count == SelectedMusicNumber)
                SelectedMusicNumber = 0;

            if (SelectedMusicNumber < 0)
                SelectedMusicNumber = Addresses.Count - 1;

            if (cbRandomPlayback.Checked)
            {
                PlayMusicContorl.Address = Addresses[_randomNumbers[SelectedMusicNumber]];

            }
            else
            {
                PlayMusicContorl.Address = Addresses[SelectedMusicNumber];
            }


            PlayMusicContorl.StartUse();
            await SetDataMusic();
            PlayMusicContorl.PlayMusic();


        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            SelectedMusicNumber--;
            SelectMusicInList();
        }

        public async Task SetDataMusic()
        {
            int volum = trbVolume.Value;
            await Task.Run(() =>
             {
                 PlayMusicContorl.VolumeMusic(volum);

                 pcMusicImage.Image = PlayMusicContorl.GetImageMusic();
             });

            lblMaxTime.Text = PlayMusicContorl.TotalTime;
            timShowPositionNowMusic.Enabled = true;
            trbTimeMusic.Maximum = PlayMusicContorl.MaxLength;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {

            if (PlayMusicContorl.TimeShift / 3537 < 30)
            {
                SelectedMusicNumber++;
                SelectMusicInList();
            }
            else
            {
                PlayMusicContorl.TimeShift = 0;
            }


        }

        private async Task CreateRandomNumber()
        {

            await Task.Run(() =>
             {

                 int newRandomNumber = 0;



                 do
                 {
                     newRandomNumber = new Random().Next(0, Addresses.Count);
                     if (!_randomNumbers.Where(n => n == newRandomNumber).Any())
                     {
                         _randomNumbers.Add(newRandomNumber);
                     }



                 } while (Addresses.Count != _randomNumbers.Count);


             });
        }

        private async void cbRandomPlayback_CheckedChanged(object sender, EventArgs e)
        {
            if (Addresses.Count > 0)
            {
                await CreateRandomNumber();
            }
            else
            {
                cbRandomPlayback.Checked = false;
            }
        }
    }
}