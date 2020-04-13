using System;
using System.Collections.Generic;
using System.Drawing;
using System.Reflection;
using System.Windows.Forms;

namespace Music_Speed_And_Pitch_Changer
{
    public partial class MusicListWindow : Form
    {
        public void applyTheme()
        {
            this.BackColor = Program.themeControl.firstColor;
            this.albumsButton.ForeColor = Program.themeControl.secondColor;
            this.playlistsButton.ForeColor = Program.themeControl.secondColor;
            this.allMusicButton.ForeColor = Program.themeControl.secondColor;
            this.nowPlayingButton.ForeColor = Program.themeControl.secondColor;
            this.button2.ForeColor = Program.themeControl.secondColor;
            this.button1.ForeColor = Program.themeControl.secondColor;
            this.nowPlayingButton.FlatAppearance.MouseDownBackColor = Program.themeControl.thirdColor;
            this.allMusicButton.FlatAppearance.MouseDownBackColor = Program.themeControl.thirdColor;
            this.playlistsButton.FlatAppearance.MouseDownBackColor = Program.themeControl.thirdColor;
            this.albumsButton.FlatAppearance.MouseDownBackColor = Program.themeControl.thirdColor;
            this.nowPlayingButton.FlatAppearance.MouseOverBackColor = Program.themeControl.accentColor;
            this.allMusicButton.FlatAppearance.MouseOverBackColor = Program.themeControl.accentColor;
            this.playlistsButton.FlatAppearance.MouseOverBackColor = Program.themeControl.accentColor;
            this.albumsButton.FlatAppearance.MouseOverBackColor = Program.themeControl.accentColor;
            for (int i = allMusicPaths.Count - 1; i >= 0; i--)
            {

                name[i].ForeColor = Program.themeControl.secondColor;
                play[i].ForeColor = Program.themeControl.secondColor;
                play[i].FlatAppearance.MouseDownBackColor = Program.themeControl.thirdColor;
                play[i].FlatAppearance.MouseOverBackColor = Program.themeControl.accentColor;
                duration[i].ForeColor = Program.themeControl.secondColor;
                artist[i].ForeColor = Program.themeControl.secondColor;
                album[i].ForeColor = Program.themeControl.secondColor;
                genre[i].ForeColor = Program.themeControl.secondColor;
            }
        }

        Panel nowPlayingPanel = new Panel();
        Panel allMusicPanel = new Panel();
        Panel playListsPanel = new Panel();
        Panel albumsPanel = new Panel();

        Panel toBeHiddenPanel;

        public MusicListWindow()
        {
            InitializeComponent();
            musicListWindowMainPanel.Controls.Add(allMusicPanel);
            toBeHiddenPanel = allMusicPanel;
            applyTheme();
        }

        CheckBox[] checkBox;
        Label[] name;
        public Button[] play;
        Label[] duration;
        Label[] artist;
        Label[] album;
        Label[] genre;

        public string folderPath;
        public List<string> allMusicPaths = new List<string>();

        public bool musicIsPlaying = false;
        public int previousButtonIndex = -1;

        /// <summary>
        /// 1. playlist - список всех файлов для проигрывания
        /// 2. panelName - панель, куда добавлется куча других панелей
        /// 3. musicPanelsName - куча панелей, с элементами управления (checkbox, name, button, album, artist...)
        /// 
        /// 1. Задаются свойства главной панели.
        /// 2. Если панели существовали, они уничтожаются.
        /// 3. Создаётся массив musicPanelsName и массивы других в него входящих объектов.
        /// 4. В цикле каждый элемент инициализируется, добавляется на подпанель, им задаются специальные свойства.
        /// 5. Для каждой панели из тега вытаскиваеются название, продолжительность, исполнитель, альбом и жанр.
        /// 6. После задания всех свойств объектам управления, подпанель добавляется на общую панель.
        /// 7. После завершения цикла panelName добавляется на форму MusicListWindow, и происходит отрисовка всех элементов.
        /// 
        /// </summary>
        public void initMusicPanels(List<string> playlist, Panel panelName, Panel[] musicPanelsName)
        {
            if (panelName == null && musicPanelsName == null)
            {
                panelName = allMusicPanel;
                allMusicPaths.AddRange(playlist);
            }

            panelName.AutoScroll = true;
            panelName.Size = new System.Drawing.Size(1197, 417);
            panelName.Dock = System.Windows.Forms.DockStyle.Fill;
            panelName.Location = new System.Drawing.Point(0, 53);
            panelName.Name = panelName.ToString();
            typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty).SetValue(panelName, true, null);
            if (musicPanelsName != null)
            {
                musicPanelsName = null;
                checkBox = null;
                name = null;
                play = null;
                duration = null;
                artist = null;
                album = null;
                genre = null;
            }

