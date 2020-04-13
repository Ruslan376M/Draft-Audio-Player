using System;
using System.Drawing;
using System.Windows.Forms;


namespace Music_Speed_And_Pitch_Changer
{
    public partial class MainWindow : Form
    {
        public void applyTheme()
        {
            this.BackColor = Program.themeControl.firstColor;
            this.ForeColor = Program.themeControl.secondColor;
            musicPanel.BackColor = Program.themeControl.firstColor;
            musicPanel.ForeColor = Program.themeControl.secondColor;
            randomizeButton.ForeColor = Program.themeControl.secondColor;
            randomizeButton.FlatAppearance.MouseDownBackColor = Program.themeControl.thirdColor;
            randomizeButton.FlatAppearance.MouseOverBackColor = Program.themeControl.accentColor;
            backwardButton.ForeColor = Program.themeControl.secondColor;
            backwardButton.FlatAppearance.MouseDownBackColor = Program.themeControl.thirdColor;
            backwardButton.FlatAppearance.MouseOverBackColor = Program.themeControl.accentColor;
            playButton.ForeColor = Program.themeControl.secondColor;
            playButton.FlatAppearance.MouseDownBackColor = Program.themeControl.thirdColor;
            playButton.FlatAppearance.MouseOverBackColor = Program.themeControl.accentColor;
            forwardButton.ForeColor = Program.themeControl.secondColor;
            forwardButton.FlatAppearance.MouseDownBackColor = Program.themeControl.thirdColor;
            forwardButton.FlatAppearance.MouseOverBackColor = Program.themeControl.accentColor;
            repeatButton.ForeColor = Program.themeControl.secondColor;
            repeatButton.FlatAppearance.MouseDownBackColor = Program.themeControl.thirdColor;
            repeatButton.FlatAppearance.MouseOverBackColor = Program.themeControl.accentColor;
            musicTrackBar.TrackLineSelectedColor = Program.themeControl.accentColor;
            musicTrackBar.TrackerColor = Program.themeControl.accentColor;
            musicTrackBar.TrackLineColor = Program.themeControl.thirdColor;
            volumeTrackBar.TrackLineSelectedColor = Program.themeControl.accentColor;
            volumeTrackBar.TrackerColor = Program.themeControl.accentColor;
            volumeTrackBar.TrackLineColor = Program.themeControl.thirdColor;
            mainWindowSplitContainer.Panel1.BackColor = Program.themeControl.firstColor;
            hamburgerButton.ForeColor = Program.themeControl.secondColor;
            hamburgerButton.FlatAppearance.MouseDownBackColor = Program.themeControl.thirdColor;
            hamburgerButton.FlatAppearance.MouseOverBackColor = Program.themeControl.accentColor;
            navigationMusicPanel.ForeColor = Program.themeControl.secondColor;
            if (Program.audioControl != null)
            {
                if (Program.audioControl.is_random == true)
                    randomizeButton.BackColor = Program.themeControl.accentColor;
                if (Program.audioControl.repeatMode != 0)
                    repeatButton.BackColor = Program.themeControl.accentColor;
            }
        }
        //Для открытия одной формы, нужно скрыть другую
        //Делегат, после показа новой формы, сохраняет в себе инструкцию для последующего её скрытия

        delegate void hideCurrentWindowDelegate();
        hideCurrentWindowDelegate hideCurrentWindow;

        public AudioControlClass audioControl;

        public MainWindow()
        {
            InitializeComponent();
            //Привязка форм к правой панели (mainFormSplitContainer.Panel2)
            mainWindowSplitContainer.Panel2.Controls.Add(Program.musicListWindow);
            mainWindowSplitContainer.Panel2.Controls.Add(Program.effectsWindow);
            mainWindowSplitContainer.Panel2.Controls.Add(Program.editorWindow);
            mainWindowSplitContainer.Panel2.Controls.Add(Program.settingsWindow);
            mainWindowSplitContainer.Panel2.Controls.Add(Program.aboutWindow);

            //Первая инструкция для делегата на скрытие первой открытой формы
            hideCurrentWindow = Program.musicListWindow.Hide;
            applyTheme();
        }

