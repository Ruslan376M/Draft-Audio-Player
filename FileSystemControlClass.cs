using System.Collections.Generic;
using System.IO;
using System.Threading.Tasks;

namespace Music_Speed_And_Pitch_Changer
{
    public class FileSystemControlClass
    {
        public string musicFolderPath;
        public List<string> allMusicPaths = new List<string>();

        /// <summary>
        /// 1. Подготовить массив путей
        /// 2. Загружаем в массив пути
        /// 3. Из путей удаляем путь к корневой папке. При этом удаляется конечный слэш.
        /// 4. Применить сортировку
        /// </summary>
        /// <param name="path"></param>
        public async void scanFolder(string path)
        {
            musicFolderPath = path;
            Program.musicListWindow.folderPath = path;
            await Task.Run(() =>
            {
                allMusicPaths.AddRange(Directory.GetFileSystemEntries(musicFolderPath, "*.mp3", SearchOption.AllDirectories));
                allMusicPaths.AddRange(Directory.GetFileSystemEntries(musicFolderPath, "*.wav", SearchOption.AllDirectories));
                allMusicPaths.AddRange(Directory.GetFileSystemEntries(musicFolderPath, "*.wma", SearchOption.AllDirectories));
                allMusicPaths.AddRange(Directory.GetFileSystemEntries(musicFolderPath, "*.aac", SearchOption.AllDirectories));

                for (int i = 0; i < allMusicPaths.Count; i++)
                    allMusicPaths[i] = allMusicPaths[i].Remove(0, musicFolderPath.Length + 1);

                sortAllMusicList("name");


            });
            Program.musicListWindow.initMusicPanels(allMusicPaths, null, null);
            Program.audioControl = new AudioControlClass(allMusicPaths, path);
        }

        /// <summary>
        /// 1. Сортировка по тегам
        /// 2. param = name, album, artist  
        /// </summary>
        /// <param name="param"></param>
        public void sortAllMusicList(string param)
        {

        }
    }
}
