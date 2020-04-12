using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace This_is_fine
{
    static class Program
    {
        //Глобальное объявление всех форм
        public static MainWindow mainWindow;
        public static MusicListWindow musicListWindow;
        public static EffectsWindow effectsWindow;
        public static EditorWindow editorWindow;
        public static SettingsWindow settingsWindow;
        public static AboutWindow aboutWindow;

        //Глобальное объявление классов
        public static ThemeControlClass themeControl;
        public static AudioControlClass audioControl;
        public static FileSystemControlClass fileSystemControl;

        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            fileSystemControl = new FileSystemControlClass();

            //themeControl = new ThemeControlClass();
            //themeControl.SetWhiteTheme();
            //audioControl = new AudioControlClass();

            musicListWindow = new MusicListWindow() { Dock = DockStyle.Fill, TopLevel = false };
            effectsWindow = new EffectsWindow() { Dock = DockStyle.Fill, TopLevel = false };
            editorWindow = new EditorWindow() { Dock = DockStyle.Fill, TopLevel = false };
            settingsWindow = new SettingsWindow() { Dock = DockStyle.Fill, TopLevel = false };
            aboutWindow = new AboutWindow() { Dock = DockStyle.Fill, TopLevel = false };
            mainWindow = new MainWindow();

            Application.Run(mainWindow);
        }
    }
}
