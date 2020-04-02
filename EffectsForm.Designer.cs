namespace Draft_Audio_Player_New_Design
{
    partial class EffectsForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.musicTrackBar = new XComponent.SliderBar.MACTrackBar();
            this.maximumDuration = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pitchValueLabel = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pitchTrackBar = new XComponent.SliderBar.MACTrackBar();
            this.equalizer = new System.Windows.Forms.Button();
            this.mono = new System.Windows.Forms.Button();
            this.stereo = new System.Windows.Forms.Button();
            this.LoopLabel = new System.Windows.Forms.Label();
            this.loopRangeBar = new Zzzz.ZzzzRangeBar();
            this.minDurLabel = new System.Windows.Forms.Label();
            this.maxDurLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.startLoopButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // musicTrackBar
            // 
            this.musicTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.musicTrackBar.BorderColor = System.Drawing.Color.Transparent;
            this.musicTrackBar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.musicTrackBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.musicTrackBar.IndentHeight = 6;
            this.musicTrackBar.Location = new System.Drawing.Point(49, 36);
            this.musicTrackBar.Maximum = 50;
            this.musicTrackBar.Minimum = 0;
            this.musicTrackBar.MinimumSize = new System.Drawing.Size(300, 27);
            this.musicTrackBar.Name = "musicTrackBar";
            this.musicTrackBar.Size = new System.Drawing.Size(300, 27);
            this.musicTrackBar.TabIndex = 1;
            this.musicTrackBar.TabStop = false;
            this.musicTrackBar.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.musicTrackBar.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.musicTrackBar.TickHeight = 1;
            this.musicTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.musicTrackBar.TrackerColor = System.Drawing.Color.Snow;
            this.musicTrackBar.TrackerSize = new System.Drawing.Size(15, 15);
            this.musicTrackBar.TrackLineColor = System.Drawing.Color.Gray;
            this.musicTrackBar.TrackLineHeight = 3;
            this.musicTrackBar.TrackLineSelectedColor = System.Drawing.Color.SteelBlue;
            this.musicTrackBar.Value = 0;
            // 
            // maximumDuration
            // 
            this.maximumDuration.AutoSize = true;
            this.maximumDuration.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.maximumDuration.Location = new System.Drawing.Point(12, 9);
            this.maximumDuration.Name = "maximumDuration";
            this.maximumDuration.Size = new System.Drawing.Size(57, 24);
            this.maximumDuration.TabIndex = 16;
            this.maximumDuration.Text = "Темп";
            // 
            // playButton
            // 
            this.playButton.BackColor = System.Drawing.Color.Transparent;
            this.playButton.CausesValidation = false;
            this.playButton.FlatAppearance.BorderSize = 0;
            this.playButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.ForeColor = System.Drawing.Color.Transparent;
            this.playButton.Location = new System.Drawing.Point(16, 36);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(27, 27);
            this.playButton.TabIndex = 19;
            this.playButton.Text = "";
            this.playButton.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.CausesValidation = false;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Transparent;
            this.button1.Location = new System.Drawing.Point(355, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(27, 27);
            this.button1.TabIndex = 20;
            this.button1.Text = "";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(180, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 24);
            this.label1.TabIndex = 21;
            this.label1.Text = "100%";
            // 
            // pitchValueLabel
            // 
            this.pitchValueLabel.AutoSize = true;
            this.pitchValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pitchValueLabel.Location = new System.Drawing.Point(190, 85);
            this.pitchValueLabel.Name = "pitchValueLabel";
            this.pitchValueLabel.Size = new System.Drawing.Size(20, 24);
            this.pitchValueLabel.TabIndex = 26;
            this.pitchValueLabel.Text = "0";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Transparent;
            this.button2.CausesValidation = false;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Transparent;
            this.button2.Location = new System.Drawing.Point(355, 112);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 27);
            this.button2.TabIndex = 25;
            this.button2.Text = "";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Transparent;
            this.button3.CausesValidation = false;
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.Transparent;
            this.button3.Location = new System.Drawing.Point(16, 112);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 27);
            this.button3.TabIndex = 24;
            this.button3.Text = "";
            this.button3.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(12, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 24);
            this.label3.TabIndex = 23;
            this.label3.Text = "Тон";
            // 
            // pitchTrackBar
            // 
            this.pitchTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.pitchTrackBar.BorderColor = System.Drawing.Color.Transparent;
            this.pitchTrackBar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pitchTrackBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.pitchTrackBar.IndentHeight = 6;
            this.pitchTrackBar.Location = new System.Drawing.Point(49, 112);
            this.pitchTrackBar.Maximum = 6;
            this.pitchTrackBar.Minimum = -6;
            this.pitchTrackBar.MinimumSize = new System.Drawing.Size(300, 27);
            this.pitchTrackBar.Name = "pitchTrackBar";
            this.pitchTrackBar.Size = new System.Drawing.Size(300, 27);
            this.pitchTrackBar.TabIndex = 22;
            this.pitchTrackBar.TabStop = false;
            this.pitchTrackBar.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.pitchTrackBar.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(146)))), ((int)(((byte)(148)))));
            this.pitchTrackBar.TickHeight = 1;
            this.pitchTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.pitchTrackBar.TrackerColor = System.Drawing.Color.Snow;
            this.pitchTrackBar.TrackerSize = new System.Drawing.Size(15, 15);
            this.pitchTrackBar.TrackLineColor = System.Drawing.Color.Gray;
            this.pitchTrackBar.TrackLineHeight = 3;
            this.pitchTrackBar.TrackLineSelectedColor = System.Drawing.Color.SteelBlue;
            this.pitchTrackBar.Value = 0;
            this.pitchTrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pitchTrackBar_MouseUp);
            // 
            // equalizer
            // 
            this.equalizer.BackColor = System.Drawing.Color.Transparent;
            this.equalizer.CausesValidation = false;
            this.equalizer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.equalizer.ForeColor = System.Drawing.Color.Transparent;
            this.equalizer.Location = new System.Drawing.Point(405, 22);
            this.equalizer.Name = "equalizer";
            this.equalizer.Size = new System.Drawing.Size(237, 40);
            this.equalizer.TabIndex = 27;
            this.equalizer.Text = "Эквалайзер";
            this.equalizer.UseVisualStyleBackColor = false;
            this.equalizer.Click += new System.EventHandler(this.equalizer_Click);
            // 
            // mono
            // 
            this.mono.BackColor = System.Drawing.Color.Transparent;
            this.mono.CausesValidation = false;
            this.mono.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.mono.ForeColor = System.Drawing.Color.Transparent;
            this.mono.Location = new System.Drawing.Point(405, 107);
            this.mono.Name = "mono";
            this.mono.Size = new System.Drawing.Size(113, 40);
            this.mono.TabIndex = 28;
            this.mono.Text = "Моно";
            this.mono.UseVisualStyleBackColor = false;
            this.mono.Click += new System.EventHandler(this.mono_Click);
            // 
            // stereo
            // 
            this.stereo.BackColor = System.Drawing.Color.Transparent;
            this.stereo.CausesValidation = false;
            this.stereo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.stereo.ForeColor = System.Drawing.Color.Transparent;
            this.stereo.Location = new System.Drawing.Point(529, 107);
            this.stereo.Name = "stereo";
            this.stereo.Size = new System.Drawing.Size(113, 40);
            this.stereo.TabIndex = 29;
            this.stereo.Text = "Стерео";
            this.stereo.UseVisualStyleBackColor = false;
            this.stereo.Click += new System.EventHandler(this.stereo_Click);
            // 
            // LoopLabel
            // 
            this.LoopLabel.AutoSize = true;
            this.LoopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoopLabel.Location = new System.Drawing.Point(12, 166);
            this.LoopLabel.Name = "LoopLabel";
            this.LoopLabel.Size = new System.Drawing.Size(139, 24);
            this.LoopLabel.TabIndex = 30;
            this.LoopLabel.Text = "Зацикливание";
            // 
            // loopRangeBar
            // 
            this.loopRangeBar.DivisionNum = 0;
            this.loopRangeBar.HeightOfBar = 8;
            this.loopRangeBar.HeightOfMark = 24;
            this.loopRangeBar.HeightOfTick = 6;
            this.loopRangeBar.InnerColor = System.Drawing.Color.SteelBlue;
            this.loopRangeBar.Location = new System.Drawing.Point(49, 193);
            this.loopRangeBar.Name = "loopRangeBar";
            this.loopRangeBar.Orientation = Zzzz.ZzzzRangeBar.RangeBarOrientation.horizontal;
            this.loopRangeBar.RangeMaximum = this.loopRangeBar.TotalMaximum;
            this.loopRangeBar.RangeMinimum = 0;
            this.loopRangeBar.ScaleOrientation = Zzzz.ZzzzRangeBar.TopBottomOrientation.bottom;
            this.loopRangeBar.Size = new System.Drawing.Size(300, 27);
            this.loopRangeBar.TabIndex = 31;
            this.loopRangeBar.TotalMaximum = 10;
            this.loopRangeBar.TotalMinimum = 0;
            this.loopRangeBar.RangeChanging += new Zzzz.ZzzzRangeBar.RangeChangedEventHandler(this.loopRangeBar_RangeChanging);
            // 
            // minDurLabel
            // 
            this.minDurLabel.AutoSize = true;
            this.minDurLabel.Location = new System.Drawing.Point(13, 223);
            this.minDurLabel.Name = "minDurLabel";
            this.minDurLabel.Size = new System.Drawing.Size(34, 13);
            this.minDurLabel.TabIndex = 32;
            this.minDurLabel.Text = "00:00";
            // 
            // maxDurLabel
            // 
            this.maxDurLabel.AutoSize = true;
            this.maxDurLabel.Location = new System.Drawing.Point(348, 223);
            this.maxDurLabel.Name = "maxDurLabel";
            this.maxDurLabel.Size = new System.Drawing.Size(34, 13);
            this.maxDurLabel.TabIndex = 33;
            this.maxDurLabel.Text = "00:00";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Transparent;
            this.resetButton.CausesValidation = false;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.ForeColor = System.Drawing.Color.Transparent;
            this.resetButton.Location = new System.Drawing.Point(279, 162);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(70, 25);
            this.resetButton.TabIndex = 34;
            this.resetButton.Text = "Сбросить";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // startLoopButton
            // 
            this.startLoopButton.BackColor = System.Drawing.Color.Transparent;
            this.startLoopButton.CausesValidation = false;
            this.startLoopButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startLoopButton.ForeColor = System.Drawing.Color.Transparent;
            this.startLoopButton.Location = new System.Drawing.Point(119, 226);
            this.startLoopButton.Name = "startLoopButton";
            this.startLoopButton.Size = new System.Drawing.Size(150, 25);
            this.startLoopButton.TabIndex = 35;
            this.startLoopButton.Text = "Начать зацикливание";
            this.startLoopButton.UseVisualStyleBackColor = false;
            this.startLoopButton.Click += new System.EventHandler(this.startLoopButton_Click);
            // 
            // EffectsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.startLoopButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.maxDurLabel);
            this.Controls.Add(this.minDurLabel);
            this.Controls.Add(this.loopRangeBar);
            this.Controls.Add(this.LoopLabel);
            this.Controls.Add(this.stereo);
            this.Controls.Add(this.mono);
            this.Controls.Add(this.equalizer);
            this.Controls.Add(this.pitchValueLabel);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pitchTrackBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.maximumDuration);
            this.Controls.Add(this.musicTrackBar);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EffectsForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public XComponent.SliderBar.MACTrackBar musicTrackBar;
        public System.Windows.Forms.Label maximumDuration;
        public System.Windows.Forms.Button playButton;
        public System.Windows.Forms.Button button1;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label pitchValueLabel;
        public System.Windows.Forms.Button button2;
        public System.Windows.Forms.Button button3;
        public System.Windows.Forms.Label label3;
        public XComponent.SliderBar.MACTrackBar pitchTrackBar;
        private System.Windows.Forms.Button equalizer;
        private System.Windows.Forms.Button mono;
        private System.Windows.Forms.Button stereo;
        public System.Windows.Forms.Label LoopLabel;
        private Zzzz.ZzzzRangeBar loopRangeBar;
        public System.Windows.Forms.Label minDurLabel;
        public System.Windows.Forms.Label maxDurLabel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button startLoopButton;
    }
}