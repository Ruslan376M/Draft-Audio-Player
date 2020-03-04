using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NAudio.Wave;

namespace Draft_Audio_Player_New_Design
{
    public partial class MainForm : Form
    {
        public static WaveOutEvent outputDevice;
        public static MediaFoundationReader fileReader;
        public static bool musicIsPlaying = false;

        //Инициализация побочных форм
        MusicListForm musicListForm = new MusicListForm() { Dock = DockStyle.Fill, TopLevel = false };
        EffectsForm effectsForm = new EffectsForm() { Dock = DockStyle.Fill, TopLevel = false };
        EditorForm editorForm = new EditorForm() { Dock = DockStyle.Fill, TopLevel = false };
        SettingsForm settingsForm = new SettingsForm() { Dock = DockStyle.Fill, TopLevel = false };
        AboutForm aboutForm = new AboutForm() { Dock = DockStyle.Fill, TopLevel = false };

        //Для открытия одной формы, нужно скрыть другую
        //Делегат, после показа новой формы, сохраняет в себе инструкцию для последующего её скрытия
        delegate void hideCurrentFormDelegate();
        hideCurrentFormDelegate hideCurrentForm;

        public static XComponent.SliderBar.MACTrackBar volumeTrackBar;
        public static System.Windows.Forms.Label durationOfPlayback;
        public static XComponent.SliderBar.MACTrackBar musicTrackBar;
        public static System.Windows.Forms.Label maximumDuration;
        public static System.Windows.Forms.PictureBox coverPictureBox;
        public static System.Windows.Forms.Label nameOfCurrentTrackLabel;
        public static System.Windows.Forms.Timer timerOfPlayback;
        public static System.Windows.Forms.Button playButton;

