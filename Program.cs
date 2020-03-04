using System;
using System.IO;
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

        public static Task showElements;

        //Путь к папке с музыкой
        public static string musicFolderPath = "";

        //Массив из путей файлов для воспроизведения
        //Массив не содержит искомую папку
        public static List<string> fileQueue = new List<string>();

        //Создание плейлиста с названием name
        public static async void createPlayList(string name)
        {
            await Task.Run(() =>
            {
                System.IO.File.Delete(musicFolderPath + "\\" + name + ".m3u");
                StreamWriter writerOfM3UFile = new StreamWriter(musicFolderPath + "\\" + name + ".m3u");
                writerOfM3UFile.WriteLine("#EXTM3U");
                for (int i = 0; i < fileQueue.Count; i++)
                {
                    TagLib.File tagFile = TagLib.File.Create(musicFolderPath + "\\" + fileQueue[i]);
                    System.TimeSpan duration = tagFile.Properties.Duration;
                    writerOfM3UFile.Write("#EXTINF: ");
                    writerOfM3UFile.Write((duration.Minutes * 60) + duration.Seconds);
                    writerOfM3UFile.Write(",");
                    writerOfM3UFile.Write(tagFile.Tag.FirstPerformer);
                    writerOfM3UFile.Write(" - ");
                    writerOfM3UFile.WriteLine(tagFile.Tag.Title);
                    writerOfM3UFile.WriteLine(musicFolderPath + "\\" + fileQueue[i]);
                }
                writerOfM3UFile.Close();
            });
            
        }

        //Чтение плейлиста с именем name
        //При этом пути файлов заносятся в fileQueue по очереди воспроизведения
        public static async void readPlayList(string name)
        {
            await Task.Run(() =>
            {
                StreamReader readerOfM3UFile = new StreamReader(name);
                string currentLine;
                fileQueue.Clear();
                while ((currentLine = readerOfM3UFile.ReadLine()) != null)
                {
                    if (currentLine[0] == '#')
                        continue;
                    else
                    {
                        currentLine = currentLine.Remove(0, musicFolderPath.Length + 1);
                        fileQueue.Add(currentLine);
                    }
                }
            });
        }

        //Редактирование плейлиста с именем name
        //Можно удалить и добавить элемент или изменить положение элемента
        //[Добавить режим работы для этого]
        public static void editPlayList(string name)
        {


        }
        
        //Сканирует папку на наличие музыкальных файлов
        //Путь к исходной папке обрезается, для экономии памяти
        //После чтения очередь сортируется сначала по вложенным папкам, затем по файлам
        public static async void scanFolder()
        {
            await Task.Run(() =>
            {
                fileQueue.AddRange(Directory.GetFileSystemEntries(musicFolderPath, "*.mp3", SearchOption.AllDirectories));
                fileQueue.AddRange(Directory.GetFileSystemEntries(musicFolderPath, "*.wav", SearchOption.AllDirectories));
                fileQueue.AddRange(Directory.GetFileSystemEntries(musicFolderPath, "*.wma", SearchOption.AllDirectories));
                fileQueue.AddRange(Directory.GetFileSystemEntries(musicFolderPath, "*.aac", SearchOption.AllDirectories));
                cutTheFolderPath();
                fileQueue.Sort();
            });
        }

        //Функция удаления исходной папки из пути файла
        private static void cutTheFolderPath()
        {
            for (int i = 0; i < fileQueue.Count; i++)
                fileQueue[i] = fileQueue[i].Remove(0, musicFolderPath.Length + 1);
        }
    }
}
