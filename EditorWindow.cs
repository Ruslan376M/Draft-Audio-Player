using System.Windows.Forms;

namespace Music_Speed_And_Pitch_Changer
{
    public partial class EditorWindow : Form
    {
        public void applyTheme()
        {
            this.BackColor = Program.themeControl.firstColor;
        }
        public EditorWindow()
        {
            InitializeComponent();
            applyTheme();
        }
    }
}
