using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace This_is_fine
{
    public partial class MainWindow : Form
    {
        //Для открытия одной формы, нужно скрыть другую
        //Делегат, после показа новой формы, сохраняет в себе инструкцию для последующего её скрытия
        delegate void hideCurrentFormDelegate();
        hideCurrentFormDelegate hideCurrentForm;

        private void applyTheme()
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
        }
        public MainWindow()
        {
            InitializeComponent();
            applyTheme();
            //Привязка форм к правой панели (mainFormSplitContainer.Panel2)
            mainWindowSplitContainer.Panel2.Controls.Add(Program.musicListWindow);
            mainWindowSplitContainer.Panel2.Controls.Add(Program.effectsWindow);
            mainWindowSplitContainer.Panel2.Controls.Add(Program.editorWindow);
            mainWindowSplitContainer.Panel2.Controls.Add(Program.settingsWindow);
            mainWindowSplitContainer.Panel2.Controls.Add(Program.aboutWindow);
            //При запуске программы сразу показать окно со списком музыки
            //Program.musicListForm.Show();
            //Первая инструкция для делегата на скрытие первой открытой формы
            hideCurrentForm = Program.musicListWindow.Hide;
        }

        private void randomizeButton_Click(object sender, EventArgs e)
        {

        }

        private void backwardButton_Click(object sender, EventArgs e)
        {

        }

        private void playButton_Click(object sender, EventArgs e)
        {

        }

        private void forwardButton_Click(object sender, EventArgs e)
        {

        }

        private void repeatButton_Click(object sender, EventArgs e)
        {

        }

        private void musicTrackBar_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void musicTrackBar_Scroll(object sender, EventArgs e)
        {

        }

        private void volumeTrackBar_Scroll(object sender, EventArgs e)
        {

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
            hideCurrentForm();
            Program.musicListWindow.Show();
            hideCurrentForm = Program.musicListWindow.Hide;
        }

        private void navigationEffectsPanel_Click(object sender, EventArgs e)
        {
            hideCurrentForm();
            Program.effectsWindow.Show();
            hideCurrentForm = Program.effectsWindow.Hide;
        }

        private void navigationEditorPanel_Click(object sender, EventArgs e)
        {
            hideCurrentForm();
            Program.editorWindow.Show();
            hideCurrentForm = Program.editorWindow.Hide;
        }

        private void navigationSettingsPanel_Click(object sender, EventArgs e)
        {
            hideCurrentForm();
            Program.settingsWindow.Show();
            hideCurrentForm = Program.settingsWindow.Hide;
        }

        private void navigationAboutPanel_Click(object sender, EventArgs e)
        {
            hideCurrentForm();
            Program.aboutWindow.Show();
            hideCurrentForm = Program.aboutWindow.Hide;
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
