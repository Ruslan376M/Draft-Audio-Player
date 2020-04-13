namespace Music_Speed_And_Pitch_Changer
{
    partial class EffectsWindow
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
            this.pitchTrackBar = new XComponent.SliderBar.MACTrackBar();
            this.pitchLabel = new System.Windows.Forms.Label();
            this.minusPitchButton = new System.Windows.Forms.Button();
            this.plusPitchButton = new System.Windows.Forms.Button();
            this.pitchValueLabel = new System.Windows.Forms.Label();
            this.tempValueLabel = new System.Windows.Forms.Label();
            this.plusTempButton = new System.Windows.Forms.Button();
            this.minusTempButton = new System.Windows.Forms.Button();
            this.tempLabel = new System.Windows.Forms.Label();
            this.tempTrackBar = new XComponent.SliderBar.MACTrackBar();
            this.maxDurLabel = new System.Windows.Forms.Label();
            this.minDurLabel = new System.Windows.Forms.Label();
            this.loopRangeBar = new Zzzz.ZzzzRangeBar();
            this.LoopLabel = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.band1TrackBar = new XComponent.SliderBar.MACTrackBar();
            this.label1 = new System.Windows.Forms.Label();
            this.band2TrackBar = new XComponent.SliderBar.MACTrackBar();
            this.band3TrackBar = new XComponent.SliderBar.MACTrackBar();
            this.band4TrackBar = new XComponent.SliderBar.MACTrackBar();
            this.band8TrackBar = new XComponent.SliderBar.MACTrackBar();
            this.band7TrackBar = new XComponent.SliderBar.MACTrackBar();
            this.band6TrackBar = new XComponent.SliderBar.MACTrackBar();
            this.band5TrackBar = new XComponent.SliderBar.MACTrackBar();
            this.band10TrackBar = new XComponent.SliderBar.MACTrackBar();
            this.band9TrackBar = new XComponent.SliderBar.MACTrackBar();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.resetEqualizerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // pitchTrackBar
            // 
            this.pitchTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.pitchTrackBar.BorderColor = System.Drawing.Color.Transparent;
            this.pitchTrackBar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pitchTrackBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.pitchTrackBar.IndentHeight = 6;
            this.pitchTrackBar.Location = new System.Drawing.Point(49, 36);
            this.pitchTrackBar.Maximum = 24;
            this.pitchTrackBar.Minimum = -24;
            this.pitchTrackBar.MinimumSize = new System.Drawing.Size(100, 27);
            this.pitchTrackBar.Name = "pitchTrackBar";
            this.pitchTrackBar.Size = new System.Drawing.Size(268, 27);
            this.pitchTrackBar.TabIndex = 16;
            this.pitchTrackBar.TabStop = false;
            this.pitchTrackBar.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.pitchTrackBar.TickColor = System.Drawing.Color.Transparent;
            this.pitchTrackBar.TickHeight = 1;
            this.pitchTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.pitchTrackBar.TrackerColor = System.Drawing.Color.Transparent;
            this.pitchTrackBar.TrackerSize = new System.Drawing.Size(15, 15);
            this.pitchTrackBar.TrackLineColor = System.Drawing.Color.Transparent;
            this.pitchTrackBar.TrackLineHeight = 3;
            this.pitchTrackBar.TrackLineSelectedColor = System.Drawing.Color.SteelBlue;
            this.pitchTrackBar.Value = 0;
            this.pitchTrackBar.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.pitchTrackBar_ValueChanged);
            // 
            // pitchLabel
            // 
            this.pitchLabel.AutoSize = true;
            this.pitchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pitchLabel.Location = new System.Drawing.Point(12, 9);
            this.pitchLabel.Name = "pitchLabel";
            this.pitchLabel.Size = new System.Drawing.Size(44, 24);
            this.pitchLabel.TabIndex = 17;
            this.pitchLabel.Text = "Тон";
            // 
            // minusPitchButton
            // 
            this.minusPitchButton.BackColor = System.Drawing.Color.Transparent;
            this.minusPitchButton.CausesValidation = false;
            this.minusPitchButton.FlatAppearance.BorderSize = 0;
            this.minusPitchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.minusPitchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.minusPitchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusPitchButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusPitchButton.ForeColor = System.Drawing.Color.Black;
            this.minusPitchButton.Location = new System.Drawing.Point(16, 36);
            this.minusPitchButton.Name = "minusPitchButton";
            this.minusPitchButton.Size = new System.Drawing.Size(27, 27);
            this.minusPitchButton.TabIndex = 20;
            this.minusPitchButton.Text = "";
            this.minusPitchButton.UseVisualStyleBackColor = false;
            this.minusPitchButton.Click += new System.EventHandler(this.minusPitchButton_Click);
            // 
            // plusPitchButton
            // 
            this.plusPitchButton.BackColor = System.Drawing.Color.Transparent;
            this.plusPitchButton.CausesValidation = false;
            this.plusPitchButton.FlatAppearance.BorderSize = 0;
            this.plusPitchButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.plusPitchButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.plusPitchButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusPitchButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusPitchButton.ForeColor = System.Drawing.Color.Black;
            this.plusPitchButton.Location = new System.Drawing.Point(323, 36);
            this.plusPitchButton.Name = "plusPitchButton";
            this.plusPitchButton.Size = new System.Drawing.Size(27, 27);
            this.plusPitchButton.TabIndex = 21;
            this.plusPitchButton.Text = "";
            this.plusPitchButton.UseVisualStyleBackColor = false;
            this.plusPitchButton.Click += new System.EventHandler(this.plusPitchButton_Click);
            // 
            // pitchValueLabel
            // 
            this.pitchValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.pitchValueLabel.Location = new System.Drawing.Point(161, 9);
            this.pitchValueLabel.Name = "pitchValueLabel";
            this.pitchValueLabel.Size = new System.Drawing.Size(44, 24);
            this.pitchValueLabel.TabIndex = 27;
            this.pitchValueLabel.Text = "+0";
            this.pitchValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tempValueLabel
            // 
            this.tempValueLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tempValueLabel.Location = new System.Drawing.Point(157, 79);
            this.tempValueLabel.Name = "tempValueLabel";
            this.tempValueLabel.Size = new System.Drawing.Size(56, 24);
            this.tempValueLabel.TabIndex = 32;
            this.tempValueLabel.Text = "100%";
            this.tempValueLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // plusTempButton
            // 
            this.plusTempButton.BackColor = System.Drawing.Color.Transparent;
            this.plusTempButton.CausesValidation = false;
            this.plusTempButton.FlatAppearance.BorderSize = 0;
            this.plusTempButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.plusTempButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.plusTempButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.plusTempButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.plusTempButton.ForeColor = System.Drawing.Color.Black;
            this.plusTempButton.Location = new System.Drawing.Point(323, 106);
            this.plusTempButton.Name = "plusTempButton";
            this.plusTempButton.Size = new System.Drawing.Size(27, 27);
            this.plusTempButton.TabIndex = 31;
            this.plusTempButton.Text = "";
            this.plusTempButton.UseVisualStyleBackColor = false;
            this.plusTempButton.Click += new System.EventHandler(this.plusTempButton_Click);
            // 
            // minusTempButton
            // 
            this.minusTempButton.BackColor = System.Drawing.Color.Transparent;
            this.minusTempButton.CausesValidation = false;
            this.minusTempButton.FlatAppearance.BorderSize = 0;
            this.minusTempButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.minusTempButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.minusTempButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.minusTempButton.Font = new System.Drawing.Font("Segoe MDL2 Assets", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusTempButton.ForeColor = System.Drawing.Color.Black;
            this.minusTempButton.Location = new System.Drawing.Point(16, 106);
            this.minusTempButton.Name = "minusTempButton";
            this.minusTempButton.Size = new System.Drawing.Size(27, 27);
            this.minusTempButton.TabIndex = 30;
            this.minusTempButton.Text = "";
            this.minusTempButton.UseVisualStyleBackColor = false;
            this.minusTempButton.Click += new System.EventHandler(this.minusTempButton_Click);
            // 
            // tempLabel
            // 
            this.tempLabel.AutoSize = true;
            this.tempLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.tempLabel.Location = new System.Drawing.Point(12, 79);
            this.tempLabel.Name = "tempLabel";
            this.tempLabel.Size = new System.Drawing.Size(57, 24);
            this.tempLabel.TabIndex = 29;
            this.tempLabel.Text = "Темп";
            // 
            // tempTrackBar
            // 
            this.tempTrackBar.BackColor = System.Drawing.Color.Transparent;
            this.tempTrackBar.BorderColor = System.Drawing.Color.Transparent;
            this.tempTrackBar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tempTrackBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.tempTrackBar.IndentHeight = 6;
            this.tempTrackBar.Location = new System.Drawing.Point(49, 106);
            this.tempTrackBar.Maximum = 200;
            this.tempTrackBar.Minimum = 0;
            this.tempTrackBar.MinimumSize = new System.Drawing.Size(100, 27);
            this.tempTrackBar.Name = "tempTrackBar";
            this.tempTrackBar.Size = new System.Drawing.Size(268, 27);
            this.tempTrackBar.TabIndex = 28;
            this.tempTrackBar.TabStop = false;
            this.tempTrackBar.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.tempTrackBar.TickColor = System.Drawing.Color.Transparent;
            this.tempTrackBar.TickHeight = 1;
            this.tempTrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tempTrackBar.TrackerColor = System.Drawing.Color.Transparent;
            this.tempTrackBar.TrackerSize = new System.Drawing.Size(15, 15);
            this.tempTrackBar.TrackLineColor = System.Drawing.Color.Transparent;
            this.tempTrackBar.TrackLineHeight = 3;
            this.tempTrackBar.TrackLineSelectedColor = System.Drawing.Color.SteelBlue;
            this.tempTrackBar.Value = 100;
            this.tempTrackBar.ValueChanged += new XComponent.SliderBar.ValueChangedHandler(this.tempTrackBar_ValueChanged);
            // 
            // maxDurLabel
            // 
            this.maxDurLabel.AutoSize = true;
            this.maxDurLabel.Location = new System.Drawing.Point(333, 192);
            this.maxDurLabel.Name = "maxDurLabel";
            this.maxDurLabel.Size = new System.Drawing.Size(34, 13);
            this.maxDurLabel.TabIndex = 39;
            this.maxDurLabel.Text = "00:00";
            // 
            // minDurLabel
            // 
            this.minDurLabel.AutoSize = true;
            this.minDurLabel.Location = new System.Drawing.Point(14, 190);
            this.minDurLabel.Name = "minDurLabel";
            this.minDurLabel.Size = new System.Drawing.Size(34, 13);
            this.minDurLabel.TabIndex = 38;
            this.minDurLabel.Text = "00:00";
            // 
            // loopRangeBar
            // 
            this.loopRangeBar.DivisionNum = 0;
            this.loopRangeBar.HeightOfBar = 8;
            this.loopRangeBar.HeightOfMark = 24;
            this.loopRangeBar.HeightOfTick = 6;
            this.loopRangeBar.InnerColor = System.Drawing.Color.SteelBlue;
            this.loopRangeBar.Location = new System.Drawing.Point(55, 185);
            this.loopRangeBar.Name = "loopRangeBar";
            this.loopRangeBar.Orientation = Zzzz.ZzzzRangeBar.RangeBarOrientation.horizontal;
            this.loopRangeBar.RangeMaximum = this.loopRangeBar.TotalMaximum;
            this.loopRangeBar.RangeMinimum = 0;
            this.loopRangeBar.ScaleOrientation = Zzzz.ZzzzRangeBar.TopBottomOrientation.bottom;
            this.loopRangeBar.Size = new System.Drawing.Size(267, 27);
            this.loopRangeBar.TabIndex = 37;
            this.loopRangeBar.TotalMaximum = 10;
            this.loopRangeBar.TotalMinimum = 0;
            this.loopRangeBar.RangeChanging += new Zzzz.ZzzzRangeBar.RangeChangedEventHandler(this.loopRangeBar_RangeChanging);
            this.loopRangeBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.loopRangeBar_MouseUp);
            // 
            // LoopLabel
            // 
            this.LoopLabel.AutoSize = true;
            this.LoopLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.LoopLabel.Location = new System.Drawing.Point(13, 146);
            this.LoopLabel.Name = "LoopLabel";
            this.LoopLabel.Size = new System.Drawing.Size(52, 24);
            this.LoopLabel.TabIndex = 36;
            this.LoopLabel.Text = "Цикл";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Transparent;
            this.resetButton.CausesValidation = false;
            this.resetButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.resetButton.FlatAppearance.BorderSize = 2;
            this.resetButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.resetButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetButton.ForeColor = System.Drawing.Color.Black;
            this.resetButton.Location = new System.Drawing.Point(143, 208);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(82, 31);
            this.resetButton.TabIndex = 43;
            this.resetButton.TabStop = false;
            this.resetButton.Text = "Сбросить";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // band1TrackBar
            // 
            this.band1TrackBar.BackColor = System.Drawing.Color.Transparent;
            this.band1TrackBar.BorderColor = System.Drawing.Color.Transparent;
            this.band1TrackBar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.band1TrackBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.band1TrackBar.IndentHeight = 6;
            this.band1TrackBar.Location = new System.Drawing.Point(414, 9);
            this.band1TrackBar.Maximum = 120;
            this.band1TrackBar.Minimum = -120;
            this.band1TrackBar.MinimumSize = new System.Drawing.Size(27, 5);
            this.band1TrackBar.Name = "band1TrackBar";
            this.band1TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.band1TrackBar.Size = new System.Drawing.Size(27, 268);
            this.band1TrackBar.TabIndex = 45;
            this.band1TrackBar.TabStop = false;
            this.band1TrackBar.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.band1TrackBar.TickColor = System.Drawing.Color.Transparent;
            this.band1TrackBar.TickHeight = 1;
            this.band1TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.band1TrackBar.TrackerColor = System.Drawing.Color.White;
            this.band1TrackBar.TrackerSize = new System.Drawing.Size(15, 15);
            this.band1TrackBar.TrackLineColor = System.Drawing.Color.White;
            this.band1TrackBar.TrackLineHeight = 3;
            this.band1TrackBar.TrackLineSelectedColor = System.Drawing.Color.SteelBlue;
            this.band1TrackBar.Value = 0;
            this.band1TrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.band1TrackBar_MouseUp);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(414, 280);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 46;
            this.label1.Text = "31";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // band2TrackBar
            // 
            this.band2TrackBar.BackColor = System.Drawing.Color.Transparent;
            this.band2TrackBar.BorderColor = System.Drawing.Color.Transparent;
            this.band2TrackBar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.band2TrackBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.band2TrackBar.IndentHeight = 6;
            this.band2TrackBar.Location = new System.Drawing.Point(447, 9);
            this.band2TrackBar.Maximum = 120;
            this.band2TrackBar.Minimum = -120;
            this.band2TrackBar.MinimumSize = new System.Drawing.Size(27, 5);
            this.band2TrackBar.Name = "band2TrackBar";
            this.band2TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.band2TrackBar.Size = new System.Drawing.Size(27, 268);
            this.band2TrackBar.TabIndex = 47;
            this.band2TrackBar.TabStop = false;
            this.band2TrackBar.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.band2TrackBar.TickColor = System.Drawing.Color.Transparent;
            this.band2TrackBar.TickHeight = 1;
            this.band2TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.band2TrackBar.TrackerColor = System.Drawing.Color.Transparent;
            this.band2TrackBar.TrackerSize = new System.Drawing.Size(15, 15);
            this.band2TrackBar.TrackLineColor = System.Drawing.Color.Transparent;
            this.band2TrackBar.TrackLineHeight = 3;
            this.band2TrackBar.TrackLineSelectedColor = System.Drawing.Color.SteelBlue;
            this.band2TrackBar.Value = 0;
            this.band2TrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.band2TrackBar_MouseUp);
            // 
            // band3TrackBar
            // 
            this.band3TrackBar.BackColor = System.Drawing.Color.Transparent;
            this.band3TrackBar.BorderColor = System.Drawing.Color.Transparent;
            this.band3TrackBar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.band3TrackBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.band3TrackBar.IndentHeight = 6;
            this.band3TrackBar.Location = new System.Drawing.Point(480, 9);
            this.band3TrackBar.Maximum = 120;
            this.band3TrackBar.Minimum = -120;
            this.band3TrackBar.MinimumSize = new System.Drawing.Size(27, 5);
            this.band3TrackBar.Name = "band3TrackBar";
            this.band3TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.band3TrackBar.Size = new System.Drawing.Size(27, 268);
            this.band3TrackBar.TabIndex = 49;
            this.band3TrackBar.TabStop = false;
            this.band3TrackBar.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.band3TrackBar.TickColor = System.Drawing.Color.Transparent;
            this.band3TrackBar.TickHeight = 1;
            this.band3TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.band3TrackBar.TrackerColor = System.Drawing.Color.Transparent;
            this.band3TrackBar.TrackerSize = new System.Drawing.Size(15, 15);
            this.band3TrackBar.TrackLineColor = System.Drawing.Color.Transparent;
            this.band3TrackBar.TrackLineHeight = 3;
            this.band3TrackBar.TrackLineSelectedColor = System.Drawing.Color.SteelBlue;
            this.band3TrackBar.Value = 0;
            this.band3TrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.band3TrackBar_MouseUp);
            // 
            // band4TrackBar
            // 
            this.band4TrackBar.BackColor = System.Drawing.Color.Transparent;
            this.band4TrackBar.BorderColor = System.Drawing.Color.Transparent;
            this.band4TrackBar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.band4TrackBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.band4TrackBar.IndentHeight = 6;
            this.band4TrackBar.Location = new System.Drawing.Point(513, 9);
            this.band4TrackBar.Maximum = 120;
            this.band4TrackBar.Minimum = -120;
            this.band4TrackBar.MinimumSize = new System.Drawing.Size(27, 5);
            this.band4TrackBar.Name = "band4TrackBar";
            this.band4TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.band4TrackBar.Size = new System.Drawing.Size(27, 268);
            this.band4TrackBar.TabIndex = 51;
            this.band4TrackBar.TabStop = false;
            this.band4TrackBar.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.band4TrackBar.TickColor = System.Drawing.Color.Transparent;
            this.band4TrackBar.TickHeight = 1;
            this.band4TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.band4TrackBar.TrackerColor = System.Drawing.Color.Transparent;
            this.band4TrackBar.TrackerSize = new System.Drawing.Size(15, 15);
            this.band4TrackBar.TrackLineColor = System.Drawing.Color.Transparent;
            this.band4TrackBar.TrackLineHeight = 3;
            this.band4TrackBar.TrackLineSelectedColor = System.Drawing.Color.SteelBlue;
            this.band4TrackBar.Value = 0;
            this.band4TrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.band4TrackBar_MouseUp);
            // 
            // band8TrackBar
            // 
            this.band8TrackBar.BackColor = System.Drawing.Color.Transparent;
            this.band8TrackBar.BorderColor = System.Drawing.Color.Transparent;
            this.band8TrackBar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.band8TrackBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.band8TrackBar.IndentHeight = 6;
            this.band8TrackBar.Location = new System.Drawing.Point(645, 9);
            this.band8TrackBar.Maximum = 120;
            this.band8TrackBar.Minimum = -120;
            this.band8TrackBar.MinimumSize = new System.Drawing.Size(27, 5);
            this.band8TrackBar.Name = "band8TrackBar";
            this.band8TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.band8TrackBar.Size = new System.Drawing.Size(27, 268);
            this.band8TrackBar.TabIndex = 59;
            this.band8TrackBar.TabStop = false;
            this.band8TrackBar.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.band8TrackBar.TickColor = System.Drawing.Color.Transparent;
            this.band8TrackBar.TickHeight = 1;
            this.band8TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.band8TrackBar.TrackerColor = System.Drawing.Color.Transparent;
            this.band8TrackBar.TrackerSize = new System.Drawing.Size(15, 15);
            this.band8TrackBar.TrackLineColor = System.Drawing.Color.Transparent;
            this.band8TrackBar.TrackLineHeight = 3;
            this.band8TrackBar.TrackLineSelectedColor = System.Drawing.Color.SteelBlue;
            this.band8TrackBar.Value = 0;
            this.band8TrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.band8TrackBar_MouseUp);
            // 
            // band7TrackBar
            // 
            this.band7TrackBar.BackColor = System.Drawing.Color.Transparent;
            this.band7TrackBar.BorderColor = System.Drawing.Color.Transparent;
            this.band7TrackBar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.band7TrackBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.band7TrackBar.IndentHeight = 6;
            this.band7TrackBar.Location = new System.Drawing.Point(612, 9);
            this.band7TrackBar.Maximum = 120;
            this.band7TrackBar.Minimum = -120;
            this.band7TrackBar.MinimumSize = new System.Drawing.Size(27, 5);
            this.band7TrackBar.Name = "band7TrackBar";
            this.band7TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.band7TrackBar.Size = new System.Drawing.Size(27, 268);
            this.band7TrackBar.TabIndex = 57;
            this.band7TrackBar.TabStop = false;
            this.band7TrackBar.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.band7TrackBar.TickColor = System.Drawing.Color.Transparent;
            this.band7TrackBar.TickHeight = 1;
            this.band7TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.band7TrackBar.TrackerColor = System.Drawing.Color.Transparent;
            this.band7TrackBar.TrackerSize = new System.Drawing.Size(15, 15);
            this.band7TrackBar.TrackLineColor = System.Drawing.Color.Transparent;
            this.band7TrackBar.TrackLineHeight = 3;
            this.band7TrackBar.TrackLineSelectedColor = System.Drawing.Color.SteelBlue;
            this.band7TrackBar.Value = 0;
            this.band7TrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.band7TrackBar_MouseUp);
            // 
            // band6TrackBar
            // 
            this.band6TrackBar.BackColor = System.Drawing.Color.Transparent;
            this.band6TrackBar.BorderColor = System.Drawing.Color.Transparent;
            this.band6TrackBar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.band6TrackBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.band6TrackBar.IndentHeight = 6;
            this.band6TrackBar.Location = new System.Drawing.Point(579, 9);
            this.band6TrackBar.Maximum = 120;
            this.band6TrackBar.Minimum = -120;
            this.band6TrackBar.MinimumSize = new System.Drawing.Size(27, 5);
            this.band6TrackBar.Name = "band6TrackBar";
            this.band6TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.band6TrackBar.Size = new System.Drawing.Size(27, 268);
            this.band6TrackBar.TabIndex = 55;
            this.band6TrackBar.TabStop = false;
            this.band6TrackBar.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.band6TrackBar.TickColor = System.Drawing.Color.Transparent;
            this.band6TrackBar.TickHeight = 1;
            this.band6TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.band6TrackBar.TrackerColor = System.Drawing.Color.Transparent;
            this.band6TrackBar.TrackerSize = new System.Drawing.Size(15, 15);
            this.band6TrackBar.TrackLineColor = System.Drawing.Color.Transparent;
            this.band6TrackBar.TrackLineHeight = 3;
            this.band6TrackBar.TrackLineSelectedColor = System.Drawing.Color.SteelBlue;
            this.band6TrackBar.Value = 0;
            this.band6TrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.band6TrackBar_MouseUp);
            // 
            // band5TrackBar
            // 
            this.band5TrackBar.BackColor = System.Drawing.Color.Transparent;
            this.band5TrackBar.BorderColor = System.Drawing.Color.Transparent;
            this.band5TrackBar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.band5TrackBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.band5TrackBar.IndentHeight = 6;
            this.band5TrackBar.Location = new System.Drawing.Point(546, 9);
            this.band5TrackBar.Maximum = 120;
            this.band5TrackBar.Minimum = -120;
            this.band5TrackBar.MinimumSize = new System.Drawing.Size(27, 5);
            this.band5TrackBar.Name = "band5TrackBar";
            this.band5TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.band5TrackBar.Size = new System.Drawing.Size(27, 268);
            this.band5TrackBar.TabIndex = 53;
            this.band5TrackBar.TabStop = false;
            this.band5TrackBar.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.band5TrackBar.TickColor = System.Drawing.Color.Transparent;
            this.band5TrackBar.TickHeight = 1;
            this.band5TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.band5TrackBar.TrackerColor = System.Drawing.Color.Transparent;
            this.band5TrackBar.TrackerSize = new System.Drawing.Size(15, 15);
            this.band5TrackBar.TrackLineColor = System.Drawing.Color.Transparent;
            this.band5TrackBar.TrackLineHeight = 3;
            this.band5TrackBar.TrackLineSelectedColor = System.Drawing.Color.SteelBlue;
            this.band5TrackBar.Value = 0;
            this.band5TrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.band5TrackBar_MouseUp);
            // 
            // band10TrackBar
            // 
            this.band10TrackBar.BackColor = System.Drawing.Color.Transparent;
            this.band10TrackBar.BorderColor = System.Drawing.Color.Transparent;
            this.band10TrackBar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.band10TrackBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.band10TrackBar.IndentHeight = 6;
            this.band10TrackBar.Location = new System.Drawing.Point(711, 9);
            this.band10TrackBar.Maximum = 120;
            this.band10TrackBar.Minimum = -120;
            this.band10TrackBar.MinimumSize = new System.Drawing.Size(27, 5);
            this.band10TrackBar.Name = "band10TrackBar";
            this.band10TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.band10TrackBar.Size = new System.Drawing.Size(27, 268);
            this.band10TrackBar.TabIndex = 62;
            this.band10TrackBar.TabStop = false;
            this.band10TrackBar.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.band10TrackBar.TickColor = System.Drawing.Color.Transparent;
            this.band10TrackBar.TickHeight = 1;
            this.band10TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.band10TrackBar.TrackerColor = System.Drawing.Color.Transparent;
            this.band10TrackBar.TrackerSize = new System.Drawing.Size(15, 15);
            this.band10TrackBar.TrackLineColor = System.Drawing.Color.Transparent;
            this.band10TrackBar.TrackLineHeight = 3;
            this.band10TrackBar.TrackLineSelectedColor = System.Drawing.Color.SteelBlue;
            this.band10TrackBar.Value = 0;
            this.band10TrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.band10TrackBar_MouseUp);
            // 
            // band9TrackBar
            // 
            this.band9TrackBar.BackColor = System.Drawing.Color.Transparent;
            this.band9TrackBar.BorderColor = System.Drawing.Color.Transparent;
            this.band9TrackBar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.band9TrackBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(125)))), ((int)(((byte)(123)))));
            this.band9TrackBar.IndentHeight = 6;
            this.band9TrackBar.Location = new System.Drawing.Point(678, 9);
            this.band9TrackBar.Maximum = 120;
            this.band9TrackBar.Minimum = -120;
            this.band9TrackBar.MinimumSize = new System.Drawing.Size(27, 5);
            this.band9TrackBar.Name = "band9TrackBar";
            this.band9TrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.band9TrackBar.Size = new System.Drawing.Size(27, 268);
            this.band9TrackBar.TabIndex = 61;
            this.band9TrackBar.TabStop = false;
            this.band9TrackBar.TextTickStyle = System.Windows.Forms.TickStyle.None;
            this.band9TrackBar.TickColor = System.Drawing.Color.Transparent;
            this.band9TrackBar.TickHeight = 1;
            this.band9TrackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.band9TrackBar.TrackerColor = System.Drawing.Color.Transparent;
            this.band9TrackBar.TrackerSize = new System.Drawing.Size(15, 15);
            this.band9TrackBar.TrackLineColor = System.Drawing.Color.Transparent;
            this.band9TrackBar.TrackLineHeight = 3;
            this.band9TrackBar.TrackLineSelectedColor = System.Drawing.Color.SteelBlue;
            this.band9TrackBar.Value = 0;
            this.band9TrackBar.MouseUp += new System.Windows.Forms.MouseEventHandler(this.band9TrackBar_MouseUp);
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(447, 280);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 63;
            this.label9.Text = "62";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Location = new System.Drawing.Point(480, 280);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 13);
            this.label10.TabIndex = 64;
            this.label10.Text = "125";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label11
            // 
            this.label11.Location = new System.Drawing.Point(513, 280);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 13);
            this.label11.TabIndex = 65;
            this.label11.Text = "250";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label12
            // 
            this.label12.Location = new System.Drawing.Point(541, 280);
            this.label12.Margin = new System.Windows.Forms.Padding(0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(35, 13);
            this.label12.TabIndex = 66;
            this.label12.Text = "500";
            this.label12.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label13
            // 
            this.label13.Location = new System.Drawing.Point(576, 280);
            this.label13.Margin = new System.Windows.Forms.Padding(0);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(35, 13);
            this.label13.TabIndex = 67;
            this.label13.Text = "1K";
            this.label13.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label14
            // 
            this.label14.Location = new System.Drawing.Point(609, 280);
            this.label14.Margin = new System.Windows.Forms.Padding(0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(35, 13);
            this.label14.TabIndex = 68;
            this.label14.Text = "2K";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label15
            // 
            this.label15.Location = new System.Drawing.Point(642, 280);
            this.label15.Margin = new System.Windows.Forms.Padding(0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(35, 13);
            this.label15.TabIndex = 69;
            this.label15.Text = "4K";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label16
            // 
            this.label16.Location = new System.Drawing.Point(672, 280);
            this.label16.Margin = new System.Windows.Forms.Padding(0);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(42, 13);
            this.label16.TabIndex = 70;
            this.label16.Text = "8K";
            this.label16.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label17
            // 
            this.label17.Location = new System.Drawing.Point(378, 17);
            this.label17.Margin = new System.Windows.Forms.Padding(0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(35, 13);
            this.label17.TabIndex = 71;
            this.label17.Text = "12 db";
            this.label17.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label18
            // 
            this.label18.Location = new System.Drawing.Point(708, 280);
            this.label18.Margin = new System.Windows.Forms.Padding(0);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(42, 13);
            this.label18.TabIndex = 72;
            this.label18.Text = "16K";
            this.label18.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label19
            // 
            this.label19.Location = new System.Drawing.Point(376, 264);
            this.label19.Margin = new System.Windows.Forms.Padding(0);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(37, 13);
            this.label19.TabIndex = 73;
            this.label19.Text = "-12 db";
            this.label19.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label20
            // 
            this.label20.Location = new System.Drawing.Point(381, 137);
            this.label20.Margin = new System.Windows.Forms.Padding(0);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(32, 13);
            this.label20.TabIndex = 74;
            this.label20.Text = "0 db";
            this.label20.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // resetEqualizerButton
            // 
            this.resetEqualizerButton.BackColor = System.Drawing.Color.Transparent;
            this.resetEqualizerButton.CausesValidation = false;
            this.resetEqualizerButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.resetEqualizerButton.FlatAppearance.BorderSize = 2;
            this.resetEqualizerButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.resetEqualizerButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.resetEqualizerButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.resetEqualizerButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.resetEqualizerButton.ForeColor = System.Drawing.Color.Black;
            this.resetEqualizerButton.Location = new System.Drawing.Point(532, 312);
            this.resetEqualizerButton.Name = "resetEqualizerButton";
            this.resetEqualizerButton.Size = new System.Drawing.Size(82, 31);
            this.resetEqualizerButton.TabIndex = 75;
            this.resetEqualizerButton.TabStop = false;
            this.resetEqualizerButton.Text = "Сбросить";
            this.resetEqualizerButton.UseVisualStyleBackColor = false;
            this.resetEqualizerButton.Click += new System.EventHandler(this.resetEqualizerButton_Click);
            // 
            // EffectsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.resetEqualizerButton);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.band10TrackBar);
            this.Controls.Add(this.band9TrackBar);
            this.Controls.Add(this.band8TrackBar);
            this.Controls.Add(this.band7TrackBar);
            this.Controls.Add(this.band6TrackBar);
            this.Controls.Add(this.band5TrackBar);
            this.Controls.Add(this.band4TrackBar);
            this.Controls.Add(this.band3TrackBar);
            this.Controls.Add(this.band2TrackBar);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.band1TrackBar);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.maxDurLabel);
            this.Controls.Add(this.minDurLabel);
            this.Controls.Add(this.loopRangeBar);
            this.Controls.Add(this.LoopLabel);
            this.Controls.Add(this.tempValueLabel);
            this.Controls.Add(this.plusTempButton);
            this.Controls.Add(this.minusTempButton);
            this.Controls.Add(this.tempLabel);
            this.Controls.Add(this.tempTrackBar);
            this.Controls.Add(this.pitchValueLabel);
            this.Controls.Add(this.plusPitchButton);
            this.Controls.Add(this.minusPitchButton);
            this.Controls.Add(this.pitchLabel);
            this.Controls.Add(this.pitchTrackBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EffectsWindow";
            this.Text = "EffectsWindow";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public XComponent.SliderBar.MACTrackBar pitchTrackBar;
        public System.Windows.Forms.Label pitchLabel;
        public System.Windows.Forms.Button minusPitchButton;
        public System.Windows.Forms.Button plusPitchButton;
        public System.Windows.Forms.Label pitchValueLabel;
        public System.Windows.Forms.Label tempValueLabel;
        public System.Windows.Forms.Button plusTempButton;
        public System.Windows.Forms.Button minusTempButton;
        public System.Windows.Forms.Label tempLabel;
        public XComponent.SliderBar.MACTrackBar tempTrackBar;
        public System.Windows.Forms.Label maxDurLabel;
        public System.Windows.Forms.Label minDurLabel;
        public System.Windows.Forms.Label LoopLabel;
        private System.Windows.Forms.Button resetButton;
        public Zzzz.ZzzzRangeBar loopRangeBar;
        public XComponent.SliderBar.MACTrackBar band1TrackBar;
        public System.Windows.Forms.Label label1;
        public XComponent.SliderBar.MACTrackBar band2TrackBar;
        public XComponent.SliderBar.MACTrackBar band3TrackBar;
        public XComponent.SliderBar.MACTrackBar band4TrackBar;
        public XComponent.SliderBar.MACTrackBar band8TrackBar;
        public XComponent.SliderBar.MACTrackBar band7TrackBar;
        public XComponent.SliderBar.MACTrackBar band6TrackBar;
        public XComponent.SliderBar.MACTrackBar band5TrackBar;
        public XComponent.SliderBar.MACTrackBar band10TrackBar;
        public XComponent.SliderBar.MACTrackBar band9TrackBar;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        public System.Windows.Forms.Label label11;
        public System.Windows.Forms.Label label12;
        public System.Windows.Forms.Label label13;
        public System.Windows.Forms.Label label14;
        public System.Windows.Forms.Label label15;
        public System.Windows.Forms.Label label16;
        public System.Windows.Forms.Label label17;
        public System.Windows.Forms.Label label18;
        public System.Windows.Forms.Label label19;
        public System.Windows.Forms.Label label20;
        private System.Windows.Forms.Button resetEqualizerButton;
    }
}