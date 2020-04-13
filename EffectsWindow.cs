using NAudio.Wave;
using System;
using System.Windows.Forms;

namespace Music_Speed_And_Pitch_Changer
{
    public partial class EffectsWindow : Form
    {
        public void applyTheme()
        {
            this.BackColor = Program.themeControl.firstColor;
            this.pitchLabel.ForeColor = Program.themeControl.secondColor;
            this.minusPitchButton.ForeColor = Program.themeControl.secondColor;
            this.minusPitchButton.FlatAppearance.MouseDownBackColor = Program.themeControl.firstColor;
            this.plusPitchButton.ForeColor = Program.themeControl.secondColor;
            this.plusPitchButton.FlatAppearance.MouseDownBackColor = Program.themeControl.firstColor;
            this.pitchValueLabel.ForeColor = Program.themeControl.secondColor;
            this.tempValueLabel.ForeColor = Program.themeControl.secondColor;
            this.plusTempButton.ForeColor = Program.themeControl.secondColor;
            this.plusTempButton.FlatAppearance.MouseDownBackColor = Program.themeControl.firstColor;
            this.minusTempButton.ForeColor = Program.themeControl.secondColor;
            this.minusTempButton.FlatAppearance.MouseDownBackColor = Program.themeControl.firstColor;
            this.tempLabel.ForeColor = Program.themeControl.secondColor;
            this.tempTrackBar.TrackLineSelectedColor = Program.themeControl.accentColor;
            this.tempTrackBar.TrackerColor = Program.themeControl.accentColor;
            this.tempTrackBar.TrackLineColor = Program.themeControl.thirdColor;
            this.pitchTrackBar.TrackLineSelectedColor = Program.themeControl.accentColor;
            this.pitchTrackBar.TrackerColor = Program.themeControl.accentColor;
            this.pitchTrackBar.TrackLineColor = Program.themeControl.thirdColor;
            this.maxDurLabel.ForeColor = Program.themeControl.secondColor;
            this.minDurLabel.ForeColor = Program.themeControl.secondColor;
            this.LoopLabel.ForeColor = Program.themeControl.secondColor;
            this.loopRangeBar.InnerColor = Program.themeControl.accentColor;
            this.resetButton.ForeColor = Program.themeControl.secondColor;
            this.resetButton.FlatAppearance.MouseDownBackColor = Program.themeControl.firstColor;
            this.label1.ForeColor = Program.themeControl.secondColor;
            this.band1TrackBar.TrackerColor = Program.themeControl.accentColor;
            this.band1TrackBar.TrackLineColor = Program.themeControl.thirdColor;
            this.band1TrackBar.TrackLineSelectedColor = Program.themeControl.accentColor;
            this.band2TrackBar.TrackLineSelectedColor = Program.themeControl.accentColor;
            this.band2TrackBar.TrackerColor = Program.themeControl.accentColor;
            this.band2TrackBar.TrackLineColor = Program.themeControl.thirdColor;
            this.band3TrackBar.TrackLineSelectedColor = Program.themeControl.accentColor;
            this.band3TrackBar.TrackerColor = Program.themeControl.accentColor;
            this.band3TrackBar.TrackLineColor = Program.themeControl.thirdColor;
            this.band4TrackBar.TrackLineSelectedColor = Program.themeControl.accentColor;
            this.band4TrackBar.TrackerColor = Program.themeControl.accentColor;
            this.band4TrackBar.TrackLineColor = Program.themeControl.thirdColor;
            this.band8TrackBar.TrackLineSelectedColor = Program.themeControl.accentColor;
            this.band8TrackBar.TrackerColor = Program.themeControl.accentColor;
            this.band8TrackBar.TrackLineColor = Program.themeControl.thirdColor;
            this.band7TrackBar.TrackLineSelectedColor = Program.themeControl.accentColor;
            this.band7TrackBar.TrackerColor = Program.themeControl.accentColor;
            this.band7TrackBar.TrackLineColor = Program.themeControl.thirdColor;
            this.band6TrackBar.TrackLineSelectedColor = Program.themeControl.accentColor;
            this.band6TrackBar.TrackerColor = Program.themeControl.accentColor;
            this.band6TrackBar.TrackLineColor = Program.themeControl.thirdColor;
            this.band5TrackBar.TrackLineSelectedColor = Program.themeControl.accentColor;
            this.band5TrackBar.TrackerColor = Program.themeControl.accentColor;
            this.band5TrackBar.TrackLineColor = Program.themeControl.thirdColor;
            this.band10TrackBar.TrackLineSelectedColor = Program.themeControl.accentColor;
            this.band10TrackBar.TrackerColor = Program.themeControl.accentColor;
            this.band10TrackBar.TrackLineColor = Program.themeControl.thirdColor;
            this.band9TrackBar.TrackLineSelectedColor = Program.themeControl.accentColor;
            this.band9TrackBar.TrackerColor = Program.themeControl.accentColor;
            this.band9TrackBar.TrackLineColor = Program.themeControl.thirdColor;
            this.label9.ForeColor = Program.themeControl.secondColor;
            this.label10.ForeColor = Program.themeControl.secondColor;
            this.label11.ForeColor = Program.themeControl.secondColor;
            this.label12.ForeColor = Program.themeControl.secondColor;
            this.label13.ForeColor = Program.themeControl.secondColor;
            this.label14.ForeColor = Program.themeControl.secondColor;
            this.label15.ForeColor = Program.themeControl.secondColor;
            this.label16.ForeColor = Program.themeControl.secondColor;
            this.label17.ForeColor = Program.themeControl.secondColor;
            this.label18.ForeColor = Program.themeControl.secondColor;
            this.label19.ForeColor = Program.themeControl.secondColor;
            this.label20.ForeColor = Program.themeControl.secondColor;
            this.resetEqualizerButton.ForeColor = Program.themeControl.secondColor;
            this.resetEqualizerButton.FlatAppearance.MouseDownBackColor = Program.themeControl.firstColor;
        }
        public EffectsWindow()
        {
            InitializeComponent();
            applyTheme();
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
