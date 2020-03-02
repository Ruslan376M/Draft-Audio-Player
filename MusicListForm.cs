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
    public partial class MusicListForm : Form
    {
        public MusicListForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Program.scanFolder();
            Program.createPlayList("AllFiles");
        }
    }
}
