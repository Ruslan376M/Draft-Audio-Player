using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using TagLib;

namespace Draft_Audio_Player_New_Design
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }

        //Путь к папке с музыкой
        public static string musicFolderPath = "";
        //Массив из путей файлов для воспроизведения
        public static List<string> fileQueue = new List<string>();

        public static void createPlayList(string name)
        {

        }

        public static void readPlayList(string name)
        {

        }

        public static void editPlayList(string name)
        {

        }
    }
}
