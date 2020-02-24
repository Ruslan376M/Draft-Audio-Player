using System;
using System.IO;
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
using System.Runtime.InteropServices;
using NAudio.Wave;
using NAudio.Wave.SampleProviders;

namespace Draft_Audio_Player
{
    public partial class DraftAudioPlayerMainForm : Form
    {
        WaveOutEvent outputDevice;
        MediaFoundationReader fileReader;
        bool musicIsPlaying = false;
        string audioPath = "";
        string musicFolderPath = "";
        string[] fileNames;
        System.Windows.Forms.Panel[] musicListPanels;
        System.Windows.Forms.Label[] musicListPanelsLabelNames;
        System.Windows.Forms.Label[] musicListPanelsLabelDurations;
        System.Windows.Forms.Button[] musicListPanelsButton;
        System.Windows.Forms.CheckBox[] musicListPanelsCheckBox;
        bool repeatButton = false;


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
            else if (playButton.Text == "")
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
            fileReader = new MediaFoundationReader(audioPath);
            outputDevice = new WaveOutEvent();
            outputDevice.Init(fileReader);
            musicTrackBar.Maximum = fileReader.TotalTime.Minutes * 60 + fileReader.TotalTime.Seconds;
            maximumDuration.Text = fileReader.TotalTime.Minutes.ToString("00") + ":" + fileReader.TotalTime.Seconds.ToString("00");
        }

