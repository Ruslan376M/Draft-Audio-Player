namespace Draft_Audio_Player_New_Design
{
    partial class SettingsForm
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
            this.infoLabel = new System.Windows.Forms.Label();
            this.folderLabel = new System.Windows.Forms.Label();
            this.choosePathButton = new System.Windows.Forms.Button();
            this.musicFolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.SuspendLayout();
            // 
            // infoLabel
            // 
            this.infoLabel.BackColor = System.Drawing.Color.Transparent;
            this.infoLabel.CausesValidation = false;
            this.infoLabel.Enabled = false;
            this.infoLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.infoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.infoLabel.ForeColor = System.Drawing.Color.White;
            this.infoLabel.Location = new System.Drawing.Point(12, 9);
            this.infoLabel.Name = "infoLabel";
            this.infoLabel.Size = new System.Drawing.Size(190, 44);
            this.infoLabel.TabIndex = 5;
            this.infoLabel.Text = "Папка с музыкой:";
            this.infoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // folderLabel
            // 
            this.folderLabel.BackColor = System.Drawing.Color.Transparent;
            this.folderLabel.CausesValidation = false;
            this.folderLabel.Enabled = false;
            this.folderLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.folderLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.folderLabel.ForeColor = System.Drawing.Color.White;
            this.folderLabel.Location = new System.Drawing.Point(208, 9);
            this.folderLabel.Name = "folderLabel";
            this.folderLabel.Size = new System.Drawing.Size(365, 44);
            this.folderLabel.TabIndex = 6;
            this.folderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
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
            this.choosePathButton.ForeColor = System.Drawing.Color.Transparent;
            this.choosePathButton.Location = new System.Drawing.Point(17, 56);
            this.choosePathButton.Name = "choosePathButton";
            this.choosePathButton.Size = new System.Drawing.Size(118, 31);
            this.choosePathButton.TabIndex = 14;
            this.choosePathButton.TabStop = false;
            this.choosePathButton.Text = "Выбрать папку";
            this.choosePathButton.UseVisualStyleBackColor = false;
            this.choosePathButton.Click += new System.EventHandler(this.choosePathButton_Click);
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.choosePathButton);
            this.Controls.Add(this.folderLabel);
            this.Controls.Add(this.infoLabel);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SettingsForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label infoLabel;
        private System.Windows.Forms.Label folderLabel;
        private System.Windows.Forms.Button choosePathButton;
        private System.Windows.Forms.FolderBrowserDialog musicFolderBrowserDialog;
    }
}