        private void randomizeButton_Click(object sender, EventArgs e)
        {
            if (Program.audioControl.is_random == false)
            {
                randomizeButton.BackColor = Program.themeControl.accentColor;
                Program.audioControl.randomizeQueue(Program.audioControl.queue);
                Program.audioControl.is_random = true;
            }
            else if (Program.audioControl.is_random == true)
            {
                randomizeButton.BackColor = Color.Transparent;
                Program.audioControl.sortQueue(Program.audioControl.queue);
                Program.audioControl.is_random = false;
            }
        }

        public void backwardButton_Click(object sender, EventArgs e)
        {
            if (Program.musicListWindow.previousButtonIndex != -1)
            {

                Program.audioControl.queue.IndexOf((short)Program.musicListWindow.previousButtonIndex);
                if (Program.audioControl.queue.IndexOf((short)Program.musicListWindow.previousButtonIndex) - 1 >= 0)
                {
                    Program.musicListWindow.playButton_Click(Program.musicListWindow.play[Program.audioControl.queue[Program.audioControl.queue.IndexOf((short)Program.musicListWindow.previousButtonIndex) - 1]], null);
                }
                else if (Program.audioControl.queue.IndexOf((short)Program.musicListWindow.previousButtonIndex) - 1 < 0)
                {
                    Program.audioControl.initMusicFile(Program.audioControl.indexOfPlayingFile);
                    Program.audioControl.play();
                }
            }
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (Program.musicListWindow.previousButtonIndex != -1)
                Program.musicListWindow.playButton_Click(Program.musicListWindow.play[Program.musicListWindow.previousButtonIndex], null);
        }

        public void forwardButton_Click(object sender, EventArgs e)
        {
            if (Program.musicListWindow.previousButtonIndex != -1)
            {
                Program.audioControl.queue.IndexOf((short)Program.musicListWindow.previousButtonIndex);
                if (Program.audioControl.queue.IndexOf((short)Program.musicListWindow.previousButtonIndex) + 1 < Program.audioControl.queue.Count)
                    Program.musicListWindow.playButton_Click(Program.musicListWindow.play[Program.audioControl.queue[Program.audioControl.queue.IndexOf((short)Program.musicListWindow.previousButtonIndex) + 1]], null);
                else if (Program.audioControl.queue.IndexOf((short)Program.musicListWindow.previousButtonIndex) + 1 == Program.audioControl.queue.Count)
                {
                    if (Program.audioControl.repeatMode == 1)
                        Program.musicListWindow.playButton_Click(Program.musicListWindow.play[Program.audioControl.queue[0]], null);
                    else
                        Program.audioControl.stop();
                }
            }
        }

        private void repeatButton_Click(object sender, EventArgs e)
        {
            if (Program.audioControl.repeatMode == 0)
            {
                repeatButton.BackColor = Program.themeControl.accentColor;
                Program.audioControl.repeatMode = 1;
            }
            else if (Program.audioControl.repeatMode == 1)
            {
                repeatButton.BackColor = Program.themeControl.accentColor;
                repeatButton.Text = "";
                Program.audioControl.repeatMode = 2;
            }
            else if (Program.audioControl.repeatMode == 2)
            {
                repeatButton.BackColor = Color.Transparent;
                repeatButton.Text = "";
                Program.audioControl.repeatMode = 0;
            }
        }

        private void musicTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            if (Program.audioControl.fileReader != null)
            {
                Program.audioControl.outputDevice.Stop();
                Program.audioControl.initMusicFile(Program.audioControl.indexOfPlayingFile);
                Program.audioControl.fileReader.Position += (musicTrackBar.Value - Program.audioControl.fileReader.CurrentTime.Minutes * 60 - Program.audioControl.fileReader.CurrentTime.Seconds) * Program.audioControl.fileReader.WaveFormat.AverageBytesPerSecond;
                if (Program.musicListWindow.musicIsPlaying)
                    Program.audioControl.outputDevice.Play();

                timerOfPlayback.Enabled = true;
                durationLabel.Visible = false;
            }
        }

        private void musicTrackBar_Scroll(object sender, EventArgs e)
        {
            durationLabel.Visible = true;
            timerOfPlayback.Enabled = false;
            durationOfPlayback.Text = (musicTrackBar.Value / 60).ToString("00") + ":" + (musicTrackBar.Value % 60).ToString("00");
            durationLabel.Location = new Point(Convert.ToInt32((((float)(musicTrackBar.Width-25)/ (float)(musicTrackBar.Maximum))* musicTrackBar.Value)) + (musicTrackBar.Location.X - 3), 48);
            durationLabel.Text = (musicTrackBar.Value / 60).ToString("00") + ":" + (musicTrackBar.Value % 60).ToString("00");
        }

