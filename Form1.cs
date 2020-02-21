using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using Syroot.Windows.IO;

using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace Draft_Audio_Player
{
    public partial class DraftAudioPlayerMainForm : Form
    {
        WaveOutEvent outputDevice;
        AudioFileReader fileReader;
        bool musicIsPlaying = false;
        string audioPath = "";
        int timerInSeconds = 0;

        public DraftAudioPlayerMainForm()
        {
            InitializeComponent();
        }
        private void playButton_Click(object sender, EventArgs e)
        {
            if (musicIsPlaying == true)
            {
                outputDevice.Pause();
                timerOfPlayback.Stop();
                playButton.Text = "";
                musicIsPlaying = false;
                timerOfPlayback.Enabled = false;
            }
            else if(playButton.Text == "")
            {
                outputDevice.Play();
                timerOfPlayback.Start();
                playButton.Text = "";
                musicIsPlaying = true;
                timerOfPlayback.Enabled = true;
            }
            else if (fileReader != null && outputDevice != null)
            {
                outputDevice.Play();
                timerOfPlayback.Stop();
                musicIsPlaying = true;
                playButton.Text = "";
                timerOfPlayback.Enabled = true;
            }
        }

        private void getFileNameButton_Click(object sender, EventArgs e)
        {
            openFileDialog.ShowDialog();
        }

        private void openFileDialog_FileOk(object sender, CancelEventArgs e)
        {
            audioPath = openFileDialog.FileName;
            fileReader = new AudioFileReader(audioPath);
            outputDevice = new WaveOutEvent();
            outputDevice.Init(fileReader);
            musicTrackBar.Maximum = fileReader.TotalTime.Minutes * 60 + fileReader.TotalTime.Seconds;
            maximumDuration.Text = fileReader.TotalTime.Minutes.ToString("00") + ":" + fileReader.TotalTime.Seconds.ToString("00");
        }

        private void timerOfPlayback_Tick(object sender, EventArgs e)
        {
            musicTrackBar.Value = fileReader.CurrentTime.Minutes * 60 + fileReader.CurrentTime.Seconds;
            durationOfPlayback.Text = fileReader.CurrentTime.Minutes.ToString("00") + ":" + fileReader.CurrentTime.Seconds.ToString("00");
        }

        private void musicTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            outputDevice.Stop();
            if (fileReader != null)
            {
                fileReader.Position += (musicTrackBar.Value - fileReader.CurrentTime.Minutes * 60 - fileReader.CurrentTime.Seconds) * fileReader.WaveFormat.AverageBytesPerSecond;
            }
            if (musicIsPlaying != false)
                outputDevice.Play();
            timerOfPlayback.Enabled = true;
        }

        private void musicTrackBar_Scroll(object sender, EventArgs e)
        {
            timerOfPlayback.Enabled = false;
            durationOfPlayback.Text = (musicTrackBar.Value / 60).ToString("00") + ":" + (musicTrackBar.Value % 60).ToString("00");
        }
    }
}
