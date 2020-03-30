using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CSCore;
using CSCore.Codecs;
using CSCore.SoundOut;
using CSCore.Streams;
using CSCore.Streams.Effects;

namespace Draft_Audio_Player_New_Design
{
    public partial class EqualizerForm : Form
    {
        private const double MaxDB = 20;

        private Equalizer _equalizer;
        private ISoundOut _soundOut;
        public EqualizerForm()
        {
            InitializeComponent();
        }

        private void band1_ValueChanged(object sender, EventArgs e)
        {
            var trackbar = sender as TrackBar;
            if (_equalizer != null && trackbar != null)
            {
                double perc = (trackbar.Value / (double)trackbar.Maximum);
                var value = (float)(perc * MaxDB);

                //the tag of the trackbar contains the index of the filter
                int filterIndex = Int32.Parse((string)trackbar.Tag);
                EqualizerFilter filter = _equalizer.SampleFilters[filterIndex];
                filter.AverageGainDB = value;
            }
        }
       
        private void button1_Click_1(object sender, EventArgs e)
        {
            var ofn = new OpenFileDialog();
            ofn.Filter = CodecFactory.SupportedFilesFilterEn;
            if (ofn.ShowDialog() == DialogResult.OK)
            { 
                if (WasapiOut.IsSupportedOnCurrentPlatform)
                    _soundOut = new WasapiOut();
                else
                    _soundOut = new DirectSoundOut();

                var source = CodecFactory.Instance.GetCodec(ofn.FileName)
                    .Loop()
                    .ChangeSampleRate(44100)
                    .ToSampleSource()
                    .AppendSource(Equalizer.Create10BandEqualizer, out _equalizer)
                    .ToWaveSource();

                _soundOut.Initialize(source);
                _soundOut.Play();
            }
        }
        

        private void closee_Click(object sender, EventArgs e)
        {
            _soundOut.Stop();
            this.Close();
        }
    }
}
