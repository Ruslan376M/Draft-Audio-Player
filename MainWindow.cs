﻿using System;
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


namespace This_is_fine
{
    public partial class MainWindow : Form
    {
        //Для открытия одной формы, нужно скрыть другую
        //Делегат, после показа новой формы, сохраняет в себе инструкцию для последующего её скрытия

        delegate void hideCurrentWindowDelegate();
        hideCurrentWindowDelegate hideCurrentWindow;

        public AudioControlClass audioControl;
        /*private void applyTheme()
        {
            this.BackColor = Program.themeControl.firstColor;
            this.ForeColor = Program.themeControl.secondColor;
            musicPanel.BackColor = Program.themeControl.thirdColor;
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
            volumeTrackBar.TrackLineSelectedColor = Program.themeControl.accentColor;
            mainWindowSplitContainer.Panel1.BackColor = Program.themeControl.thirdColor;
            hamburgerButton.ForeColor = Program.themeControl.secondColor;
            hamburgerButton.FlatAppearance.MouseDownBackColor = Program.themeControl.thirdColor;
            hamburgerButton.FlatAppearance.MouseOverBackColor = Program.themeControl.accentColor;
            navigationMusicPanel.ForeColor = Program.themeControl.secondColor;
        }*/
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
        }

        private void randomizeButton_Click(object sender, EventArgs e)
        {
            
        }

        private void backwardButton_Click(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (Program.musicListWindow.previousButtonIndex != -1)
            Program.musicListWindow.playButton_Click(Program.musicListWindow.play[Program.musicListWindow.previousButtonIndex], null);
        }

        private void forwardButton_Click(object sender, EventArgs e)
        {

        }

        private void repeatButton_Click(object sender, EventArgs e)
        {

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
            durationLabel.Location = new Point((musicTrackBar.Location.X + 15) + (91 * musicTrackBar.Width * musicTrackBar.Value / musicTrackBar.Maximum / 100) - (durationLabel.Width / 2), 48);
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
