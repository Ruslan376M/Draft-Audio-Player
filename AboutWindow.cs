using System.Windows.Forms;

namespace Music_Speed_And_Pitch_Changer
{
    public partial class AboutWindow : Form
    {
        public void applyTheme()
        {
            this.BackColor = Program.themeControl.firstColor;
        }
        public AboutWindow()
        {
            InitializeComponent();
            applyTheme();
        }


    }
}
