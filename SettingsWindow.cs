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
    public partial class SettingsWindow : Form
    {
        public SettingsWindow()
        {
            InitializeComponent();
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
    }
}
