using System;
using System.Windows.Forms;

namespace Music_Speed_And_Pitch_Changer
{
    public partial class SettingsWindow : Form
    {
        public void applyTheme()
        {
            this.BackColor = Program.themeControl.firstColor;
            this.choosePathButton.ForeColor = Program.themeControl.secondColor;
            this.folderLabel.ForeColor = Program.themeControl.secondColor;
            this.infoLabel.ForeColor = Program.themeControl.secondColor;
            this.themeLabel.ForeColor = Program.themeControl.secondColor;
            this.accentLabel.ForeColor = Program.themeControl.secondColor;
            this.choosePathButton.FlatAppearance.MouseDownBackColor = Program.themeControl.thirdColor;
            this.choosePathButton.FlatAppearance.MouseOverBackColor = Program.themeControl.accentColor;
            this.currentThemeComboBox.BackColor = Program.themeControl.firstColor;
            this.colorsComboBox.BackColor = Program.themeControl.firstColor;
            this.currentThemeComboBox.ForeColor = Program.themeControl.secondColor;
            this.colorsComboBox.ForeColor = Program.themeControl.secondColor;
        }
        public SettingsWindow()
        {
            InitializeComponent();
            currentThemeComboBox.SelectedIndex = 0;
            colorsComboBox.SelectedIndex = 0;
            applyTheme();
        }
        /// <summary>
        /// 1. Открыть окно выбора папки
        /// 2. Получить выбранную папку
        /// 3. Проверить выбор папки
        /// 4. Записать путь к папке в лейбл
        /// 5. Сканировать папку на наличие файлов
        /// </summary>
        private void choosePathButton_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog musicFolderBrowserDialog = new FolderBrowserDialog();
            musicFolderBrowserDialog.ShowDialog();
            if (musicFolderBrowserDialog.SelectedPath != "")
            {
                folderLabel.Text = musicFolderBrowserDialog.SelectedPath;
                Program.fileSystemControl.scanFolder(musicFolderBrowserDialog.SelectedPath);
            }
        }

        private void currentThemeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Program.themeControl != null)
            {
                if (currentThemeComboBox.SelectedIndex == 0)
                    Program.themeControl.SetWhiteTheme();
                else if (currentThemeComboBox.SelectedIndex == 1)
                    Program.themeControl.SetBlackTheme();
            }
        }

        private void colorsComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (Program.themeControl != null)
            {
                string color = (string)colorsComboBox.Items[colorsComboBox.SelectedIndex];
                if (color == "Красный")
                    Program.themeControl.accentColor = System.Drawing.Color.Red;
                else if (color == "Оранжевый")
                    Program.themeControl.accentColor = System.Drawing.Color.Orange;
                else if (color == "Жёлтый")
                    Program.themeControl.accentColor = System.Drawing.Color.Yellow;
                else if (color == "Зелёный")
                    Program.themeControl.accentColor = System.Drawing.Color.Green;
                else if (color == "Голубой")
                    Program.themeControl.accentColor = System.Drawing.Color.SteelBlue;
                else if (color == "Синий")
                    Program.themeControl.accentColor = System.Drawing.Color.Blue;
                else if (color == "Фиолетовый")
                    Program.themeControl.accentColor = System.Drawing.Color.Purple;
                else if (color == "Розовый")
                    Program.themeControl.accentColor = System.Drawing.Color.Pink;
                Program.themeControl.applyAll();
            }
        }
    }
}
