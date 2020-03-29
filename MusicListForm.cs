using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Reflection;
using System.Windows.Forms;

namespace Draft_Audio_Player_New_Design
{
    public partial class MusicListForm : Form
    {
        public MusicListForm()
        {
            InitializeComponent();
        }

        Panel allMusicListFormPanel;
        Panel playlistMusicListFormPanel;
        Panel albumMusicListFormPanel;
        Panel albumPlaylistMusicListFormPanel;

        Panel[] musicPanels;

        CheckBox[] checkBoxes;
        Label[] name;
        public static Button[] play;
        Label[] duration;
        Label[] artist;
        Label[] album;
        Label[] genre;

        void initMusicPanels(Panel panelName, Panel[] musicPanelsName)
        {
            //initMusicPanels(allMusicListFormPanel, musicPanels);
            panelName = new Panel();
            panelName.AutoScroll = true;
            panelName.Size = new System.Drawing.Size(1197, 417);
            panelName.Dock = System.Windows.Forms.DockStyle.Fill;
            panelName.Location = new System.Drawing.Point(0, 53);
            panelName.Name = panelName.ToString();
            typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty).SetValue(panelName, true, null);
            if (musicPanelsName != null)
            {
                musicPanelsName = null;
                checkBoxes = null;
                name = null;
                play = null;
                duration = null;
                artist = null;
                album = null;
                genre = null;
            }

            musicPanelsName = new Panel[Program.fileQueue.Count];
            checkBoxes = new CheckBox[Program.fileQueue.Count];
            name = new Label[Program.fileQueue.Count];
            play = new Button[Program.fileQueue.Count];
            duration = new Label[Program.fileQueue.Count];
            artist = new Label[Program.fileQueue.Count];
            album = new Label[Program.fileQueue.Count];
            genre = new Label[Program.fileQueue.Count];
            int name_= 0, artist_= 0, album_= 0;
            
            for (int i = Program.fileQueue.Count - 1; i >= 0; i--)
            {
                var tagFile = TagLib.File.Create(Program.musicFolderPath + "\\" + Program.fileQueue[i]);
                if ((tagFile.Tag.Title.Length * 14) > name_)
                    name_ = tagFile.Tag.Title.Length * 14;
                if ((tagFile.Tag.FirstPerformer.Length * 14) > artist_)
                    artist_ = tagFile.Tag.FirstPerformer.Length * 14;
                if ((tagFile.Tag.Album.Length * 14) > album_ )
                    album_ = tagFile.Tag.Album.Length * 14;
            }

            if(artist_>420 || album_>420 || name_ > 420)
            {
                if (artist_ > 420)
                    artist_ = 420;
                if (album_ > 420)
                    album_ = 420;
                if (name_ > 420)
                    name_ = 420;
            }

