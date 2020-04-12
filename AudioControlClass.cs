using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using NAudioWpfDemo.EqualizationDemo;
using SoundTouch;
using SoundTouch.Net;
using SoundTouch.Net.NAudioSupport;


namespace This_is_fine
{
    public class AudioControlClass
    {
        public string folderPath;
        public int indexOfPlayingFile;
        int repeatMode = 0;//0 - без повтора, 1 - повтор всего плейлиста, 2 - повтор трека.
        public List<string> files = new List<string>();
        List<short> queue = new List<short>();

        double pitch = 0.0;
        double temp = 100.0;

        public MediaFoundationReader fileReader;
        public WaveOutEvent outputDevice;
        public SoundTouchWaveProvider waveProvider;

        public Equalizer equalizer;
        public EqualizerBand[] bands;

        public float MinimumGain = -12;
        public float MaximumGain = 12;

        public AudioControlClass(List<string> musicCollection, string pathToTheFolder)
        {
            files.AddRange(musicCollection);
            for (short i = 0; i < files.Count; i++)
                queue.Add((short)(i + 1));
            folderPath = pathToTheFolder;

            outputDevice = new WaveOutEvent();

            bands = new EqualizerBand[]
                    {
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 31, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 62, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 125, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 250, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 500, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 1000, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 2000, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 4000, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 8000, Gain = 0},
                        new EqualizerBand {Bandwidth = 0.8f, Frequency = 16000, Gain = 0},
                    };

            /*StreamReader M3UReader = new StreamReader(playListPath);
            string line;
            while ((line = M3UReader.ReadLine()) != null)
                if (line[0] != '#')
                    files.Add(line);
            M3UReader.Close();
            */
        }
        
        public void initMusicFile(int index)
        {
            if(fileReader!=null)
            {
                outputDevice.Stop();
                waveProvider.Clear();
            }

            indexOfPlayingFile = index;
            fileReader = new MediaFoundationReader(folderPath + "\\" + files[indexOfPlayingFile]);
            Program.mainWindow.musicTrackBar.Maximum = fileReader.TotalTime.Minutes * 60 + fileReader.TotalTime.Seconds;
            Program.mainWindow.maximumDuration.Text = Program.audioControl.fileReader.TotalTime.Minutes.ToString("00") + ":" + Program.audioControl.fileReader.TotalTime.Seconds.ToString("00");
            SoundTouchProcessor soundProcessor = new SoundTouchProcessor();
            SampleToWaveProvider waveProviderBuffer = new SampleToWaveProvider(fileReader.ToSampleProvider());
            waveProvider = new SoundTouchWaveProvider(waveProviderBuffer, soundProcessor);
            waveProvider.Pitch = Math.Pow(2, (pitch) / 12);
            waveProvider.Tempo = temp / 100;
            equalizer = new Equalizer(waveProvider.ToSampleProvider(), bands);
            outputDevice.Init(equalizer);

            var tagFile = TagLib.File.Create(folderPath + "\\" + files[indexOfPlayingFile]);
            Program.mainWindow.nameOfCurrentTrackLabel.Text = tagFile.Tag.Title + "\n" + tagFile.Tag.FirstPerformer;
            if (tagFile.Tag.Pictures.Length >= 1)
            {
                var bin = (byte[])(tagFile.Tag.Pictures[0].Data.Data);
                Program.mainWindow.coverPictureBox.Image = System.Drawing.Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(100, 100, null, IntPtr.Zero);
            }
            else
                Program.mainWindow.coverPictureBox.Image = Program.mainWindow.coverPictureBox.ErrorImage;
            if(Program.effectsWindow.loopRangeBar.TotalMaximum != fileReader.TotalTime.Minutes * 60 + fileReader.TotalTime.Seconds)
            {
                Program.effectsWindow.loopRangeBar.TotalMaximum = fileReader.TotalTime.Minutes * 60 + fileReader.TotalTime.Seconds;
                Program.effectsWindow.loopRangeBar.RangeMaximum = Program.effectsWindow.loopRangeBar.TotalMaximum;
                Program.effectsWindow.resetButton_Click(null, null);
            }
            //outputDevice.PlaybackStopped += OutputDevice_PlaybackStopped;
        }
        /// <summary>
        /// Если проигрывание остановлено, смотреть на очередь и режим повтора
        /// </summary>
        private void OutputDevice_PlaybackStopped(object sender, NAudio.Wave.StoppedEventArgs e)
        {
            /*if (repeatMode == 0)
            {
                if (indexOfPlayingFile + 1 < files.Count)
                {
                    initMusicFile(indexOfPlayingFile + 1);
                    outputDevice.Play();
                } 
                else
                {
                    outputDevice.Stop();
                }
            }
            else if (repeatMode == 1)
            {

            }
            else if (repeatMode == 2) 
            {

            }*/
        }

        public void play()
        {
            outputDevice.Play();
            Program.mainWindow.timerOfPlayback.Start();
        }

        public void pause()
        {
            outputDevice.Pause();
            Program.mainWindow.timerOfPlayback.Stop();
        }

        public void stop()
        {
            outputDevice.Stop();
            fileReader.Close();
            fileReader.Dispose();
            Program.mainWindow.timerOfPlayback.Stop();
        }

        public void pitchSet(double pitchBuffer)
        {
            pitch = pitchBuffer;
            waveProvider.Pitch = Math.Pow(2, (pitch) / 12);

        }

        public void tempSet(double tempBuffer)
        {
            temp = tempBuffer;
            waveProvider.Tempo = temp / 100;
        }

        
    }
}