        public MainForm()
        {
            InitializeComponent();
            //Привязка форм к правой панели (mainFormSplitContainer.Panel2)
            mainFormSplitContainer.Panel2.Controls.Add(musicListForm);
            mainFormSplitContainer.Panel2.Controls.Add(effectsForm);
            mainFormSplitContainer.Panel2.Controls.Add(editorForm);
            mainFormSplitContainer.Panel2.Controls.Add(settingsForm);
            mainFormSplitContainer.Panel2.Controls.Add(aboutForm);
            //При запуске программы сразу показать окно со списком музыки
            musicListForm.Show();
            //Первая инструкция для делегата на скрытие первой открытой формы
            hideCurrentForm = musicListForm.Hide;

            //Держите этот кусок кода закрытым
            //Там ничего интересного
            //Просто для статической реализации элементов нужно было из InitializeComponent() вынести объявления
            {
                durationOfPlayback = new System.Windows.Forms.Label();
                volumeTrackBar = new XComponent.SliderBar.MACTrackBar();
                musicTrackBar = new XComponent.SliderBar.MACTrackBar();
                maximumDuration = new System.Windows.Forms.Label();
                nameOfCurrentTrackLabel = new System.Windows.Forms.Label();
                coverPictureBox = new System.Windows.Forms.PictureBox();
                timerOfPlayback = new System.Windows.Forms.Timer();
                playButton = new System.Windows.Forms.Button();

                musicPanel.Controls.Add(maximumDuration);
                musicPanel.Controls.Add(durationOfPlayback);
                musicPanel.Controls.Add(volumeTrackBar);
                musicPanel.Controls.Add(musicTrackBar);
                musicPanel.Controls.Add(nameOfCurrentTrackLabel);
                musicPanel.Controls.Add(coverPictureBox);
                musicControlsPanel.Controls.Add(playButton);

                ((System.ComponentModel.ISupportInitialize)(coverPictureBox)).BeginInit();
                ((System.ComponentModel.ISupportInitialize)(coverPictureBox)).EndInit();
                // 
                // nameOfCurrentTrackLabel
                // 
                nameOfCurrentTrackLabel.AutoEllipsis = true;
                nameOfCurrentTrackLabel.BackColor = System.Drawing.Color.Transparent;
                nameOfCurrentTrackLabel.CausesValidation = false;
                nameOfCurrentTrackLabel.Enabled = false;
                nameOfCurrentTrackLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                nameOfCurrentTrackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                nameOfCurrentTrackLabel.Location = new System.Drawing.Point(91, 5);
                nameOfCurrentTrackLabel.Name = "nameOfCurrentTrackLabel";
                nameOfCurrentTrackLabel.Size = new System.Drawing.Size(145, 80);
                nameOfCurrentTrackLabel.TabIndex = 2;
                // 
                // coverPictureBox
                // 
                coverPictureBox.Location = new System.Drawing.Point(5, 5);
                coverPictureBox.Name = "coverPictureBox";
                coverPictureBox.Size = new System.Drawing.Size(80, 80);
                coverPictureBox.TabIndex = 1;
                coverPictureBox.TabStop = false;
                // 
                // volumeTrackBar
                // 
                volumeTrackBar.BackColor = System.Drawing.Color.Transparent;
                volumeTrackBar.BorderColor = System.Drawing.Color.Transparent;
                volumeTrackBar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                volumeTrackBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
                volumeTrackBar.IndentHeight = 6;
                volumeTrackBar.Location = new System.Drawing.Point(622, 18);
                volumeTrackBar.Maximum = 100;
                volumeTrackBar.Minimum = 0;
                volumeTrackBar.MinimumSize = new System.Drawing.Size(100, 27);
                volumeTrackBar.Name = "volumeTrackBar";
                volumeTrackBar.Size = new System.Drawing.Size(150, 27);
                volumeTrackBar.TabIndex = 13;
                volumeTrackBar.TabStop = false;
                volumeTrackBar.TextTickStyle = System.Windows.Forms.TickStyle.None;
                volumeTrackBar.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
                volumeTrackBar.TickHeight = 1;
                volumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
                volumeTrackBar.TrackerColor = System.Drawing.Color.Snow;
                volumeTrackBar.TrackerSize = new System.Drawing.Size(15, 15);
                volumeTrackBar.TrackLineColor = System.Drawing.Color.Gray;
                volumeTrackBar.TrackLineHeight = 3;
                volumeTrackBar.TrackLineSelectedColor = System.Drawing.Color.SteelBlue;
                volumeTrackBar.Value = 100;
                volumeTrackBar.Scroll += new EventHandler(volumeTrackBar_Scroll);
                // 
                // durationOfPlayback
                // 
                durationOfPlayback.AutoSize = true;
                durationOfPlayback.Location = new System.Drawing.Point(200, 66);
                durationOfPlayback.Name = "durationOfPlayback";
                durationOfPlayback.Size = new System.Drawing.Size(34, 13);
                durationOfPlayback.TabIndex = 14;
                durationOfPlayback.Text = "00:00";
                // 
                // musicTrackBar
                // 
                musicTrackBar.BackColor = System.Drawing.Color.Transparent;
                musicTrackBar.BorderColor = System.Drawing.Color.Transparent;
                musicTrackBar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                musicTrackBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
                musicTrackBar.IndentHeight = 6;
                musicTrackBar.Location = new System.Drawing.Point(242, 61);
                musicTrackBar.Maximum = 50;
                musicTrackBar.Minimum = 0;
                musicTrackBar.MinimumSize = new System.Drawing.Size(300, 27);
                musicTrackBar.Name = "musicTrackBar";
                musicTrackBar.Size = new System.Drawing.Size(300, 27);
                musicTrackBar.TabIndex = 0;
                musicTrackBar.TabStop = false;
                musicTrackBar.TextTickStyle = System.Windows.Forms.TickStyle.None;
                musicTrackBar.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
                musicTrackBar.TickHeight = 1;
                musicTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
                musicTrackBar.TrackerColor = System.Drawing.Color.Snow;
                musicTrackBar.TrackerSize = new System.Drawing.Size(15, 15);
                musicTrackBar.TrackLineColor = System.Drawing.Color.Gray;
                musicTrackBar.TrackLineHeight = 3;
                musicTrackBar.TrackLineSelectedColor = System.Drawing.Color.SteelBlue;
                musicTrackBar.Value = 0;
                musicTrackBar.MouseUp += new MouseEventHandler(musicTrackBar_MouseUp);
                musicTrackBar.Scroll += new EventHandler(musicTrackBar_Scroll);
                // 
                // maximumDuration
                // 
                maximumDuration.AutoSize = true;
                maximumDuration.Location = new System.Drawing.Point(548, 66);
                maximumDuration.Name = "maximumDuration";
                maximumDuration.Size = new System.Drawing.Size(34, 13);
                maximumDuration.TabIndex = 15;
                maximumDuration.Text = "00:00";
                // 
                // timerOfPlayback
                // 
                timerOfPlayback.Interval = 1000;
                timerOfPlayback.Tick += new System.EventHandler(this.timerOfPlayback_Tick);
                // 
                // playButton
                // 
                playButton.BackColor = System.Drawing.Color.Transparent;
                playButton.CausesValidation = false;
                playButton.FlatAppearance.BorderSize = 0;
                playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
                playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
                playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                playButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                playButton.ForeColor = System.Drawing.Color.Transparent;
                playButton.Location = new System.Drawing.Point(115, 3);
                playButton.Name = "playButton";
                playButton.Size = new System.Drawing.Size(50, 50);
                playButton.Text = "";
                playButton.Click += new EventHandler(playButton_Click);
                durationOfPlayback.BringToFront();
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (musicIsPlaying == true)
            {
                outputDevice.Pause();
                timerOfPlayback.Stop();
                playButton.Text = "";
                MusicListForm.play[MusicListForm.previousButton].Text = "";
                musicIsPlaying = false;
            }
            else if (outputDevice != null)
            {
                outputDevice.Play();
                timerOfPlayback.Start();
                playButton.Text = "";
                MusicListForm.play[MusicListForm.previousButton].Text = "";
                musicIsPlaying = true;
            }
        }

        //Обработка нажатия на кнопку открытия/закрытия меню
        public void hamburgerButton_Click(object sender, EventArgs e)
        {
            if (mainFormSplitContainer.SplitterDistance == 50)
                mainFormSplitContainer.SplitterDistance = 300;
            else
                mainFormSplitContainer.SplitterDistance = 50;
        }

        //При изменении размера окна, следует изменить размеры элементов управления
        //Литералы - математически вычисленны, с учётом размеров элементов
        //При этом, 16 пикселей уходят на границы окна, то есть из 800 пикселей, реального места - 784
        private void MainForm_Resize(object sender, EventArgs e)
        {
            musicTrackBar.Width = this.Width - 500;
            musicControlsPanel.Location = new Point((this.Width - 296) / 2, musicControlsPanel.Location.Y);
            volumeTrackBar.Location = new Point(this.Width - 178, volumeTrackBar.Location.Y);
            maximumDuration.Location = new Point(this.Width - 252, maximumDuration.Location.Y);
        }

        //Обработка нажатия на кнопки меню навигации, формы уже инициализированы и добавлены, осталось их показать
        //Сначала скрывается существующая форма, затем показывается новая, потом инструкция для сокрытия этой формы передаются делегату
        private void navigationMusicPanel_Click(object sender, EventArgs e)
        {
            hideCurrentForm();
            musicListForm.Show();
            hideCurrentForm = musicListForm.Hide;
        }

        private void navigationEffectsPanel_Click(object sender, EventArgs e)
        {
            hideCurrentForm();
            effectsForm.Show();
            hideCurrentForm = effectsForm.Hide;
        }

        private void navigationEditorPanel_Click(object sender, EventArgs e)
        {
            hideCurrentForm();
            editorForm.Show();
            hideCurrentForm = editorForm.Hide;
        }

        private void navigationSettingsPanel_Click(object sender, EventArgs e)
        {
            hideCurrentForm();
            settingsForm.Show();
            hideCurrentForm = settingsForm.Hide;
        }

        private void navigationAboutPanel_Click(object sender, EventArgs e)
        {
            hideCurrentForm();
            aboutForm.Show();
            hideCurrentForm = aboutForm.Hide;
        }

        public static void playMusic(int indexOfTrackInFileQueue)
        {
            if (fileReader != null)
            {
                outputDevice.Stop();
                fileReader.Close();
                fileReader.Dispose();
            }
            fileReader = new MediaFoundationReader(Program.musicFolderPath + "\\" + Program.fileQueue[indexOfTrackInFileQueue]);

            if (outputDevice == null)
                outputDevice = new WaveOutEvent();
            else
                outputDevice.Stop();
            musicTrackBar.Value = 0;
            musicTrackBar.Maximum = fileReader.TotalTime.Minutes * 60 + fileReader.TotalTime.Seconds;
            maximumDuration.Text = fileReader.TotalTime.Minutes.ToString("00") + ":" + fileReader.TotalTime.Seconds.ToString("00");
            durationOfPlayback.Text = fileReader.CurrentTime.Minutes.ToString("00") + ":" + fileReader.CurrentTime.Seconds.ToString("00");
            outputDevice.Volume = volumeTrackBar.Value / 100f;

            var tagFile = TagLib.File.Create(Program.musicFolderPath + "\\" + Program.fileQueue[indexOfTrackInFileQueue]);
            nameOfCurrentTrackLabel.Text = tagFile.Tag.Title + "\n" + tagFile.Tag.FirstPerformer;
            if (tagFile.Tag.Pictures.Length >= 1)
            {
                var bin = (byte[])(tagFile.Tag.Pictures[0].Data.Data);
                coverPictureBox.Image = System.Drawing.Image.FromStream(new MemoryStream(bin)).GetThumbnailImage(100, 100, null, IntPtr.Zero);
            }
            else
                coverPictureBox.Image = coverPictureBox.ErrorImage;

            outputDevice.Init(fileReader);
            outputDevice.Play();
            musicIsPlaying = true;
            timerOfPlayback.Start();
        }

        private void timerOfPlayback_Tick(object sender, EventArgs e)
        {
            musicTrackBar.Value = fileReader.CurrentTime.Minutes * 60 + fileReader.CurrentTime.Seconds;
            durationOfPlayback.Text = fileReader.CurrentTime.Minutes.ToString("00") + ":" + fileReader.CurrentTime.Seconds.ToString("00");
            if ((fileReader.CurrentTime.Seconds + fileReader.CurrentTime.Minutes * 60) == (fileReader.TotalTime.Minutes * 60 + fileReader.TotalTime.Seconds))
            {
                durationOfPlayback.Text = "00:00";
                musicTrackBar.Value = 0;
                outputDevice.Stop();
                timerOfPlayback.Stop();
                /* Повтор проигрывания
                fileReader.Position = 0;
                outputDevice.Play();
                timerOfPlayback.Start();
                musicIsPlaying = true;
                timerOfPlayback.Enabled = true;*/
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

        private void volumeTrackBar_Scroll(object sender, EventArgs e)
        {
            if (outputDevice != null)
                outputDevice.Volume = volumeTrackBar.Value / 100f;
        }
    }
}