            for (int i = Program.fileQueue.Count - 1; i >= 0; i--)
                {
                    var tagFile = TagLib.File.Create(Program.musicFolderPath + "\\" + Program.fileQueue[i]);
                    musicPanelsName[i] = new Panel();
                    checkBoxes[i] = new CheckBox();
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

                    musicPanelsName[i].Controls.Add(checkBoxes[i]);
                    musicPanelsName[i].Controls.Add(name[i]);
                    musicPanelsName[i].Controls.Add(play[i]);
                    musicPanelsName[i].Controls.Add(duration[i]);
                    musicPanelsName[i].Controls.Add(artist[i]);
                    musicPanelsName[i].Controls.Add(album[i]);
                    musicPanelsName[i].Controls.Add(genre[i]);

                    checkBoxes[i].CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
                    checkBoxes[i].Location = new System.Drawing.Point(0, 0);
                    checkBoxes[i].Name = checkBoxes[i].ToString();
                    checkBoxes[i].Size = new System.Drawing.Size(25, 25);
                    checkBoxes[i].Visible = true;

                    name[i].AutoEllipsis = true;
                    name[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    name[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    name[i].Location = new System.Drawing.Point(25, 0);
                    name[i].Name = name[i].ToString();
                    name[i].Size = new System.Drawing.Size(name_, 25);
                    name[i].Text =  tagFile.Tag.Title;
                    name[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                    play[i].BackColor = System.Drawing.Color.Transparent;
                    play[i].CausesValidation = false;
                    play[i].FlatAppearance.BorderSize = 0;
                    play[i].FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
                    play[i].FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
                    play[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    play[i].Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    play[i].ForeColor = System.Drawing.Color.Transparent;
                    play[i].Location = new System.Drawing.Point(25 + name_, 0);
                    play[i].Name = i.ToString();
                    play[i].Size = new System.Drawing.Size(25, 25);
                    play[i].Text = "";
                    play[i].Click += new System.EventHandler(playButton_Click);

                    duration[i].AutoEllipsis = true;
                    duration[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    duration[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    duration[i].Location = new System.Drawing.Point(50+ name_, 0);
                    duration[i].Name = duration[i].ToString();
                    duration[i].Size = new System.Drawing.Size(60, 25);
                    duration[i].Text = tagFile.Properties.Duration.Minutes.ToString("00") + ":" + tagFile.Properties.Duration.Seconds.ToString("00");
                    duration[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                    artist[i].AutoEllipsis = true;
                    artist[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    artist[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    artist[i].Location = new System.Drawing.Point(110+ name_, 0);
                    artist[i].Name = artist[i].ToString();
                    artist[i].Size = new System.Drawing.Size(artist_, 25);
                    artist[i].Text = tagFile.Tag.FirstPerformer;
                    artist[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                    album[i].AutoEllipsis = true;
                    album[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    album[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    album[i].Location = new System.Drawing.Point(110+ name_+ artist_, 0);
                    album[i].Name = album[i].ToString();
                    album[i].Size = new System.Drawing.Size(album_, 25);
                    album[i].Text = tagFile.Tag.Album;
                    album[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                    genre[i].AutoEllipsis = true;
                    genre[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                    genre[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                    genre[i].Location = new System.Drawing.Point(110 + name_ + artist_ + album_, 0);
                    genre[i].Name = genre[i].ToString();
                    genre[i].Size = new System.Drawing.Size(300, 25);
                    genre[i].Text = tagFile.Tag.FirstGenre;
                    genre[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                    panelName.Controls.Add(musicPanelsName[i]);
                }
            MusicListFormMainPanel.Controls.Add(panelName);

        }

        private void MusicListForm_VisibleChanged(object sender, EventArgs e)
        {
            if (allMusicListFormPanel == null)
                if (Program.fileQueue.Count != 0)
                    initMusicPanels(allMusicListFormPanel, musicPanels); 
        }

        public static int currentTrackIndex = 0;
        public static int previousButton = -1;
        private void playButton_Click(object sender, EventArgs e)
        {
            if (previousButton == Convert.ToInt32(((Button)sender).Name))
            {
                if (MainForm.musicIsPlaying == true)
                {
                    MainForm.outputDevice.Pause();
                    Program.mainForm.timerOfPlayback.Stop();
                    Program.mainForm.playButton.Text = "";
                    ((Button)sender).Text = "";
                    MainForm.musicIsPlaying = false;
                }
                else
                {
                    MainForm.outputDevice.Play();
                    Program.mainForm.timerOfPlayback.Start();
                    Program.mainForm.playButton.Text = "";
                    ((Button)sender).Text = "";
                    MainForm.musicIsPlaying = true;
                }
            }
            else
            {
                if (previousButton != -1)
                    play[previousButton].Text = "";
                previousButton = Convert.ToInt32(((Button)sender).Name);
                currentTrackIndex = previousButton;
                Program.mainForm.playButton.Text = "";
                ((Button)sender).Text = "";
                Program.mainForm.playMusic(Convert.ToInt32(((Button)sender).Name));
            }
        }
    }
}
