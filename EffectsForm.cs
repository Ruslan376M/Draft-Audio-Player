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
    }
}
