using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudioWpfDemo.EqualizationDemo;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace This_is_fine
{
    public partial class EffectsWindow : Form
    {
        public EffectsWindow()
        {
            InitializeComponent();
        }

        private void pitchTrackBar_ValueChanged(object sender, decimal value)
        {
            Program.audioControl.pitchSet(pitchTrackBar.Value);
            pitchValueLabel.Text = (pitchTrackBar.Value >= 0) ? "+" + pitchTrackBar.Value.ToString() : pitchTrackBar.Value.ToString();
        }

        private void tempTrackBar_ValueChanged(object sender, decimal value)
        {
            Program.audioControl.tempSet(tempTrackBar.Value);
            tempValueLabel.Text = tempTrackBar.Value.ToString() + "%";
        }

        private void plusPitchButton_Click(object sender, EventArgs e)
        {
            if (pitchTrackBar.Maximum != pitchTrackBar.Value)
                pitchTrackBar.Value += 1;
        }

        private void minusPitchButton_Click(object sender, EventArgs e)
        {
            if (pitchTrackBar.Minimum != pitchTrackBar.Value)
                pitchTrackBar.Value -= 1;
        }

        private void plusTempButton_Click(object sender, EventArgs e)
        {
            if (tempTrackBar.Maximum != tempTrackBar.Value)
                tempTrackBar.Value += 1;
        }

        private void minusTempButton_Click(object sender, EventArgs e)
        {
            if (tempTrackBar.Minimum != tempTrackBar.Value)
                tempTrackBar.Value -= 1;
        }

        public bool is_looped = false;

        private void loopRangeBar_RangeChanging(object sender, EventArgs e)
        {
            minDurLabel.Text = (loopRangeBar.RangeMinimum / 60).ToString("00") + ":" + (loopRangeBar.RangeMinimum % 60).ToString("00");
            maxDurLabel.Text = (loopRangeBar.RangeMaximum / 60).ToString("00") + ":" + (loopRangeBar.RangeMaximum % 60).ToString("00");
        }

        private void loopRangeBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (loopRangeBar.RangeMaximum != loopRangeBar.TotalMaximum || loopRangeBar.RangeMinimum != loopRangeBar.TotalMinimum)
            {
                is_looped = true;
            }
        }

        public void resetButton_Click(object sender, EventArgs e)
        {
            is_looped = false;
            loopRangeBar.RangeMinimum = 0;
            loopRangeBar.RangeMaximum = loopRangeBar.TotalMaximum;
            minDurLabel.Text = (loopRangeBar.RangeMinimum / 60).ToString("00") + ":" + (loopRangeBar.RangeMinimum % 60).ToString("00");
            maxDurLabel.Text = (loopRangeBar.RangeMaximum / 60).ToString("00") + ":" + (loopRangeBar.RangeMaximum % 60).ToString("00");
        }


        private void band1TrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            Program.audioControl.bands[0].Gain = band1TrackBar.Value / 10;
            Program.audioControl.equalizer = new Equalizer(Program.audioControl.waveProvider.ToSampleProvider(), Program.audioControl.bands);
            Program.audioControl.outputDevice.Stop();
            Program.audioControl.outputDevice.Init(Program.audioControl.equalizer);
            if (Program.musicListWindow.musicIsPlaying == true)
                Program.audioControl.outputDevice.Play();
        }

        private void band2TrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            Program.audioControl.bands[1].Gain = band2TrackBar.Value / 10;
            Program.audioControl.equalizer = new Equalizer(Program.audioControl.waveProvider.ToSampleProvider(), Program.audioControl.bands);
            Program.audioControl.outputDevice.Stop();
            Program.audioControl.outputDevice.Init(Program.audioControl.equalizer);
            if (Program.musicListWindow.musicIsPlaying == true)
                Program.audioControl.outputDevice.Play(); 
        }

        private void band3TrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            Program.audioControl.bands[2].Gain = band3TrackBar.Value / 10;
            Program.audioControl.equalizer = new Equalizer(Program.audioControl.waveProvider.ToSampleProvider(), Program.audioControl.bands);
            Program.audioControl.outputDevice.Stop();
            Program.audioControl.outputDevice.Init(Program.audioControl.equalizer);
            if (Program.musicListWindow.musicIsPlaying == true)
                Program.audioControl.outputDevice.Play();
        }

        private void band4TrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            Program.audioControl.bands[3].Gain = band4TrackBar.Value / 10;
            Program.audioControl.equalizer = new Equalizer(Program.audioControl.waveProvider.ToSampleProvider(), Program.audioControl.bands);
            Program.audioControl.outputDevice.Stop();
            Program.audioControl.outputDevice.Init(Program.audioControl.equalizer);
            if (Program.musicListWindow.musicIsPlaying == true)
                Program.audioControl.outputDevice.Play();
        }

        private void band5TrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            Program.audioControl.bands[4].Gain = band5TrackBar.Value / 10;
            Program.audioControl.equalizer = new Equalizer(Program.audioControl.waveProvider.ToSampleProvider(), Program.audioControl.bands);
            Program.audioControl.outputDevice.Stop();
            Program.audioControl.outputDevice.Init(Program.audioControl.equalizer);
            if (Program.musicListWindow.musicIsPlaying == true)
                Program.audioControl.outputDevice.Play();
        }

        private void band6TrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            Program.audioControl.bands[5].Gain = band6TrackBar.Value / 10;
            Program.audioControl.equalizer = new Equalizer(Program.audioControl.waveProvider.ToSampleProvider(), Program.audioControl.bands);
            Program.audioControl.outputDevice.Stop();
            Program.audioControl.outputDevice.Init(Program.audioControl.equalizer);
            if (Program.musicListWindow.musicIsPlaying == true)
                Program.audioControl.outputDevice.Play();
        }

        private void band7TrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            Program.audioControl.bands[6].Gain = band7TrackBar.Value / 10;
            Program.audioControl.equalizer = new Equalizer(Program.audioControl.waveProvider.ToSampleProvider(), Program.audioControl.bands);
            Program.audioControl.outputDevice.Stop();
            Program.audioControl.outputDevice.Init(Program.audioControl.equalizer);
            if (Program.musicListWindow.musicIsPlaying == true)
                Program.audioControl.outputDevice.Play();
        }

        private void band8TrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            Program.audioControl.bands[7].Gain = band8TrackBar.Value / 10;
            Program.audioControl.equalizer = new Equalizer(Program.audioControl.waveProvider.ToSampleProvider(), Program.audioControl.bands);
            Program.audioControl.outputDevice.Stop();
            Program.audioControl.outputDevice.Init(Program.audioControl.equalizer);
            if (Program.musicListWindow.musicIsPlaying == true)
                Program.audioControl.outputDevice.Play();
        }

        private void band9TrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            Program.audioControl.bands[8].Gain = band9TrackBar.Value / 10;
            Program.audioControl.equalizer = new Equalizer(Program.audioControl.waveProvider.ToSampleProvider(), Program.audioControl.bands);
            Program.audioControl.outputDevice.Stop();
            Program.audioControl.outputDevice.Init(Program.audioControl.equalizer);
            if (Program.musicListWindow.musicIsPlaying == true)
                Program.audioControl.outputDevice.Play();
        }

        private void band10TrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            Program.audioControl.bands[9].Gain = band10TrackBar.Value / 10;
            Program.audioControl.equalizer = new Equalizer(Program.audioControl.waveProvider.ToSampleProvider(), Program.audioControl.bands);
            Program.audioControl.outputDevice.Stop();
            Program.audioControl.outputDevice.Init(Program.audioControl.equalizer);
            if (Program.musicListWindow.musicIsPlaying == true)
                Program.audioControl.outputDevice.Play();
        }

        private void resetEqualizerButton_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
                Program.audioControl.bands[0].Gain = 0;
            band1TrackBar.Value = 0;
            band2TrackBar.Value = 0;
            band3TrackBar.Value = 0;
            band4TrackBar.Value = 0;
            band5TrackBar.Value = 0;
            band6TrackBar.Value = 0;
            band7TrackBar.Value = 0;
            band8TrackBar.Value = 0;
            band9TrackBar.Value = 0;
            band10TrackBar.Value = 0;
            Program.audioControl.equalizer = new Equalizer(Program.audioControl.waveProvider.ToSampleProvider(), Program.audioControl.bands);
            Program.audioControl.outputDevice.Stop();
            Program.audioControl.outputDevice.Init(Program.audioControl.equalizer);
            if (Program.musicListWindow.musicIsPlaying == true)
                Program.audioControl.outputDevice.Play();
        }
    }
}
