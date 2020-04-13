using System.Windows.Forms;

namespace Music_Speed_And_Pitch_Changer
{
    public partial class AboutWindow : Form
    {
        public void applyTheme()
        {
            this.BackColor = Program.themeControl.firstColor;
            developersLabel.ForeColor = Program.themeControl.secondColor;
            listOfDevelopersLabel.ForeColor = Program.themeControl.secondColor;
        }
        public AboutWindow()
        {
            InitializeComponent();
            applyTheme();
        }


    }
}
