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
//using NAudio.Dsp;
//using NAudio.Wave;
//using NAudio.Wave.SampleProviders;

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
		private void closee_Click(object sender, EventArgs e)
		{
			Stop();
			this.Close();
		}

		private void apply_Click(object sender, EventArgs e)
		{
			Stop();
			if (WasapiOut.IsSupportedOnCurrentPlatform)
				_soundOut = new WasapiOut();
			else
				_soundOut = new DirectSoundOut();
			int filenamess = MusicListForm.currentTrackIndex;
			var source = CodecFactory.Instance.GetCodec(Program.musicFolderPath + "\\" + Program.fileQueue[filenamess])
				.Loop()
				.ChangeSampleRate(44100)
				.ToSampleSource()
				.AppendSource(Equalizer.Create10BandEqualizer, out _equalizer)
				.ToWaveSource();

			MainForm.outputDevice.Stop();
			_soundOut.Initialize(source);
			_soundOut.Play();
		}

		private void Stop()
		{
			if (_soundOut != null)
			{
				_soundOut.Stop();
				_soundOut.Dispose();
				_equalizer.Dispose();
				_soundOut = null;
			}
		}
	}
}