            musicPanelsName = new Panel[playlist.Count];
            checkBox = new CheckBox[playlist.Count];
            name = new Label[playlist.Count];
            play = new Button[playlist.Count];
            duration = new Label[playlist.Count];
            artist = new Label[playlist.Count];
            album = new Label[playlist.Count];
            genre = new Label[playlist.Count];

            for (int i = playlist.Count - 1; i >= 0; i--)
            {
                var tagFile = TagLib.File.Create(folderPath + "\\" + playlist[i]);
                musicPanelsName[i] = new Panel();
                checkBox[i] = new CheckBox();
                name[i] = new Label();
                play[i] = new Button();
                duration[i] = new Label();
                artist[i] = new Label();
                album[i] = new Label();
                genre[i] = new Label();

                musicPanelsName[i].Dock = System.Windows.Forms.DockStyle.Top;
                musicPanelsName[i].Location = new System.Drawing.Point(0, 0);
                musicPanelsName[i].Name = musicPanelsName[i].ToString();
                musicPanelsName[i].Size = new System.Drawing.Size(1197, 25);
                musicPanelsName[i].BackColor = Color.Transparent;

                musicPanelsName[i].Controls.Add(checkBox[i]);
                musicPanelsName[i].Controls.Add(name[i]);
                musicPanelsName[i].Controls.Add(play[i]);
                musicPanelsName[i].Controls.Add(duration[i]);
                musicPanelsName[i].Controls.Add(artist[i]);
                musicPanelsName[i].Controls.Add(album[i]);
                musicPanelsName[i].Controls.Add(genre[i]);

                checkBox[i].CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
                checkBox[i].Location = new System.Drawing.Point(0, 0);
                checkBox[i].Name = checkBox[i].ToString();
                checkBox[i].Size = new System.Drawing.Size(25, 25);

                name[i].AutoEllipsis = true;
                name[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                name[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                name[i].Location = new System.Drawing.Point(25, 0);
                name[i].Name = name[i].ToString();
                name[i].Size = new System.Drawing.Size(275, 25);
                name[i].Text = tagFile.Tag.Title;
                if (name[i].Text == "")
                {
                    name[i].Text = playlist[i].Substring(playlist[i].LastIndexOf('\\') + 1, playlist[i].LastIndexOf('.') - 1 - playlist[i].LastIndexOf('\\'));
                }
                name[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                play[i].BackColor = System.Drawing.Color.Transparent;
                play[i].CausesValidation = false;
                play[i].FlatAppearance.BorderSize = 0;
                play[i].FlatAppearance.MouseDownBackColor = Program.themeControl.thirdColor;
                play[i].FlatAppearance.MouseOverBackColor = Program.themeControl.accentColor;
                play[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                play[i].Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                play[i].ForeColor = Program.themeControl.secondColor;
                play[i].Location = new System.Drawing.Point(300, 0);
                play[i].Name = i.ToString();
                play[i].Size = new System.Drawing.Size(25, 25);
                play[i].Text = "";
                play[i].Click += new System.EventHandler(playButton_Click);

                duration[i].AutoEllipsis = true;
                duration[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                duration[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                duration[i].Location = new System.Drawing.Point(325, 0);
                duration[i].Name = duration[i].ToString();
                duration[i].Size = new System.Drawing.Size(60, 25);
                duration[i].Text = tagFile.Properties.Duration.Minutes.ToString("00") + ":" + tagFile.Properties.Duration.Seconds.ToString("00");
                duration[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                artist[i].AutoEllipsis = true;
                artist[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                artist[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                artist[i].Location = new System.Drawing.Point(385, 0);
                artist[i].Name = artist[i].ToString();
                artist[i].Size = new System.Drawing.Size(200, 25);
                artist[i].Text = tagFile.Tag.FirstPerformer;
                artist[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                album[i].AutoEllipsis = true;
                album[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                album[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                album[i].Location = new System.Drawing.Point(585, 0);
                album[i].Name = album[i].ToString();
                album[i].Size = new System.Drawing.Size(200, 25);
                album[i].Text = tagFile.Tag.Album;
                album[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                genre[i].AutoEllipsis = true;
                genre[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                genre[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                genre[i].Location = new System.Drawing.Point(785, 0);
                genre[i].Name = genre[i].ToString();
                genre[i].Size = new System.Drawing.Size(200, 25);
                genre[i].Text = tagFile.Tag.FirstGenre;
                genre[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                panelName.Controls.Add(musicPanelsName[i]);
            }

            musicListWindowMainPanel.Controls.Remove(toBeHiddenPanel);
            musicListWindowMainPanel.Controls.Add(panelName);//Чтобы не блокировался поток.
            toBeHiddenPanel = panelName;
        }

        /// <summary>
        /// 1. 3 варианта действий: знак кнопки "Play" и музыка не играет, знак кнопки "Play" и музыка играет, знак кнопки "Pause"
        /// 2. Если знак кнопки "Play" и музыка не играет: запустить проигрывание, поменять знак главной кнопки.
        /// 3. Если знак кнопки "Play" и музыка играет: поменять знак предыдущей кнопки, поменять знак кнопки, запустить проигрывание.
        /// 4. Если знак кнопки "Pause": поменять знак кнопки, поменять знак главной кнопки, приостановить проигрывание.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void playButton_Click(object sender, EventArgs e)
        {
            if (((Button)sender).Text == "" && musicIsPlaying == false)//Знак Play
            {
                if (previousButtonIndex != Convert.ToInt32(((Button)sender).Name))
                {
                    Program.audioControl.initMusicFile(Convert.ToInt32(((Button)sender).Name));
                    Program.audioControl.play();
                }
                else
                    Program.audioControl.play();
                ((Button)sender).Text = "";
                Program.mainWindow.playButton.Text = "";
                musicIsPlaying = true;
                previousButtonIndex = Convert.ToInt32(((Button)sender).Name);
            }
            else if (((Button)sender).Text == "" && musicIsPlaying == true)//Знак Play
            {
                play[previousButtonIndex].Text = "";
                ((Button)sender).Text = "";
                Program.audioControl.initMusicFile(Convert.ToInt32(((Button)sender).Name));
                Program.audioControl.play();
                previousButtonIndex = Convert.ToInt32(((Button)sender).Name);
            }
            else if (((Button)sender).Text == "")//Знак Pause
            {
                ((Button)sender).Text = "";
                Program.mainWindow.playButton.Text = "";
                Program.audioControl.pause();
                musicIsPlaying = false;
            }
        }

        private void nowPlayingButton_Click(object sender, EventArgs e)
        {
            musicListWindowMainPanel.Controls.Remove(toBeHiddenPanel);
            musicListWindowMainPanel.Controls.Add(nowPlayingPanel);
            toBeHiddenPanel = nowPlayingPanel;
        }

        private void allMusicButton_Click(object sender, EventArgs e)
        {
            musicListWindowMainPanel.Controls.Remove(toBeHiddenPanel);
            musicListWindowMainPanel.Controls.Add(allMusicPanel);
            toBeHiddenPanel = allMusicPanel;
        }

        private void playlistsButton_Click(object sender, EventArgs e)
        {
            musicListWindowMainPanel.Controls.Remove(toBeHiddenPanel);
            musicListWindowMainPanel.Controls.Add(playListsPanel);
            toBeHiddenPanel = playListsPanel;
        }

        private void albumsButton_Click(object sender, EventArgs e)
        {
            musicListWindowMainPanel.Controls.Remove(toBeHiddenPanel);
            musicListWindowMainPanel.Controls.Add(albumsPanel);
            toBeHiddenPanel = albumsPanel;
        }
    }
}
