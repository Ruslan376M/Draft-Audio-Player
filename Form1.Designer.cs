namespace Draft_Audio_Player
{
    partial class DraftAudioPlayerMainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DraftAudioPlayerMainForm));
            this.splitNavigation = new System.Windows.Forms.SplitContainer();
            this.pictCover = new System.Windows.Forms.PictureBox();
            this.getFileNameButton = new System.Windows.Forms.Button();
            this.directoryChooseButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbTitle = new System.Windows.Forms.Label();
            this.volumePercentLabel = new System.Windows.Forms.Label();
            this.volumeTrackBar = new System.Windows.Forms.TrackBar();
            this.maximumDuration = new System.Windows.Forms.Label();
            this.durationOfPlayback = new System.Windows.Forms.Label();
            this.cycleButton = new System.Windows.Forms.Button();
            this.musicTrackBar = new System.Windows.Forms.TrackBar();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timerOfPlayback = new System.Windows.Forms.Timer(this.components);
            this.folderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            ((System.ComponentModel.ISupportInitialize)(this.splitNavigation)).BeginInit();
            this.splitNavigation.Panel1.SuspendLayout();
            this.splitNavigation.Panel2.SuspendLayout();
            this.splitNavigation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictCover)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // splitNavigation
            // 
            this.splitNavigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitNavigation.Location = new System.Drawing.Point(3, 0);
            this.splitNavigation.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.splitNavigation.Name = "splitNavigation";
            // 
            // splitNavigation.Panel1
            // 
            this.splitNavigation.Panel1.Controls.Add(this.pictCover);
            this.splitNavigation.Panel1.Controls.Add(this.getFileNameButton);
            this.splitNavigation.Panel1.Controls.Add(this.directoryChooseButton);
            // 
            // splitNavigation.Panel2
            // 
            this.splitNavigation.Panel2.Controls.Add(this.panel2);
            this.splitNavigation.Size = new System.Drawing.Size(1324, 872);
            this.splitNavigation.SplitterDistance = 392;
            this.splitNavigation.SplitterWidth = 6;
            this.splitNavigation.TabIndex = 0;
            // 
            // pictCover
            // 
            this.pictCover.ErrorImage = null;
            this.pictCover.Location = new System.Drawing.Point(130, 362);
            this.pictCover.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictCover.Name = "pictCover";
            this.pictCover.Size = new System.Drawing.Size(150, 154);
            this.pictCover.TabIndex = 10;
            this.pictCover.TabStop = false;
            // 
            // getFileNameButton
            // 
            this.getFileNameButton.BackColor = System.Drawing.Color.Teal;
            this.getFileNameButton.FlatAppearance.BorderSize = 0;
            this.getFileNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getFileNameButton.Location = new System.Drawing.Point(168, 705);
            this.getFileNameButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.getFileNameButton.Name = "getFileNameButton";
            this.getFileNameButton.Size = new System.Drawing.Size(112, 35);
            this.getFileNameButton.TabIndex = 0;
            this.getFileNameButton.Text = "Choose File";
            this.getFileNameButton.UseVisualStyleBackColor = false;
            this.getFileNameButton.Click += new System.EventHandler(this.getFileNameButton_Click);
            // 
            // directoryChooseButton
            // 
            this.directoryChooseButton.BackColor = System.Drawing.Color.Teal;
            this.directoryChooseButton.FlatAppearance.BorderSize = 0;
            this.directoryChooseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.directoryChooseButton.Location = new System.Drawing.Point(110, 580);
            this.directoryChooseButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.directoryChooseButton.Name = "directoryChooseButton";
            this.directoryChooseButton.Size = new System.Drawing.Size(196, 35);
            this.directoryChooseButton.TabIndex = 1;
            this.directoryChooseButton.Text = "Choose Directory";
            this.directoryChooseButton.UseVisualStyleBackColor = false;
            this.directoryChooseButton.Click += new System.EventHandler(this.directoryChooseButton_Click);
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Location = new System.Drawing.Point(26, 46);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(880, 797);
            this.panel2.TabIndex = 0;
            this.panel2.Scroll += new System.Windows.Forms.ScrollEventHandler(this.panel2_Scroll);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.lbTitle);
            this.panel1.Controls.Add(this.volumePercentLabel);
            this.panel1.Controls.Add(this.volumeTrackBar);
            this.panel1.Controls.Add(this.maximumDuration);
            this.panel1.Controls.Add(this.durationOfPlayback);
            this.panel1.Controls.Add(this.cycleButton);
            this.panel1.Controls.Add(this.musicTrackBar);
            this.panel1.Controls.Add(this.previousButton);
            this.panel1.Controls.Add(this.nextButton);
            this.panel1.Controls.Add(this.playButton);
            this.panel1.Location = new System.Drawing.Point(3, 882);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1324, 134);
            this.panel1.TabIndex = 1;
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Location = new System.Drawing.Point(30, 8);
            this.lbTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(0, 20);
            this.lbTitle.TabIndex = 9;
            this.lbTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lbTitle.UseWaitCursor = true;
            // 
            // volumePercentLabel
            // 
            this.volumePercentLabel.AutoSize = true;
            this.volumePercentLabel.Location = new System.Drawing.Point(1054, 60);
            this.volumePercentLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.volumePercentLabel.Name = "volumePercentLabel";
            this.volumePercentLabel.Size = new System.Drawing.Size(50, 20);
            this.volumePercentLabel.TabIndex = 8;
            this.volumePercentLabel.Text = "100%";
            // 
            // volumeTrackBar
            // 
            this.volumeTrackBar.BackColor = System.Drawing.Color.White;
            this.volumeTrackBar.Location = new System.Drawing.Point(1114, 48);
            this.volumeTrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.volumeTrackBar.Maximum = 100;
            this.volumeTrackBar.Name = "volumeTrackBar";
            this.volumeTrackBar.Size = new System.Drawing.Size(190, 69);
            this.volumeTrackBar.TabIndex = 7;
            this.volumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeTrackBar.Value = 100;
            this.volumeTrackBar.Scroll += new System.EventHandler(this.volumeTrackBar_Scroll);
            // 
            // maximumDuration
            // 
            this.maximumDuration.AutoSize = true;
            this.maximumDuration.Location = new System.Drawing.Point(956, 60);
            this.maximumDuration.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.maximumDuration.Name = "maximumDuration";
            this.maximumDuration.Size = new System.Drawing.Size(49, 20);
            this.maximumDuration.TabIndex = 6;
            this.maximumDuration.Text = "00:00";
            // 
            // durationOfPlayback
            // 
            this.durationOfPlayback.AutoSize = true;
            this.durationOfPlayback.Location = new System.Drawing.Point(312, 60);
            this.durationOfPlayback.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.durationOfPlayback.Name = "durationOfPlayback";
            this.durationOfPlayback.Size = new System.Drawing.Size(49, 20);
            this.durationOfPlayback.TabIndex = 5;
            this.durationOfPlayback.Text = "00:00";
            // 
            // cycleButton
            // 
            this.cycleButton.BackColor = System.Drawing.Color.Transparent;
            this.cycleButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.cycleButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.cycleButton.FlatAppearance.BorderSize = 0;
            this.cycleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cycleButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cycleButton.Location = new System.Drawing.Point(742, 8);
            this.cycleButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cycleButton.Name = "cycleButton";
            this.cycleButton.Size = new System.Drawing.Size(45, 46);
            this.cycleButton.TabIndex = 4;
            this.cycleButton.Text = "\r\n";
            this.cycleButton.UseVisualStyleBackColor = false;
            this.cycleButton.Click += new System.EventHandler(this.cycleButton_Click);
            // 
            // musicTrackBar
            // 
            this.musicTrackBar.LargeChange = 1;
            this.musicTrackBar.Location = new System.Drawing.Point(374, 60);
            this.musicTrackBar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.musicTrackBar.Maximum = 50;
            this.musicTrackBar.Name = "musicTrackBar";
            this.musicTrackBar.Size = new System.Drawing.Size(573, 69);
            this.musicTrackBar.TabIndex = 3;
            this.musicTrackBar.Scroll += new System.EventHandler(this.musicTrackBar_Scroll);
            this.musicTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.musicTrackBar_MouseUp);
            // 
            // previousButton
            // 
            this.previousButton.BackColor = System.Drawing.Color.Transparent;
            this.previousButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.previousButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.previousButton.FlatAppearance.BorderSize = 0;
            this.previousButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.previousButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.previousButton.Location = new System.Drawing.Point(598, 5);
            this.previousButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(45, 46);
            this.previousButton.TabIndex = 2;
            this.previousButton.Text = "\r\n";
            this.previousButton.UseVisualStyleBackColor = false;
            this.previousButton.Click += new System.EventHandler(this.backwardButton_Click);
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.Transparent;
            this.nextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nextButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(688, 5);
            this.nextButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(45, 46);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "\r\n";
            this.nextButton.UseVisualStyleBackColor = false;
            this.nextButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(644, 5);
            this.playButton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(45, 46);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "MP3 |*.mp3|WAV |*.wav";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // timerOfPlayback
            // 
            this.timerOfPlayback.Interval = 1000;
            this.timerOfPlayback.Tick += new System.EventHandler(this.timerOfPlayback_Tick);
            // 
            // folderBrowserDialog
            // 
            this.folderBrowserDialog.Description = "Выберите папку с музыкой";
            // 
            // DraftAudioPlayerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1326, 1017);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitNavigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "DraftAudioPlayerMainForm";
            this.Text = "Draft Audio Player";
            this.splitNavigation.Panel1.ResumeLayout(false);
            this.splitNavigation.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitNavigation)).EndInit();
            this.splitNavigation.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictCover)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.volumeTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.musicTrackBar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitNavigation;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TrackBar musicTrackBar;
        private System.Windows.Forms.Button previousButton;
        private System.Windows.Forms.Button nextButton;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button cycleButton;
        private System.Windows.Forms.Button getFileNameButton;
        private System.Windows.Forms.OpenFileDialog openFileDialog;
        private System.Windows.Forms.Timer timerOfPlayback;
        private System.Windows.Forms.Label durationOfPlayback;
        private System.Windows.Forms.Label maximumDuration;
        private System.Windows.Forms.Button directoryChooseButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label volumePercentLabel;
        private System.Windows.Forms.TrackBar volumeTrackBar;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.PictureBox pictCover;
    }
}

