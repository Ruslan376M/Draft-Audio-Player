﻿using System;
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
            DoubleBuffered = true;
            InitializeComponent();
            
        }

        Panel allMusicListFormPanel;
        Panel playlistMusicListFormPanel;
        Panel albumMusicListFormPanel;
        Panel albumPlaylistMusicListFormPanel;

        Panel[] musicPanels;

        CheckBox[] checkBoxes;
        Label[] name;
        Button[] play;
        Label[] duration;
        Label[] artist;
        Label[] album;
        Label[] genre;

        static BackgroundWorker bw = new BackgroundWorker();

        private void MusicListForm_VisibleChanged(object sender, EventArgs e)
        {
            if (allMusicListFormPanel == null)
                if (Program.fileQueue.Count != 0)
                {
                    //initMusicPanels(allMusicListFormPanel, musicPanels);
                    bw.DoWork += bw_doWork;
                    bw.RunWorkerAsync();
                    bw.RunWorkerCompleted += Bw_RunWorkerCompleted;
                    
                }
        }

        private void Bw_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

            MusicListFormMainPanel.Controls.Add(allMusicListFormPanel);
            MusicListFormMainPanel.Invalidate();
        }

        private void bw_doWork(object sender, DoWorkEventArgs e)
        {
            //initMusicPanels(allMusicListFormPanel, musicPanels);
            allMusicListFormPanel = new Panel();
            allMusicListFormPanel.AutoScroll = true;
            allMusicListFormPanel.Size = new System.Drawing.Size(1197, 417);
            allMusicListFormPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            allMusicListFormPanel.Location = new System.Drawing.Point(0, 53);
            allMusicListFormPanel.Name = allMusicListFormPanel.ToString();
            typeof(Control).GetProperty("DoubleBuffered", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.SetProperty).SetValue(allMusicListFormPanel, true, null);
            if (musicPanels != null)
            {
                musicPanels = null;
                checkBoxes = null;
                name = null;
                play = null;
                duration = null;
                artist = null;
                album = null;
                genre = null;
            }
            musicPanels = new Panel[Program.fileQueue.Count];
            checkBoxes = new CheckBox[Program.fileQueue.Count];
            name = new Label[Program.fileQueue.Count];
            play = new Button[Program.fileQueue.Count];
            duration = new Label[Program.fileQueue.Count];
            artist = new Label[Program.fileQueue.Count];
            album = new Label[Program.fileQueue.Count];
            genre = new Label[Program.fileQueue.Count];
            for (int i = Program.fileQueue.Count - 1; i >= 0; i--) 
            {
                var tagFile = TagLib.File.Create(Program.musicFolderPath + "\\" + Program.fileQueue[i]);
                musicPanels[i] = new Panel();
                checkBoxes[i] = new CheckBox();
                name[i] = new Label();
                play[i] = new Button();
                duration[i] = new Label();
                artist[i] = new Label();
                album[i] = new Label();
                genre[i] = new Label();

                musicPanels[i].Dock = System.Windows.Forms.DockStyle.Top;
                musicPanels[i].Location = new System.Drawing.Point(0, 0);
                musicPanels[i].Name = musicPanels[i].ToString();
                musicPanels[i].Size = new System.Drawing.Size(1197, 25);
                musicPanels[i].BackColor = Color.Transparent;

                musicPanels[i].Controls.Add(checkBoxes[i]);
                musicPanels[i].Controls.Add(name[i]);
                musicPanels[i].Controls.Add(play[i]);
                musicPanels[i].Controls.Add(duration[i]);
                musicPanels[i].Controls.Add(artist[i]);
                musicPanels[i].Controls.Add(album[i]);
                musicPanels[i].Controls.Add(genre[i]);

                checkBoxes[i].CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
                //checkBoxes[i].Dock = System.Windows.Forms.DockStyle.Left;
                checkBoxes[i].Location = new System.Drawing.Point(0, 0);
                checkBoxes[i].Name = checkBoxes[i].ToString();
                checkBoxes[i].Size = new System.Drawing.Size(25, 25);

                name[i].AutoEllipsis = true;
                //name[i].Dock = System.Windows.Forms.DockStyle.Left;
                name[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                name[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                name[i].Location = new System.Drawing.Point(25, 0);
                name[i].Name = name[i].ToString();
                name[i].Size = new System.Drawing.Size(275, 25);
                name[i].Text = tagFile.Tag.Title;
                name[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                play[i].BackColor = System.Drawing.Color.Transparent;
                play[i].CausesValidation = false;
                play[i].FlatAppearance.BorderSize = 0;
                play[i].FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
                play[i].FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
                play[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                play[i].Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                play[i].ForeColor = System.Drawing.Color.Transparent;
                play[i].Location = new System.Drawing.Point(300, 0);
                play[i].Name = i.ToString();
                play[i].Size = new System.Drawing.Size(25, 25);
                play[i].TabIndex = 0;
                play[i].TabStop = false;
                play[i].Text = "";
                play[i].UseVisualStyleBackColor = false;
                play[i].Click += playButton_Click;

                duration[i].AutoEllipsis = true;
                //duration[i].Dock = System.Windows.Forms.DockStyle.Left;
                duration[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                duration[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                duration[i].Location = new System.Drawing.Point(325, 0);
                duration[i].Name = duration[i].ToString();
                duration[i].Size = new System.Drawing.Size(60, 25);
                duration[i].Text = tagFile.Properties.Duration.Minutes.ToString("00") + ":" + tagFile.Properties.Duration.Seconds.ToString("00");
                duration[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                artist[i].AutoEllipsis = true;
                //artist[i].Dock = System.Windows.Forms.DockStyle.Left;
                artist[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                artist[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                artist[i].Location = new System.Drawing.Point(385, 0);
                artist[i].Name = artist[i].ToString();
                artist[i].Size = new System.Drawing.Size(200, 25);
                artist[i].Text = tagFile.Tag.FirstPerformer;
                artist[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                album[i].AutoEllipsis = true;
                //album[i].Dock = System.Windows.Forms.DockStyle.Left;
                album[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                album[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                album[i].Location = new System.Drawing.Point(585, 0);
                album[i].Name = album[i].ToString();
                album[i].Size = new System.Drawing.Size(200, 25);
                album[i].Text = tagFile.Tag.Album;
                album[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                genre[i].AutoEllipsis = true;
                //genre[i].Dock = System.Windows.Forms.DockStyle.Left;
                genre[i].FlatStyle = System.Windows.Forms.FlatStyle.Flat;
                genre[i].Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
                genre[i].Location = new System.Drawing.Point(785, 0);
                genre[i].Name = genre[i].ToString();
                genre[i].Size = new System.Drawing.Size(200, 25);
                genre[i].Text = tagFile.Tag.FirstGenre;
                genre[i].TextAlign = System.Drawing.ContentAlignment.MiddleLeft;

                allMusicListFormPanel.Controls.Add(musicPanels[i]);
            }
            
            
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            string s = ((Button)sender).Name;
        }
    }
}
