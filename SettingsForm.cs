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
    public partial class SettingsForm : Form
    {
        public SettingsForm()
        {
            InitializeComponent();
            
        }

        private void choosePathButton_Click(object sender, EventArgs e)
        {
            musicFolderBrowserDialog.ShowDialog();
            Program.musicFolderPath = musicFolderBrowserDialog.SelectedPath;
            folderLabel.Text = musicFolderBrowserDialog.SelectedPath;
        }
    }
}