        private void timerOfPlayback_Tick(object sender, EventArgs e)
        {
            musicTrackBar.Value = fileReader.CurrentTime.Minutes * 60 + fileReader.CurrentTime.Seconds;
            durationOfPlayback.Text = fileReader.CurrentTime.Minutes.ToString("00") + ":" + fileReader.CurrentTime.Seconds.ToString("00");
            if ((fileReader.CurrentTime.Seconds + fileReader.CurrentTime.Minutes) == (fileReader.TotalTime.Minutes + fileReader.TotalTime.Seconds) && repeatButton == true)
            {
                outputDevice.Stop();
                fileReader.Position = 0;
                timerOfPlayback.Stop();
                outputDevice.Play();
                timerOfPlayback.Start();
                musicIsPlaying = true;
                timerOfPlayback.Enabled = true;
            }
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

        private  void directoryChooseButton_Click(object sender, EventArgs e)
        {
            
            if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                musicFolderPath = folderBrowserDialog.SelectedPath;
                fileNames = Directory.GetFileSystemEntries(musicFolderPath, "*.mp3", SearchOption.AllDirectories);

                for (int i = fileNames.Length - 1; i >= 0; i--)
                {
                    
                    musicListPanels = new System.Windows.Forms.Panel[fileNames.Length];
                    musicListPanelsLabelNames = new System.Windows.Forms.Label[fileNames.Length];
                    musicListPanelsLabelDurations = new System.Windows.Forms.Label[fileNames.Length];
                    musicListPanelsButton = new System.Windows.Forms.Button[fileNames.Length];
                    musicListPanelsCheckBox = new System.Windows.Forms.CheckBox[fileNames.Length];

                    

                    musicListPanels[i] = new System.Windows.Forms.Panel();
                    musicListPanels[i].Location = new System.Drawing.Point(0, i*32);
                    musicListPanels[i].Name = "musicListPanel" + i.ToString();
                    musicListPanels[i].Size = new System.Drawing.Size(panel2.Width-20, 32);
                    musicListPanels[i].TabIndex = 1;
                    panel2.Controls.Add(musicListPanels[i]);

                    musicListPanelsCheckBox[i] = new System.Windows.Forms.CheckBox();
                    musicListPanels[i].Controls.Add(musicListPanelsCheckBox[i]);
                    musicListPanelsCheckBox[i].Anchor = System.Windows.Forms.AnchorStyles.None;
                    musicListPanelsCheckBox[i].CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    musicListPanelsCheckBox[i].Location = new System.Drawing.Point(3, 5);
                    musicListPanelsCheckBox[i].Name = "CheckBox" + i.ToString();
                    musicListPanelsCheckBox[i].Size = new System.Drawing.Size(25, 24);
                    musicListPanelsCheckBox[i].TabIndex = 0;

                    musicListPanelsLabelNames[i] = new System.Windows.Forms.Label();
                    musicListPanelsLabelNames[i].Location = new System.Drawing.Point(34, 10);
                    musicListPanelsLabelNames[i].Name = "label1";
                    musicListPanelsLabelNames[i].Size = new System.Drawing.Size(172, 13);
                    musicListPanelsLabelNames[i].TabIndex = 1;
                    musicListPanelsLabelNames[i].Text = fileNames[i].Substring(fileNames[i].LastIndexOf("\\") + 1);
                    musicListPanels[i].Controls.Add(this.musicListPanelsLabelNames[i]);


                    musicListPanelsButton[i] = new System.Windows.Forms.Button();
                    musicListPanelsButton[i].BackColor = System.Drawing.Color.Transparent;
                    musicListPanelsButton[i].BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
                    musicListPanelsButton[i].FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
                    musicListPanelsButton[i].FlatAppearance.BorderSize = 0;
                    musicListPanelsButton[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    musicListPanelsButton[i].Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    musicListPanelsButton[i].Location = new System.Drawing.Point(211, 1);
                    musicListPanelsButton[i].Name = i.ToString();
                    musicListPanelsButton[i].Size = new System.Drawing.Size(30, 30);
                    musicListPanelsButton[i].TabIndex = 2;
                    musicListPanelsButton[i].Text = "";
                    musicListPanelsButton[i].UseVisualStyleBackColor = false;
                    musicListPanelsButton[i].Click += new System.EventHandler(musicListPanelsButton_Click);
                    musicListPanels[i].Controls.Add(musicListPanelsButton[i]);

                    musicListPanelsLabelDurations[i] = new System.Windows.Forms.Label();
                    musicListPanelsLabelDurations[i].Location = new System.Drawing.Point(247, 10);
                    musicListPanelsLabelDurations[i].Name = "musicListPanelsLabelNames" + i.ToString();
                    musicListPanelsLabelDurations[i].Size = new System.Drawing.Size(172, 13);
                    musicListPanelsLabelDurations[i].TabIndex = 3;
                    musicListPanelsLabelDurations[i].Text = "00:00";
                    musicListPanels[i].Controls.Add(musicListPanelsLabelDurations[i]);



                }
            }

        }

        private void musicListPanelsButton_Click(object sender, EventArgs e)
        {
            audioPath = fileNames[Convert.ToInt32((sender as System.Windows.Forms.Button).Name)];
            if (fileReader == null)
                fileReader = new MediaFoundationReader(audioPath);
            else
            {
                fileReader.Close();
                fileReader.Dispose();
                fileReader = new MediaFoundationReader(audioPath);
                
            }
            if (outputDevice == null)
                outputDevice = new WaveOutEvent();
            else
                outputDevice.Stop();
            musicTrackBar.Value = 0;
            musicIsPlaying = false;
            playButton.Text = "";
            timerOfPlayback.Enabled = false;
            outputDevice.Init(fileReader);
            musicTrackBar.Maximum = fileReader.TotalTime.Minutes * 60 + fileReader.TotalTime.Seconds;
            maximumDuration.Text = fileReader.TotalTime.Minutes.ToString("00") + ":" + fileReader.TotalTime.Seconds.ToString("00");
            playButton_Click(null, null);
        }

        private void cycleButton_Click(object sender, EventArgs e)
        {
            if (repeatButton == false)
            {
                repeatButton = true;
                cycleButton.BackColor = Color.Red;
            }
            else
            {
                repeatButton = false;
                cycleButton.BackColor = Color.White;
            }
        }

        private void panel2_Scroll(object sender, ScrollEventArgs e)
        {
            panel2.Update();
        }

        private void volumeTrackBar_Scroll(object sender, EventArgs e)
        {
            outputDevice.Volume = volumeTrackBar.Value / 100f;
            volumePercentLabel.Text = volumeTrackBar.Value.ToString() + "%";
        }
    }   
}
