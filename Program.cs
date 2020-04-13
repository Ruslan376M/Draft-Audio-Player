using System;
using System.Windows.Forms;

namespace Music_Speed_And_Pitch_Changer
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

            themeControl = new ThemeControlClass();


            musicListWindow = new MusicListWindow() { Dock = DockStyle.Fill, TopLevel = false };
            effectsWindow = new EffectsWindow() { Dock = DockStyle.Fill, TopLevel = false };
            editorWindow = new EditorWindow() { Dock = DockStyle.Fill, TopLevel = false };
            settingsWindow = new SettingsWindow() { Dock = DockStyle.Fill, TopLevel = false };
            aboutWindow = new AboutWindow() { Dock = DockStyle.Fill, TopLevel = false };
            mainWindow = new MainWindow();


            themeControl.SetWhiteTheme();

            Application.Run(mainWindow);
        }
    }
}
