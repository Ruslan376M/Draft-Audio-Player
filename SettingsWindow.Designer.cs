namespace Music_Speed_And_Pitch_Changer
{
    partial class SettingsWindow
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
            this.choosePathButton = new System.Windows.Forms.Button();
            this.folderLabel = new System.Windows.Forms.Label();
            this.infoLabel = new System.Windows.Forms.Label();
            this.themeLabel = new System.Windows.Forms.Label();
            this.currentThemeComboBox = new System.Windows.Forms.ComboBox();
            this.colorsComboBox = new System.Windows.Forms.ComboBox();
            this.accentLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // choosePathButton
            // 
            this.choosePathButton.BackColor = System.Drawing.Color.Transparent;
            this.choosePathButton.CausesValidation = false;
            this.choosePathButton.FlatAppearance.BorderColor = System.Drawing.Color.Gray;
            this.choosePathButton.FlatAppearance.BorderSize = 2;
            this.choosePathButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.choosePathButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.choosePathButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choosePathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.choosePathButton.ForeColor = System.Drawing.Color.Black;
            this.choosePathButton.Location = new System.Drawing.Point(7, 47);
            this.choosePathButton.Name = "choosePathButton";
            this.choosePathButton.Size = new System.Drawing.Size(118, 31);
            this.choosePathButton.TabIndex = 17;
            this.choosePathButton.TabStop = false;
            this.choosePathButton.Text = "Выбрать папку";
            this.choosePathButton.UseVisualStyleBackColor = false;
            this.choosePathButton.Click += new System.EventHandler(this.choosePathButton_Click);
            // 
            // folderLabel
            // 
            this.folderLabel.BackColor = System.Drawing.Color.Transparent;
            this.folderLabel.CausesValidation = false;
            this.folderLabel.Enabled = false;
            this.folderLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.folderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.folderLabel.ForeColor = System.Drawing.Color.Black;
            this.folderLabel.Location = new System.Drawing.Point(198, 0);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(365, 44);
            this.folderLabel.TabIndex = 16;
            this.folderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // infoLabel
            // 
            this.infoLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel.CausesValidation = false;
            this.infoLabel.Enabled = false;
            this.infoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.Black;
            this.infoLabel.Location = new System.Drawing.Point(2, 0);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(190, 44);
            this.infoLabel.TabIndex = 15;
            this.infoLabel.Text = "Папка с музыкой:";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // themeLabel
            // 
            this.themeLabel.BackColor = System.Drawing.Color.Transparent;
            this.themeLabel.CausesValidation = false;
            this.themeLabel.Enabled = false;
            this.themeLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.themeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.themeLabel.ForeColor = System.Drawing.Color.Black;
            this.themeLabel.Location = new System.Drawing.Point(2, 93);
            this.themeLabel.Name = "themeLabel";
            this.themeLabel.Size = new System.Drawing.Size(96, 44);
            this.themeLabel.TabIndex = 18;
            this.themeLabel.Text = "Тема: ";
            this.themeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // currentThemeComboBox
            // 
            this.currentThemeComboBox.CausesValidation = false;
            this.currentThemeComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.currentThemeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.currentThemeComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.currentThemeComboBox.FormattingEnabled = true;
            this.currentThemeComboBox.Items.AddRange(new object[] {
            "Светлая",
            "Тёмная"});
            this.currentThemeComboBox.Location = new System.Drawing.Point(93, 100);
            this.currentThemeComboBox.Name = "currentThemeComboBox";
            this.currentThemeComboBox.Size = new System.Drawing.Size(210, 33);
            this.currentThemeComboBox.Sorted = true;
            this.currentThemeComboBox.TabIndex = 19;
            this.currentThemeComboBox.TabStop = false;
            this.currentThemeComboBox.SelectedIndexChanged += new System.EventHandler(this.currentThemeComboBox_SelectedIndexChanged);
            // 
            // colorsComboBox
            // 
            this.colorsComboBox.CausesValidation = false;
            this.colorsComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.colorsComboBox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.colorsComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.colorsComboBox.Items.AddRange(new object[] {
            "Голубой",
            "Жёлтый",
            "Зелёный",
            "Красный",
            "Оранжевый",
            "Розовый",
            "Синий",
            "Фиолетовый"});
            this.colorsComboBox.Location = new System.Drawing.Point(93, 144);
            this.colorsComboBox.Name = "colorsComboBox";
            this.colorsComboBox.Size = new System.Drawing.Size(210, 33);
            this.colorsComboBox.Sorted = true;
            this.colorsComboBox.TabIndex = 21;
            this.colorsComboBox.TabStop = false;
            this.colorsComboBox.SelectedIndexChanged += new System.EventHandler(this.colorsComboBox_SelectedIndexChanged);
            // 
            // accentLabel
            // 
            this.accentLabel.BackColor = System.Drawing.Color.Transparent;
            this.accentLabel.CausesValidation = false;
            this.accentLabel.Enabled = false;
            this.accentLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.accentLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accentLabel.ForeColor = System.Drawing.Color.Black;
            this.accentLabel.Location = new System.Drawing.Point(2, 137);
            this.accentLabel.Name = "accentLabel";
            this.accentLabel.Size = new System.Drawing.Size(96, 44);
            this.accentLabel.TabIndex = 20;
            this.accentLabel.Text = "Акцент:";
            this.accentLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SettingsWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.colorsComboBox);
            this.Controls.Add(this.accentLabel);
            this.Controls.Add(this.currentThemeComboBox);
            this.Controls.Add(this.themeLabel);
            this.Controls.Add(this.choosePathButton);
            this.Controls.Add(this.folderLabel);
            this.Controls.Add(this.infoLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsWindow";
            this.Text = "SettingsWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button choosePathButton;
        private System.Windows.Forms.Label folderLabel;
        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label themeLabel;
        private System.Windows.Forms.ComboBox currentThemeComboBox;
        private System.Windows.Forms.ComboBox colorsComboBox;
        private System.Windows.Forms.Label accentLabel;
    }
}