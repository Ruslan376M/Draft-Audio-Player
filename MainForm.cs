using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Draft_Audio_Player_New_Design
{
    public partial class MainForm : Form
    {
        //Инициализация форм побочных форм
        MusicListForm musicListForm = new MusicListForm() { Dock = DockStyle.Fill, TopLevel = false};
        EffectsForm effectsForm = new EffectsForm() { Dock = DockStyle.Fill, TopLevel = false};
        EditorForm editorForm = new EditorForm() { Dock = DockStyle.Fill, TopLevel = false};
        SettingsForm settingsForm = new SettingsForm() { Dock = DockStyle.Fill, TopLevel = false};
        AboutForm aboutForm = new AboutForm() { Dock = DockStyle.Fill, TopLevel = false};

        //Для открытия одной формы, нужно скрыть другую
        //Делегат, после показа новой формы, сохраняет в себе инструкцию для последующего её скрытия
        delegate void hideCurrentFormDelegate();
        hideCurrentFormDelegate hideCurrentForm;

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
    }
}
