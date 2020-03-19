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

        //Показывает состояние проигрывания музыки
        public static bool musicIsPlaying = false;

        //Показывает состояние кнопки randomizeButton
        public static bool is_randomized = false;

        //Для открытия одной формы, нужно скрыть другую
        //Делегат, после показа новой формы, сохраняет в себе инструкцию для последующего её скрытия
        delegate void hideCurrentFormDelegate();
        hideCurrentFormDelegate hideCurrentForm;



        public MainForm()
        {
            InitializeComponent();
            //Привязка форм к правой панели (mainFormSplitContainer.Panel2)
            mainFormSplitContainer.Panel2.Controls.Add(Program.musicListForm);
            mainFormSplitContainer.Panel2.Controls.Add(Program.effectsForm);
            mainFormSplitContainer.Panel2.Controls.Add(Program.editorForm);
            mainFormSplitContainer.Panel2.Controls.Add(Program.settingsForm);
            mainFormSplitContainer.Panel2.Controls.Add(Program.aboutForm);
            //При запуске программы сразу показать окно со списком музыки
            //Program.musicListForm.Show();
            //Первая инструкция для делегата на скрытие первой открытой формы
            hideCurrentForm = Program.musicListForm.Hide;
        }

        //Действие при нажатии кнопки Play на MainForm
        private void playButton_Click(object sender, EventArgs e)
        {
            if (musicIsPlaying == true)//Если музыка играет, нужно поставить воспроизведение на паузу, а у кнопок, отвечающих за проигрывание, соответсвенно изменить иконку
            {
                outputDevice.Pause();
                timerOfPlayback.Stop();
                playButton.Text = "";
                MusicListForm.play[MusicListForm.currentTrackIndex].Text = "";
                musicIsPlaying = false;
            }
            else if (outputDevice != null)//Проверка на наличие файла для воспроизведения, если есть - начать проигрывание, сменить иконки
            {
                outputDevice.Play();
                timerOfPlayback.Start();
                playButton.Text = "";
                MusicListForm.play[MusicListForm.currentTrackIndex].Text = "";
                musicIsPlaying = true;
            }
            else if (Program.fileQueue.Count != 0)//Если был указан путь к папке, и кнопка Play нажата, запустим самый первый трек в списке
            {
                playButton.Text = "";
                MusicListForm.play[MusicListForm.currentTrackIndex].Text = "";
                MusicListForm.previousButton = MusicListForm.currentTrackIndex;
                Program.mainForm.playMusic(Convert.ToInt32(MusicListForm.play[MusicListForm.currentTrackIndex].Name));
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
            Program.musicListForm.Show();
            hideCurrentForm = Program.musicListForm.Hide;
        }

        private void navigationEffectsPanel_Click(object sender, EventArgs e)
        {
            hideCurrentForm();
            Program.effectsForm.Show();
            hideCurrentForm = Program.effectsForm.Hide;
        }

        private void navigationEditorPanel_Click(object sender, EventArgs e)
        {
            hideCurrentForm();
            Program.editorForm.Show();
            hideCurrentForm = Program.editorForm.Hide;
        }

        private void navigationSettingsPanel_Click(object sender, EventArgs e)
        {
            hideCurrentForm();
            Program.settingsForm.Show();
            hideCurrentForm = Program.settingsForm.Hide;
        }

        private void navigationAboutPanel_Click(object sender, EventArgs e)
        {
            hideCurrentForm();
            Program.aboutForm.Show();
            hideCurrentForm = Program.aboutForm.Hide;
        }

        //Общая функция для запуска воспроизведения музыки с указанным индексом в fileQueue
        public void playMusic(int indexOfTrackInFileQueue)
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

        //Событие, возникающие в таймере через секундный интервал
        private void timerOfPlayback_Tick(object sender, EventArgs e)
        {
            musicTrackBar.Value = fileReader.CurrentTime.Minutes * 60 + fileReader.CurrentTime.Seconds;
            durationOfPlayback.Text = fileReader.CurrentTime.Minutes.ToString("00") + ":" + fileReader.CurrentTime.Seconds.ToString("00");
            if ((fileReader.CurrentTime.Seconds + fileReader.CurrentTime.Minutes * 60) == (fileReader.TotalTime.Minutes * 60 + fileReader.TotalTime.Seconds))
            {
                if (MusicListForm.currentTrackIndex == Program.fileQueue.Count - 1)
                    return;
                durationOfPlayback.Text = "00:00";
                musicTrackBar.Value = 0;
                timerOfPlayback.Stop();
                if (MusicListForm.currentTrackIndex == Program.fileQueue.Count - 1)
                {
                    if (Program.repeatMode == 0)
                        forwardButton_Click(null, null);
                    else if (Program.repeatMode == 1)
                    {
                        MusicListForm.currentTrackIndex = 0;
                        backwardButton_Click(null, null);
                    }
                    else if (Program.repeatMode == 2)
                    {
                        MusicListForm.currentTrackIndex -= 1;
                        forwardButton_Click(null, null);
                    }
                }
                else if (Program.repeatMode == 2)
                {
                    MusicListForm.currentTrackIndex -= 1;
                    forwardButton_Click(null, null);
                }
                else
                    forwardButton_Click(null, null);
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

        private void forwardButton_Click(object sender, EventArgs e)
        {
             if (MusicListForm.currentTrackIndex == Program.fileQueue.Count - 1)
            {
                playMusic(MusicListForm.currentTrackIndex);
            }
            else if (MusicListForm.currentTrackIndex < Program.fileQueue.Count)
            {
                if (MusicListForm.previousButton != -1)
                    MusicListForm.play[MusicListForm.previousButton].Text = "";
                if (Program.is_random == true && Program.repeatMode != 2)
                {
                    if (Program.excludeIndexes.Count > 0)
                        MusicListForm.currentTrackIndex = getRandomIndex();
                }
                else
                    MusicListForm.currentTrackIndex += 1;
                playMusic(MusicListForm.currentTrackIndex);
                MusicListForm.previousButton = MusicListForm.currentTrackIndex;
                playButton.Text = "";
                MusicListForm.play[MusicListForm.previousButton].Text = "";
            }
            else
            {
                if (outputDevice != null)
                {
                    outputDevice.Stop();
                    timerOfPlayback.Stop();
                    playButton.Text = "";
                    MusicListForm.play[MusicListForm.currentTrackIndex].Text = "";
                    musicIsPlaying = false;
                }
            }
        }

        private void backwardButton_Click(object sender, EventArgs e)
        {
            if (MusicListForm.currentTrackIndex > 0)
            {
                if (MusicListForm.previousButton != -1)
                    MusicListForm.play[MusicListForm.previousButton].Text = "";
                if (Program.is_random == true && Program.repeatMode != 2)
                {
                    if (Program.excludeIndexes.Count > 0)
                    {
                        MusicListForm.currentTrackIndex = Program.excludeIndexes[Program.excludeIndexes.Count - 1];
                        Program.excludeIndexes.RemoveAt(Program.excludeIndexes.Count - 1);
                    }
                }
                else
                    MusicListForm.currentTrackIndex -= 1;
                playMusic(MusicListForm.currentTrackIndex);
                MusicListForm.previousButton = MusicListForm.currentTrackIndex;
                playButton.Text = "";
                MusicListForm.play[MusicListForm.previousButton].Text = "";
            }
            else if (MusicListForm.currentTrackIndex == 0)
            {
                if (MusicListForm.previousButton != -1)
                    MusicListForm.play[MusicListForm.previousButton].Text = "";
                MusicListForm.previousButton = 0;
                playMusic(MusicListForm.currentTrackIndex);
                playButton.Text = "";
                MusicListForm.play[MusicListForm.previousButton].Text = "";
            }
            else
            {
                if (outputDevice != null)
                {
                    outputDevice.Stop();
                    timerOfPlayback.Stop();
                    playButton.Text = "";
                    MusicListForm.play[MusicListForm.currentTrackIndex].Text = "";
                    musicIsPlaying = false;
                }
            }
        }

        Random randomizer = new Random();

        private int getRandomIndex()
        {
            var range = Enumerable.Range(0, Program.fileQueue.Count - 1).Where(i => !Program.excludeIndexes.Contains(i));

            int index = randomizer.Next(0, Program.fileQueue.Count - 1 - Program.excludeIndexes.Count);
            Program.excludeIndexes.Add(index);
            return index;
        }

        private void randomizeButton_Click(object sender, EventArgs e)
        {
            if (Program.is_random == false)
            {
                randomizeButton.BackColor = Color.SteelBlue;
                Program.excludeIndexes.Add(MusicListForm.currentTrackIndex);
                Program.is_random = true;
            }
            else if (Program.is_random == true)
            {
                randomizeButton.BackColor = Color.Transparent;
                Program.excludeIndexes.Clear();
                Program.is_random = false;
            }

        }

        private void repeatButton_Click(object sender, EventArgs e)
        {
            if (Program.repeatMode == 0)
            {
                repeatButton.BackColor = Color.SteelBlue;
                Program.repeatMode = 1;
            }
            else if (Program.repeatMode == 1)
            {
                repeatButton.BackColor = Color.SteelBlue;
                repeatButton.Text = "";
                Program.repeatMode = 2;
            }
            else if (Program.repeatMode == 2)
            {
                repeatButton.BackColor = Color.Transparent;
                repeatButton.Text = "";
                Program.repeatMode = 0;
            }
        }
    }
}
