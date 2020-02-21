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
            this.getFileNameButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.maximumDuration = new System.Windows.Forms.Label();
            this.durationOfPlayback = new System.Windows.Forms.Label();
            this.cycleButton = new System.Windows.Forms.Button();
            this.musicTrackBar = new System.Windows.Forms.TrackBar();
            this.previousButton = new System.Windows.Forms.Button();
            this.nextButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.openFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.timerOfPlayback = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.splitNavigation)).BeginInit();
            this.splitNavigation.Panel2.SuspendLayout();
            this.splitNavigation.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.musicTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // splitNavigation
            // 
            this.splitNavigation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.splitNavigation.Location = new System.Drawing.Point(2, 0);
            this.splitNavigation.Name = "splitNavigation";
            // 
            // splitNavigation.Panel2
            // 
            this.splitNavigation.Panel2.Controls.Add(this.getFileNameButton);
            this.splitNavigation.Size = new System.Drawing.Size(883, 567);
            this.splitNavigation.SplitterDistance = 262;
            this.splitNavigation.TabIndex = 0;
            // 
            // getFileNameButton
            // 
            this.getFileNameButton.BackColor = System.Drawing.Color.Teal;
            this.getFileNameButton.FlatAppearance.BorderSize = 0;
            this.getFileNameButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.getFileNameButton.Location = new System.Drawing.Point(148, 502);
            this.getFileNameButton.Name = "getFileNameButton";
            this.getFileNameButton.Size = new System.Drawing.Size(75, 23);
            this.getFileNameButton.TabIndex = 0;
            this.getFileNameButton.Text = "Choose File";
            this.getFileNameButton.UseVisualStyleBackColor = false;
            this.getFileNameButton.Click += new System.EventHandler(this.getFileNameButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.maximumDuration);
            this.panel1.Controls.Add(this.durationOfPlayback);
            this.panel1.Controls.Add(this.cycleButton);
            this.panel1.Controls.Add(this.musicTrackBar);
            this.panel1.Controls.Add(this.previousButton);
            this.panel1.Controls.Add(this.nextButton);
            this.panel1.Controls.Add(this.playButton);
            this.panel1.Location = new System.Drawing.Point(2, 573);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(883, 87);
            this.panel1.TabIndex = 1;
            // 
            // maximumDuration
            // 
            this.maximumDuration.AutoSize = true;
            this.maximumDuration.Location = new System.Drawing.Point(637, 39);
            this.maximumDuration.Name = "maximumDuration";
            this.maximumDuration.Size = new System.Drawing.Size(34, 13);
            this.maximumDuration.TabIndex = 6;
            this.maximumDuration.Text = "00:00";
            // 
            // durationOfPlayback
            // 
            this.durationOfPlayback.AutoSize = true;
            this.durationOfPlayback.Location = new System.Drawing.Point(208, 39);
            this.durationOfPlayback.Name = "durationOfPlayback";
            this.durationOfPlayback.Size = new System.Drawing.Size(34, 13);
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
            this.cycleButton.Location = new System.Drawing.Point(495, 5);
            this.cycleButton.Name = "cycleButton";
            this.cycleButton.Size = new System.Drawing.Size(30, 30);
            this.cycleButton.TabIndex = 4;
            this.cycleButton.Text = "\r\n";
            this.cycleButton.UseVisualStyleBackColor = false;
            // 
            // musicTrackBar
            // 
            this.musicTrackBar.LargeChange = 1;
            this.musicTrackBar.Location = new System.Drawing.Point(249, 39);
            this.musicTrackBar.Maximum = 50;
            this.musicTrackBar.Name = "musicTrackBar";
            this.musicTrackBar.Size = new System.Drawing.Size(382, 45);
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
            this.previousButton.Location = new System.Drawing.Point(399, 3);
            this.previousButton.Name = "previousButton";
            this.previousButton.Size = new System.Drawing.Size(30, 30);
            this.previousButton.TabIndex = 2;
            this.previousButton.Text = "\r\n";
            this.previousButton.UseVisualStyleBackColor = false;
            // 
            // nextButton
            // 
            this.nextButton.BackColor = System.Drawing.Color.Transparent;
            this.nextButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.nextButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.nextButton.FlatAppearance.BorderSize = 0;
            this.nextButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nextButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nextButton.Location = new System.Drawing.Point(459, 3);
            this.nextButton.Name = "nextButton";
            this.nextButton.Size = new System.Drawing.Size(30, 30);
            this.nextButton.TabIndex = 1;
            this.nextButton.Text = "\r\n";
            this.nextButton.UseVisualStyleBackColor = false;
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.playButton.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveCaption;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(429, 3);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(30, 30);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // openFileDialog
            // 
            this.openFileDialog.Filter = "MP3 |*.mp3|WAV |*.wav";
            this.openFileDialog.InitialDirectory = "C:\\Users\\студент\\Music";
            this.openFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialog_FileOk);
            // 
            // timerOfPlayback
            // 
            this.timerOfPlayback.Interval = 1000;
            this.timerOfPlayback.Tick += new System.EventHandler(this.timerOfPlayback_Tick);
            // 
            // DraftAudioPlayerMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(884, 661);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.splitNavigation);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DraftAudioPlayerMainForm";
            this.Text = "Draft Audio Player";
            this.splitNavigation.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitNavigation)).EndInit();
            this.splitNavigation.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
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
    }
}