        private void volumeTrackBar_Scroll(object sender, EventArgs e)
        {
            if (Program.audioControl.outputDevice != null)
                Program.audioControl.outputDevice.Volume = volumeTrackBar.Value / 100f;
            volumeLabel.Visible = true;//820
            volumeLabel.Location = new Point((8167 * volumeTrackBar.Value * volumeTrackBar.Width / volumeTrackBar.Maximum / 10000) + (volumeTrackBar.Location.X + 15) - ((volumeTrackBar.Value > 9) ? 20 / 2 : 15 / 2), 9);
            volumeLabel.Text = volumeTrackBar.Value.ToString() + "%";
        }

        private void volumeTrackBar_MouseUp(object sender, MouseEventArgs e)
        {
            volumeLabel.Visible = false;
        }

        private void timerOfPlayback_Tick(object sender, EventArgs e)
        {
            if (Program.effectsWindow.is_looped == true)
            {
                if (Program.audioControl.fileReader.CurrentTime.Minutes * 60 + Program.audioControl.fileReader.CurrentTime.Seconds >= Program.effectsWindow.loopRangeBar.RangeMaximum || Program.audioControl.fileReader.CurrentTime.Minutes * 60 + Program.audioControl.fileReader.CurrentTime.Seconds < Program.effectsWindow.loopRangeBar.RangeMinimum)
                {
                    Program.audioControl.fileReader.Position = Program.effectsWindow.loopRangeBar.RangeMinimum * Program.audioControl.fileReader.WaveFormat.AverageBytesPerSecond;
                }
            }
            musicTrackBar.Value = Program.audioControl.fileReader.CurrentTime.Minutes * 60 + Program.audioControl.fileReader.CurrentTime.Seconds;
            durationOfPlayback.Text = Program.audioControl.fileReader.CurrentTime.Minutes.ToString("00") + ":" + Program.audioControl.fileReader.CurrentTime.Seconds.ToString("00");

        }


        private void hamburgerButton_Click(object sender, EventArgs e)
        {
            if (mainWindowSplitContainer.SplitterDistance == 50)
                mainWindowSplitContainer.SplitterDistance = 300;
            else
                mainWindowSplitContainer.SplitterDistance = 50;
        }

        //Обработка нажатия на кнопки меню навигации, формы уже инициализированы и добавлены, осталось их показать
        //Сначала скрывается существующая форма, затем показывается новая, потом инструкция для сокрытия этой формы передаются делегату
        private void navigationMusicPanel_Click(object sender, EventArgs e)
        {
            hideCurrentWindow();
            Program.musicListWindow.Show();
            hideCurrentWindow = Program.musicListWindow.Hide;
        }

        private void navigationEffectsPanel_Click(object sender, EventArgs e)
        {
            hideCurrentWindow();
            Program.effectsWindow.Show();
            hideCurrentWindow = Program.effectsWindow.Hide;
        }

        private void navigationEditorPanel_Click(object sender, EventArgs e)
        {
            hideCurrentWindow();
            Program.editorWindow.Show();
            hideCurrentWindow = Program.editorWindow.Hide;
        }

        private void navigationSettingsPanel_Click(object sender, EventArgs e)
        {
            hideCurrentWindow();
            Program.settingsWindow.Show();
            hideCurrentWindow = Program.settingsWindow.Hide;
        }

        private void navigationAboutPanel_Click(object sender, EventArgs e)
        {
            hideCurrentWindow();
            Program.aboutWindow.Show();
            hideCurrentWindow = Program.aboutWindow.Hide;
        }

        //При изменении размера окна, следует изменить размеры элементов управления
        //Литералы - математически вычисленны, с учётом размеров элементов
        private void MainWindow_Resize(object sender, EventArgs e)
        {
            musicTrackBar.Width = centerMusicPanel.Width - 72;
            musicControlsPanel.Location = new Point((centerMusicPanel.Width - 268) / 2, musicControlsPanel.Location.Y);
            maximumDuration.Location = new Point(centerMusicPanel.Width - 34, maximumDuration.Location.Y);
        }
    }
}
