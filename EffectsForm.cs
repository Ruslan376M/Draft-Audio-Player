using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Dsp;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace Draft_Audio_Player_New_Design
{
    public partial class EffectsForm : Form
    {
        public EffectsForm()
        {
            InitializeComponent();
        }

        SmbPitchShiftingSampleProvider pitch;
        private void pitchTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            pitchValueLabel.Text = pitchTrackBar.Value.ToString();
            var currentPitch = Math.Pow(2, (pitchTrackBar.Value * 1.0) / 6);
            if (pitch == null)
            { 
                pitch = new SmbPitchShiftingSampleProvider(MainForm.fileReader.ToSampleProvider());
                MainForm.outputDevice.Stop();
                pitch.PitchFactor = (float)currentPitch;
                MainForm.outputDevice.Init(pitch);
                MainForm.outputDevice.Play();
            }
            else
                pitch.PitchFactor = (float)currentPitch;
        }

        private void equalizer_Click(object sender, EventArgs e)
        {
            EqualizerForm Эквалайзер = new EqualizerForm();
            Эквалайзер.Show(); 
        }

        private void mono_Click(object sender, EventArgs e)
        {
            if (MainForm.fileReader.WaveFormat.Channels == 2)
            {
                var mono = new StereoToMonoSampleProvider(MainForm.fileReader.ToSampleProvider());
                MainForm.outputDevice.Stop();
                MainForm.outputDevice.Init(mono);
                MainForm.outputDevice.Play();
            }
        }

        private void stereo_Click(object sender, EventArgs e)
        {
            if (MainForm.fileReader.WaveFormat.Channels == 1)
            {
                var stereo = new MonoToStereoSampleProvider(MainForm.fileReader.ToSampleProvider());
                MainForm.outputDevice.Stop();
                MainForm.outputDevice.Init(stereo);
                MainForm.outputDevice.Play();
            }
        }

        public static int maxDur = 0;
        public static int minDur = 0;
        public static bool is_fixed = false;
        private void loopRangeBar_RangeChanging(object sender, EventArgs e)
        {
            is_fixed = true;
            loopRangeBar.TotalMaximum = MainForm.maxDur;
            minDurLabel.Text = (loopRangeBar.RangeMinimum / 60).ToString("00") + ":" + (loopRangeBar.RangeMinimum % 60).ToString("00");
            minDur = loopRangeBar.RangeMinimum;
            maxDurLabel.Text = (loopRangeBar.RangeMaximum / 60).ToString("00") + ":" + (loopRangeBar.RangeMaximum % 60).ToString("00");
            maxDur = loopRangeBar.RangeMaximum;
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            is_fixed = false;
            
            loopRangeBar.RangeMinimum = 0;
            minDurLabel.Text = ("00") + ":" + ("00");
            loopRangeBar.RangeMaximum = loopRangeBar.TotalMaximum = MainForm.maxDur; 
            maxDurLabel.Text = (loopRangeBar.TotalMaximum / 60).ToString("00") + ":" + (loopRangeBar.TotalMaximum % 60).ToString("00");

        }

        private void startLoopButton_Click(object sender, EventArgs e)
        {

            MusicListForm.currentTrackIndex -= 1;
            Program.mainForm.forwardButton_Click(null, null);
        }
    }
}
