namespace Music_Speed_And_Pitch_Changer
{
    partial class MainWindow
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
            this.musicPanel = new System.Windows.Forms.Panel();
            this.centerMusicPanel = new System.Windows.Forms.Panel();
            this.durationLabel = new System.Windows.Forms.Label();
            this.maximumDuration = new System.Windows.Forms.Label();
            this.durationOfPlayback = new System.Windows.Forms.Label();
            this.musicTrackBar = new XComponent.SliderBar.MACTrackBar();
            this.musicControlsPanel = new System.Windows.Forms.Panel();
            this.randomizeButton = new System.Windows.Forms.Button();
            this.backwardButton = new System.Windows.Forms.Button();
            this.playButton = new System.Windows.Forms.Button();
            this.forwardButton = new System.Windows.Forms.Button();
            this.repeatButton = new System.Windows.Forms.Button();
            this.rightMusicPanel = new System.Windows.Forms.Panel();
            this.volumeLabel = new System.Windows.Forms.Label();
            this.volumeTrackBar = new XComponent.SliderBar.MACTrackBar();
            this.nameOfCurrentTrackLabel = new System.Windows.Forms.Label();
            this.coverPictureBox = new System.Windows.Forms.PictureBox();
            this.mainWindowSplitContainer = new System.Windows.Forms.SplitContainer();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.hamburgerButton = new System.Windows.Forms.Button();
            this.navigationSettingsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.navigationSettingsIconLabel = new System.Windows.Forms.Label();
            this.navigationSettingsTextLabel = new System.Windows.Forms.Label();
            this.navigationAboutPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.navigationAboutIconLabel = new System.Windows.Forms.Label();
            this.navigationAboutTextLabel = new System.Windows.Forms.Label();
            this.navigationEffectsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.navigationEffectsIconLabel = new System.Windows.Forms.Label();
            this.navigationEffectsTextLabel = new System.Windows.Forms.Label();
            this.navigationMusicPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.navigationMusicIconLabel = new System.Windows.Forms.Label();
            this.navigationMusicTextLabel = new System.Windows.Forms.Label();
            this.navigationEditorPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.navigationEditorIconLabel = new System.Windows.Forms.Label();
            this.navigationEditorTextLabel = new System.Windows.Forms.Label();
            this.timerOfPlayback = new System.Windows.Forms.Timer(this.components);
            this.musicPanel.SuspendLayout();
            this.centerMusicPanel.SuspendLayout();
            this.musicControlsPanel.SuspendLayout();
            this.rightMusicPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowSplitContainer)).BeginInit();
            this.mainWindowSplitContainer.Panel1.SuspendLayout();
            this.mainWindowSplitContainer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.navigationSettingsPanel.SuspendLayout();
            this.navigationAboutPanel.SuspendLayout();
            this.navigationEffectsPanel.SuspendLayout();
            this.navigationMusicPanel.SuspendLayout();
            this.navigationEditorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // musicPanel
            // 
            this.musicPanel.BackColor = System.Drawing.Color.Gainsboro;
            this.musicPanel.Controls.Add(this.centerMusicPanel);
            this.musicPanel.Controls.Add(this.rightMusicPanel);
            this.musicPanel.Controls.Add(this.nameOfCurrentTrackLabel);
            this.musicPanel.Controls.Add(this.coverPictureBox);
            this.musicPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.musicPanel.Location = new System.Drawing.Point(0, 494);
            this.musicPanel.Name = "musicPanel";
            this.musicPanel.Size = new System.Drawing.Size(800, 90);
            this.musicPanel.TabIndex = 0;
            // 
            // centerMusicPanel
            // 
            this.centerMusicPanel.BackColor = System.Drawing.Color.Transparent;
            this.centerMusicPanel.Controls.Add(this.durationLabel);
            this.centerMusicPanel.Controls.Add(this.maximumDuration);
            this.centerMusicPanel.Controls.Add(this.durationOfPlayback);
            this.centerMusicPanel.Controls.Add(this.musicTrackBar);
            this.centerMusicPanel.Controls.Add(this.musicControlsPanel);
            this.centerMusicPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.centerMusicPanel.Location = new System.Drawing.Point(230, 0);
            this.centerMusicPanel.Name = "centerMusicPanel";
            this.centerMusicPanel.Size = new System.Drawing.Size(340, 90);
            this.centerMusicPanel.TabIndex = 3;
            // 
            // durationLabel
            // 
            this.durationLabel.AutoSize = true;
            this.durationLabel.Location = new System.Drawing.Point(30, 59);
            this.durationLabel.Name = "durationLabel";
            this.durationLabel.Size = new System.Drawing.Size(34, 13);
            this.durationLabel.TabIndex = 18;
            this.durationLabel.Text = "00:00";
            this.durationLabel.Visible = false;
            // 
            // maximumDuration
            // 
            this.maximumDuration.AutoSize = true;
            this.maximumDuration.Location = new System.Drawing.Point(306, 68);
            this.maximumDuration.Name = "maximumDuration";
            this.maximumDuration.Size = new System.Drawing.Size(34, 13);
            this.maximumDuration.TabIndex = 17;
            this.maximumDuration.Text = "00:00";
            // 
            // durationOfPlayback
            // 
            this.durationOfPlayback.AutoSize = true;
            this.durationOfPlayback.Location = new System.Drawing.Point(3, 68);
            this.durationOfPlayback.Name = "durationOfPlayback";
            this.durationOfPlayback.Size = new System.Drawing.Size(34, 13);
            this.durationOfPlayback.TabIndex = 16;
            this.durationOfPlayback.Text = "00:00";
            // 
            // musicTrackBar
            // 
            this.musicTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.musicTrackBar.BorderColor = System.Drawing.Color.Transparent;
            this.musicTrackBar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicTrackBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.musicTrackBar.IndentHeight = 6;
            this.musicTrackBar.Location = new System.Drawing.Point(36, 59);
            this.musicTrackBar.Maximum = 100;
            this.musicTrackBar.Minimum = 0;
            this.musicTrackBar.MinimumSize = new System.Drawing.Size(100, 27);
            this.musicTrackBar.Name = "musicTrackBar";
            this.musicTrackBar.Size = new System.Drawing.Size(268, 27);
            this.musicTrackBar.TabIndex = 15;
            this.musicTrackBar.TabStop = false;
            this.musicTrackBar.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.musicTrackBar.TickColor = System.Drawing.Color.Transparent;
            this.musicTrackBar.TickHeight = 1;
            this.musicTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.musicTrackBar.TrackerColor = System.Drawing.Color.SteelBlue;
            this.musicTrackBar.TrackerSize = new System.Drawing.Size(15, 15);
            this.musicTrackBar.TrackLineColor = System.Drawing.Color.Transparent;
            this.musicTrackBar.TrackLineHeight = 3;
            this.musicTrackBar.TrackLineSelectedColor = System.Drawing.Color.SteelBlue;
            this.musicTrackBar.Value = 100;
            this.musicTrackBar.Scroll += new System.EventHandler(this.musicTrackBar_Scroll);
            this.musicTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.musicTrackBar_MouseUp);
            // 
            // musicControlsPanel
            // 
            this.musicControlsPanel.AutoSize = true;
            this.musicControlsPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.musicControlsPanel.BackColor = System.Drawing.Color.Transparent;
            this.musicControlsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.musicControlsPanel.Controls.Add(this.randomizeButton);
            this.musicControlsPanel.Controls.Add(this.backwardButton);
            this.musicControlsPanel.Controls.Add(this.playButton);
            this.musicControlsPanel.Controls.Add(this.forwardButton);
            this.musicControlsPanel.Controls.Add(this.repeatButton);
            this.musicControlsPanel.ForeColor = System.Drawing.Color.White;
            this.musicControlsPanel.Location = new System.Drawing.Point(45, 0);
            this.musicControlsPanel.Name = "musicControlsPanel";
            this.musicControlsPanel.Size = new System.Drawing.Size(250, 50);
            this.musicControlsPanel.TabIndex = 9;
            // 
            // randomizeButton
            // 
            this.randomizeButton.BackColor = System.Drawing.Color.Transparent;
            this.randomizeButton.CausesValidation = false;
            this.randomizeButton.FlatAppearance.BorderSize = 0;
            this.randomizeButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.randomizeButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.randomizeButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.randomizeButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.randomizeButton.ForeColor = System.Drawing.Color.Black;
            this.randomizeButton.Location = new System.Drawing.Point(0, 0);
            this.randomizeButton.Margin = new System.Windows.Forms.Padding(0);
            this.randomizeButton.Name = "randomizeButton";
            this.randomizeButton.Size = new System.Drawing.Size(50, 50);
            this.randomizeButton.TabIndex = 17;
            this.randomizeButton.TabStop = false;
            this.randomizeButton.Text = "";
            this.randomizeButton.UseVisualStyleBackColor = false;
            this.randomizeButton.Click += new System.EventHandler(this.randomizeButton_Click);
            // 
            // backwardButton
            // 
            this.backwardButton.BackColor = System.Drawing.Color.Transparent;
            this.backwardButton.CausesValidation = false;
            this.backwardButton.FlatAppearance.BorderSize = 0;
            this.backwardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.backwardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.backwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backwardButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backwardButton.ForeColor = System.Drawing.Color.Black;
            this.backwardButton.Location = new System.Drawing.Point(50, 0);
            this.backwardButton.Margin = new System.Windows.Forms.Padding(0);
            this.backwardButton.Name = "backwardButton";
            this.backwardButton.Size = new System.Drawing.Size(50, 50);
            this.backwardButton.TabIndex = 15;
            this.backwardButton.TabStop = false;
            this.backwardButton.Text = "";
            this.backwardButton.UseVisualStyleBackColor = false;
            this.backwardButton.Click += new System.EventHandler(this.backwardButton_Click);
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.CausesValidation = false;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.Black;
            this.playButton.Location = new System.Drawing.Point(100, 0);
            this.playButton.Margin = new System.Windows.Forms.Padding(0);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(50, 50);
            this.playButton.TabIndex = 18;
            this.playButton.Text = "";
            this.playButton.UseVisualStyleBackColor = false;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // forwardButton
            // 
            this.forwardButton.BackColor = System.Drawing.Color.Transparent;
            this.forwardButton.CausesValidation = false;
            this.forwardButton.FlatAppearance.BorderSize = 0;
            this.forwardButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.forwardButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.forwardButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.forwardButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forwardButton.ForeColor = System.Drawing.Color.Black;
            this.forwardButton.Location = new System.Drawing.Point(150, 0);
            this.forwardButton.Margin = new System.Windows.Forms.Padding(0);
            this.forwardButton.Name = "forwardButton";
            this.forwardButton.Size = new System.Drawing.Size(50, 50);
            this.forwardButton.TabIndex = 14;
            this.forwardButton.TabStop = false;
            this.forwardButton.Text = "";
            this.forwardButton.UseVisualStyleBackColor = false;
            this.forwardButton.Click += new System.EventHandler(this.forwardButton_Click);
            // 
            // repeatButton
            // 
            this.repeatButton.BackColor = System.Drawing.Color.Transparent;
            this.repeatButton.CausesValidation = false;
            this.repeatButton.FlatAppearance.BorderSize = 0;
            this.repeatButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.repeatButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.repeatButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.repeatButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatButton.ForeColor = System.Drawing.Color.Black;
            this.repeatButton.Location = new System.Drawing.Point(200, 0);
            this.repeatButton.Margin = new System.Windows.Forms.Padding(0);
            this.repeatButton.Name = "repeatButton";
            this.repeatButton.Size = new System.Drawing.Size(50, 50);
            this.repeatButton.TabIndex = 16;
            this.repeatButton.TabStop = false;
            this.repeatButton.Text = "";
            this.repeatButton.UseVisualStyleBackColor = false;
            this.repeatButton.Click += new System.EventHandler(this.repeatButton_Click);
            // 
            // rightMusicPanel
            // 
            this.rightMusicPanel.BackColor = System.Drawing.Color.Transparent;
            this.rightMusicPanel.Controls.Add(this.volumeLabel);
            this.rightMusicPanel.Controls.Add(this.volumeTrackBar);
            this.rightMusicPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightMusicPanel.Location = new System.Drawing.Point(570, 0);
            this.rightMusicPanel.Name = "rightMusicPanel";
            this.rightMusicPanel.Size = new System.Drawing.Size(230, 90);
            this.rightMusicPanel.TabIndex = 2;
            // 
            // volumeLabel
            // 
            this.volumeLabel.AutoSize = true;
            this.volumeLabel.Location = new System.Drawing.Point(195, 6);
            this.volumeLabel.Name = "volumeLabel";
            this.volumeLabel.Size = new System.Drawing.Size(27, 13);
            this.volumeLabel.TabIndex = 19;
            this.volumeLabel.Text = "99%";
            this.volumeLabel.Visible = false;
            // 
            // volumeTrackBar
            // 
            this.volumeTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.volumeTrackBar.BorderColor = System.Drawing.Color.Transparent;
            this.volumeTrackBar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.volumeTrackBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.volumeTrackBar.IndentHeight = 6;
            this.volumeTrackBar.Location = new System.Drawing.Point(70, 14);
            this.volumeTrackBar.Maximum = 100;
            this.volumeTrackBar.Minimum = 0;
            this.volumeTrackBar.MinimumSize = new System.Drawing.Size(100, 27);
            this.volumeTrackBar.Name = "volumeTrackBar";
            this.volumeTrackBar.Size = new System.Drawing.Size(150, 27);
            this.volumeTrackBar.TabIndex = 14;
            this.volumeTrackBar.TabStop = false;
            this.volumeTrackBar.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeTrackBar.TickColor = System.Drawing.Color.Transparent;
            this.volumeTrackBar.TickHeight = 1;
            this.volumeTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.volumeTrackBar.TrackerColor = System.Drawing.Color.Transparent;
            this.volumeTrackBar.TrackerSize = new System.Drawing.Size(15, 15);
            this.volumeTrackBar.TrackLineColor = System.Drawing.Color.Transparent;
            this.volumeTrackBar.TrackLineHeight = 3;
            this.volumeTrackBar.TrackLineSelectedColor = System.Drawing.Color.SteelBlue;
            this.volumeTrackBar.Value = 100;
            this.volumeTrackBar.Scroll += new System.EventHandler(this.volumeTrackBar_Scroll);
            this.volumeTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.volumeTrackBar_MouseUp);
            // 
            // nameOfCurrentTrackLabel
            // 
            this.nameOfCurrentTrackLabel.AutoEllipsis = true;
            this.nameOfCurrentTrackLabel.BackColor = System.Drawing.Color.Transparent;
            this.nameOfCurrentTrackLabel.Dock = System.Windows.Forms.DockStyle.Left;
            this.nameOfCurrentTrackLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nameOfCurrentTrackLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameOfCurrentTrackLabel.Location = new System.Drawing.Point(90, 0);
            this.nameOfCurrentTrackLabel.Margin = new System.Windows.Forms.Padding(3);
            this.nameOfCurrentTrackLabel.Name = "nameOfCurrentTrackLabel";
            this.nameOfCurrentTrackLabel.Size = new System.Drawing.Size(140, 90);
            this.nameOfCurrentTrackLabel.TabIndex = 1;
            // 
            // coverPictureBox
            // 
            this.coverPictureBox.BackColor = System.Drawing.Color.Transparent;
            this.coverPictureBox.Dock = System.Windows.Forms.DockStyle.Left;
            this.coverPictureBox.ErrorImage = ((System.Drawing.Image)(resources.GetObject("coverPictureBox.ErrorImage")));
            this.coverPictureBox.Location = new System.Drawing.Point(0, 0);
            this.coverPictureBox.Name = "coverPictureBox";
            this.coverPictureBox.Size = new System.Drawing.Size(90, 90);
            this.coverPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.coverPictureBox.TabIndex = 0;
            this.coverPictureBox.TabStop = false;
            // 
            // mainWindowSplitContainer
            // 
            this.mainWindowSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainWindowSplitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.mainWindowSplitContainer.IsSplitterFixed = true;
            this.mainWindowSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.mainWindowSplitContainer.Name = "mainWindowSplitContainer";
            // 
            // mainWindowSplitContainer.Panel1
            // 
            this.mainWindowSplitContainer.Panel1.BackColor = System.Drawing.Color.Gainsboro;
            this.mainWindowSplitContainer.Panel1.Controls.Add(this.flowLayoutPanel1);
            this.mainWindowSplitContainer.Panel1.Controls.Add(this.navigationSettingsPanel);
            this.mainWindowSplitContainer.Panel1.Controls.Add(this.navigationAboutPanel);
            this.mainWindowSplitContainer.Panel1.Controls.Add(this.navigationEffectsPanel);
            this.mainWindowSplitContainer.Panel1.Controls.Add(this.navigationMusicPanel);
            this.mainWindowSplitContainer.Panel1.Controls.Add(this.navigationEditorPanel);
            this.mainWindowSplitContainer.Panel1.ForeColor = System.Drawing.Color.Transparent;
            this.mainWindowSplitContainer.Panel1MinSize = 2;
            this.mainWindowSplitContainer.Panel2MinSize = 2;
            this.mainWindowSplitContainer.Size = new System.Drawing.Size(800, 494);
            this.mainWindowSplitContainer.SplitterWidth = 1;
            this.mainWindowSplitContainer.TabIndex = 1;
            this.mainWindowSplitContainer.TabStop = false;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.flowLayoutPanel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.flowLayoutPanel1.Controls.Add(this.hamburgerButton);
            this.flowLayoutPanel1.ForeColor = System.Drawing.Color.White;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(294, 55);
            this.flowLayoutPanel1.TabIndex = 4;
            // 
            // hamburgerButton
            // 
            this.hamburgerButton.BackColor = System.Drawing.Color.Transparent;
            this.hamburgerButton.CausesValidation = false;
            this.hamburgerButton.FlatAppearance.BorderSize = 0;
            this.hamburgerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.hamburgerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.hamburgerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.hamburgerButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hamburgerButton.ForeColor = System.Drawing.Color.Black;
            this.hamburgerButton.Location = new System.Drawing.Point(0, 0);
            this.hamburgerButton.Margin = new System.Windows.Forms.Padding(0);
            this.hamburgerButton.Name = "hamburgerButton";
            this.hamburgerButton.Size = new System.Drawing.Size(50, 50);
            this.hamburgerButton.TabIndex = 0;
            this.hamburgerButton.TabStop = false;
            this.hamburgerButton.Text = "";
            this.hamburgerButton.UseVisualStyleBackColor = false;
            this.hamburgerButton.Click += new System.EventHandler(this.hamburgerButton_Click);
            // 
            // navigationSettingsPanel
            // 
            this.navigationSettingsPanel.BackColor = System.Drawing.Color.Transparent;
            this.navigationSettingsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navigationSettingsPanel.Controls.Add(this.navigationSettingsIconLabel);
            this.navigationSettingsPanel.Controls.Add(this.navigationSettingsTextLabel);
            this.navigationSettingsPanel.Location = new System.Drawing.Point(0, 239);
            this.navigationSettingsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.navigationSettingsPanel.Name = "navigationSettingsPanel";
            this.navigationSettingsPanel.Size = new System.Drawing.Size(294, 55);
            this.navigationSettingsPanel.TabIndex = 7;
            this.navigationSettingsPanel.Click += new System.EventHandler(this.navigationSettingsPanel_Click);
            // 
            // navigationSettingsIconLabel
            // 
            this.navigationSettingsIconLabel.BackColor = System.Drawing.Color.Transparent;
            this.navigationSettingsIconLabel.CausesValidation = false;
            this.navigationSettingsIconLabel.Enabled = false;
            this.navigationSettingsIconLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navigationSettingsIconLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationSettingsIconLabel.ForeColor = System.Drawing.Color.Black;
            this.navigationSettingsIconLabel.Location = new System.Drawing.Point(0, 0);
            this.navigationSettingsIconLabel.Margin = new System.Windows.Forms.Padding(0);
            this.navigationSettingsIconLabel.Name = "navigationSettingsIconLabel";
            this.navigationSettingsIconLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.navigationSettingsIconLabel.Size = new System.Drawing.Size(50, 50);
            this.navigationSettingsIconLabel.TabIndex = 4;
            this.navigationSettingsIconLabel.Text = "";
            this.navigationSettingsIconLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // navigationSettingsTextLabel
            // 
            this.navigationSettingsTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.navigationSettingsTextLabel.CausesValidation = false;
            this.navigationSettingsTextLabel.Enabled = false;
            this.navigationSettingsTextLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navigationSettingsTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationSettingsTextLabel.ForeColor = System.Drawing.Color.Black;
            this.navigationSettingsTextLabel.Location = new System.Drawing.Point(53, 0);
            this.navigationSettingsTextLabel.Name = "navigationSettingsTextLabel";
            this.navigationSettingsTextLabel.Size = new System.Drawing.Size(222, 50);
            this.navigationSettingsTextLabel.TabIndex = 1;
            this.navigationSettingsTextLabel.Text = "Настройки";
            this.navigationSettingsTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // navigationAboutPanel
            // 
            this.navigationAboutPanel.BackColor = System.Drawing.Color.Transparent;
            this.navigationAboutPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navigationAboutPanel.Controls.Add(this.navigationAboutIconLabel);
            this.navigationAboutPanel.Controls.Add(this.navigationAboutTextLabel);
            this.navigationAboutPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.navigationAboutPanel.ForeColor = System.Drawing.Color.White;
            this.navigationAboutPanel.Location = new System.Drawing.Point(0, 439);
            this.navigationAboutPanel.Name = "navigationAboutPanel";
            this.navigationAboutPanel.Size = new System.Drawing.Size(50, 55);
            this.navigationAboutPanel.TabIndex = 5;
            this.navigationAboutPanel.Click += new System.EventHandler(this.navigationAboutPanel_Click);
            // 
            // navigationAboutIconLabel
            // 
            this.navigationAboutIconLabel.BackColor = System.Drawing.Color.Transparent;
            this.navigationAboutIconLabel.CausesValidation = false;
            this.navigationAboutIconLabel.Enabled = false;
            this.navigationAboutIconLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navigationAboutIconLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationAboutIconLabel.ForeColor = System.Drawing.Color.Black;
            this.navigationAboutIconLabel.Location = new System.Drawing.Point(0, 0);
            this.navigationAboutIconLabel.Margin = new System.Windows.Forms.Padding(0);
            this.navigationAboutIconLabel.Name = "navigationAboutIconLabel";
            this.navigationAboutIconLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.navigationAboutIconLabel.Size = new System.Drawing.Size(50, 50);
            this.navigationAboutIconLabel.TabIndex = 4;
            this.navigationAboutIconLabel.Text = "";
            this.navigationAboutIconLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // navigationAboutTextLabel
            // 
            this.navigationAboutTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.navigationAboutTextLabel.CausesValidation = false;
            this.navigationAboutTextLabel.Enabled = false;
            this.navigationAboutTextLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navigationAboutTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationAboutTextLabel.ForeColor = System.Drawing.Color.Black;
            this.navigationAboutTextLabel.Location = new System.Drawing.Point(3, 50);
            this.navigationAboutTextLabel.Name = "navigationAboutTextLabel";
            this.navigationAboutTextLabel.Size = new System.Drawing.Size(222, 50);
            this.navigationAboutTextLabel.TabIndex = 1;
            this.navigationAboutTextLabel.Text = "О программе";
            this.navigationAboutTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // navigationEffectsPanel
            // 
            this.navigationEffectsPanel.BackColor = System.Drawing.Color.Transparent;
            this.navigationEffectsPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navigationEffectsPanel.Controls.Add(this.navigationEffectsIconLabel);
            this.navigationEffectsPanel.Controls.Add(this.navigationEffectsTextLabel);
            this.navigationEffectsPanel.ForeColor = System.Drawing.Color.Black;
            this.navigationEffectsPanel.Location = new System.Drawing.Point(0, 117);
            this.navigationEffectsPanel.Margin = new System.Windows.Forms.Padding(0);
            this.navigationEffectsPanel.Name = "navigationEffectsPanel";
            this.navigationEffectsPanel.Size = new System.Drawing.Size(294, 55);
            this.navigationEffectsPanel.TabIndex = 5;
            this.navigationEffectsPanel.Click += new System.EventHandler(this.navigationEffectsPanel_Click);
            // 
            // navigationEffectsIconLabel
            // 
            this.navigationEffectsIconLabel.BackColor = System.Drawing.Color.Transparent;
            this.navigationEffectsIconLabel.CausesValidation = false;
            this.navigationEffectsIconLabel.Enabled = false;
            this.navigationEffectsIconLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navigationEffectsIconLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationEffectsIconLabel.ForeColor = System.Drawing.Color.Black;
            this.navigationEffectsIconLabel.Location = new System.Drawing.Point(0, 0);
            this.navigationEffectsIconLabel.Margin = new System.Windows.Forms.Padding(0);
            this.navigationEffectsIconLabel.Name = "navigationEffectsIconLabel";
            this.navigationEffectsIconLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.navigationEffectsIconLabel.Size = new System.Drawing.Size(50, 50);
            this.navigationEffectsIconLabel.TabIndex = 4;
            this.navigationEffectsIconLabel.Text = "";
            this.navigationEffectsIconLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // navigationEffectsTextLabel
            // 
            this.navigationEffectsTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.navigationEffectsTextLabel.CausesValidation = false;
            this.navigationEffectsTextLabel.Enabled = false;
            this.navigationEffectsTextLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navigationEffectsTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationEffectsTextLabel.Location = new System.Drawing.Point(53, 0);
            this.navigationEffectsTextLabel.Name = "navigationEffectsTextLabel";
            this.navigationEffectsTextLabel.Size = new System.Drawing.Size(222, 50);
            this.navigationEffectsTextLabel.TabIndex = 1;
            this.navigationEffectsTextLabel.Text = "Эффекты";
            this.navigationEffectsTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // navigationMusicPanel
            // 
            this.navigationMusicPanel.BackColor = System.Drawing.Color.Transparent;
            this.navigationMusicPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navigationMusicPanel.Controls.Add(this.navigationMusicIconLabel);
            this.navigationMusicPanel.Controls.Add(this.navigationMusicTextLabel);
            this.navigationMusicPanel.ForeColor = System.Drawing.Color.Black;
            this.navigationMusicPanel.Location = new System.Drawing.Point(0, 55);
            this.navigationMusicPanel.Margin = new System.Windows.Forms.Padding(0);
            this.navigationMusicPanel.Name = "navigationMusicPanel";
            this.navigationMusicPanel.Size = new System.Drawing.Size(294, 55);
            this.navigationMusicPanel.TabIndex = 3;
            this.navigationMusicPanel.Click += new System.EventHandler(this.navigationMusicPanel_Click);
            // 
            // navigationMusicIconLabel
            // 
            this.navigationMusicIconLabel.BackColor = System.Drawing.Color.Transparent;
            this.navigationMusicIconLabel.CausesValidation = false;
            this.navigationMusicIconLabel.Enabled = false;
            this.navigationMusicIconLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navigationMusicIconLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationMusicIconLabel.ForeColor = System.Drawing.Color.Black;
            this.navigationMusicIconLabel.Location = new System.Drawing.Point(0, 0);
            this.navigationMusicIconLabel.Margin = new System.Windows.Forms.Padding(0);
            this.navigationMusicIconLabel.Name = "navigationMusicIconLabel";
            this.navigationMusicIconLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.navigationMusicIconLabel.Size = new System.Drawing.Size(50, 50);
            this.navigationMusicIconLabel.TabIndex = 4;
            this.navigationMusicIconLabel.Text = " ";
            this.navigationMusicIconLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // navigationMusicTextLabel
            // 
            this.navigationMusicTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.navigationMusicTextLabel.CausesValidation = false;
            this.navigationMusicTextLabel.Enabled = false;
            this.navigationMusicTextLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navigationMusicTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationMusicTextLabel.Location = new System.Drawing.Point(53, 0);
            this.navigationMusicTextLabel.Name = "navigationMusicTextLabel";
            this.navigationMusicTextLabel.Size = new System.Drawing.Size(222, 50);
            this.navigationMusicTextLabel.TabIndex = 1;
            this.navigationMusicTextLabel.Text = "Музыка";
            this.navigationMusicTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // navigationEditorPanel
            // 
            this.navigationEditorPanel.BackColor = System.Drawing.Color.Transparent;
            this.navigationEditorPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.navigationEditorPanel.Controls.Add(this.navigationEditorIconLabel);
            this.navigationEditorPanel.Controls.Add(this.navigationEditorTextLabel);
            this.navigationEditorPanel.ForeColor = System.Drawing.Color.Black;
            this.navigationEditorPanel.Location = new System.Drawing.Point(0, 178);
            this.navigationEditorPanel.Margin = new System.Windows.Forms.Padding(0);
            this.navigationEditorPanel.Name = "navigationEditorPanel";
            this.navigationEditorPanel.Size = new System.Drawing.Size(294, 55);
            this.navigationEditorPanel.TabIndex = 6;
            this.navigationEditorPanel.Click += new System.EventHandler(this.navigationEditorPanel_Click);
            // 
            // navigationEditorIconLabel
            // 
            this.navigationEditorIconLabel.BackColor = System.Drawing.Color.Transparent;
            this.navigationEditorIconLabel.CausesValidation = false;
            this.navigationEditorIconLabel.Enabled = false;
            this.navigationEditorIconLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navigationEditorIconLabel.Font = new System.Drawing.Font("Segoe MDL2 Assets", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationEditorIconLabel.ForeColor = System.Drawing.Color.Black;
            this.navigationEditorIconLabel.Location = new System.Drawing.Point(0, 0);
            this.navigationEditorIconLabel.Margin = new System.Windows.Forms.Padding(0);
            this.navigationEditorIconLabel.Name = "navigationEditorIconLabel";
            this.navigationEditorIconLabel.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            this.navigationEditorIconLabel.Size = new System.Drawing.Size(50, 50);
            this.navigationEditorIconLabel.TabIndex = 4;
            this.navigationEditorIconLabel.Text = "";
            this.navigationEditorIconLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // navigationEditorTextLabel
            // 
            this.navigationEditorTextLabel.BackColor = System.Drawing.Color.Transparent;
            this.navigationEditorTextLabel.CausesValidation = false;
            this.navigationEditorTextLabel.Enabled = false;
            this.navigationEditorTextLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.navigationEditorTextLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.navigationEditorTextLabel.Location = new System.Drawing.Point(53, 0);
            this.navigationEditorTextLabel.Name = "navigationEditorTextLabel";
            this.navigationEditorTextLabel.Size = new System.Drawing.Size(222, 50);
            this.navigationEditorTextLabel.TabIndex = 1;
            this.navigationEditorTextLabel.Text = "Редактор";
            this.navigationEditorTextLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // timerOfPlayback
            // 
            this.timerOfPlayback.Tick += new System.EventHandler(this.timerOfPlayback_Tick);
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(800, 584);
            this.Controls.Add(this.mainWindowSplitContainer);
            this.Controls.Add(this.musicPanel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(816, 623);
            this.Name = "MainWindow";
            this.Text = "AudioPlayer";
            this.Resize += new System.EventHandler(this.MainWindow_Resize);
            this.musicPanel.ResumeLayout(false);
            this.centerMusicPanel.ResumeLayout(false);
            this.centerMusicPanel.PerformLayout();
            this.musicControlsPanel.ResumeLayout(false);
            this.rightMusicPanel.ResumeLayout(false);
            this.rightMusicPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.coverPictureBox)).EndInit();
            this.mainWindowSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.mainWindowSplitContainer)).EndInit();
            this.mainWindowSplitContainer.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.navigationSettingsPanel.ResumeLayout(false);
            this.navigationAboutPanel.ResumeLayout(false);
            this.navigationEffectsPanel.ResumeLayout(false);
            this.navigationMusicPanel.ResumeLayout(false);
            this.navigationEditorPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel musicPanel;
        public System.Windows.Forms.PictureBox coverPictureBox;
        private System.Windows.Forms.Panel centerMusicPanel;
        private System.Windows.Forms.Panel rightMusicPanel;
        public XComponent.SliderBar.MACTrackBar volumeTrackBar;
        private System.Windows.Forms.Panel musicControlsPanel;
        private System.Windows.Forms.Button randomizeButton;
        private System.Windows.Forms.Button backwardButton;
        public System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button forwardButton;
        private System.Windows.Forms.Button repeatButton;
        public System.Windows.Forms.Label maximumDuration;
        public System.Windows.Forms.Label durationOfPlayback;
        public XComponent.SliderBar.MACTrackBar musicTrackBar;
        private System.Windows.Forms.SplitContainer mainWindowSplitContainer;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button hamburgerButton;
        private System.Windows.Forms.FlowLayoutPanel navigationSettingsPanel;
        private System.Windows.Forms.Label navigationSettingsIconLabel;
        private System.Windows.Forms.Label navigationSettingsTextLabel;
        private System.Windows.Forms.FlowLayoutPanel navigationAboutPanel;
        private System.Windows.Forms.Label navigationAboutIconLabel;
        private System.Windows.Forms.Label navigationAboutTextLabel;
        private System.Windows.Forms.FlowLayoutPanel navigationEffectsPanel;
        private System.Windows.Forms.Label navigationEffectsIconLabel;
        private System.Windows.Forms.Label navigationEffectsTextLabel;
        private System.Windows.Forms.FlowLayoutPanel navigationMusicPanel;
        private System.Windows.Forms.Label navigationMusicIconLabel;
        private System.Windows.Forms.Label navigationMusicTextLabel;
        private System.Windows.Forms.FlowLayoutPanel navigationEditorPanel;
        private System.Windows.Forms.Label navigationEditorIconLabel;
        private System.Windows.Forms.Label navigationEditorTextLabel;
        public System.Windows.Forms.Timer timerOfPlayback;
        public System.Windows.Forms.Label durationLabel;
        public System.Windows.Forms.Label volumeLabel;
        public System.Windows.Forms.Label nameOfCurrentTrackLabel;
    }
}

