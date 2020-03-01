namespace Draft_Audio_Player_New_Design
{
    partial class MusicListForm
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
            this.allMusicButton = new System.Windows.Forms.Button();
            this.playListsButton = new System.Windows.Forms.Button();
            this.albumsButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // allMusicButton
            // 
            this.allMusicButton.BackColor = System.Drawing.Color.Transparent;
            this.allMusicButton.CausesValidation = false;
            this.allMusicButton.FlatAppearance.BorderSize = 0;
            this.allMusicButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.allMusicButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.allMusicButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allMusicButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.allMusicButton.ForeColor = System.Drawing.Color.Transparent;
            this.allMusicButton.Location = new System.Drawing.Point(12, 12);
            this.allMusicButton.Name = "allMusicButton";
            this.allMusicButton.Size = new System.Drawing.Size(104, 31);
            this.allMusicButton.TabIndex = 14;
            this.allMusicButton.TabStop = false;
            this.allMusicButton.Text = "Вся музыка";
            this.allMusicButton.UseVisualStyleBackColor = false;
            // 
            // playListsButton
            // 
            this.playListsButton.BackColor = System.Drawing.Color.Transparent;
            this.playListsButton.CausesValidation = false;
            this.playListsButton.FlatAppearance.BorderSize = 0;
            this.playListsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.playListsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.playListsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playListsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.playListsButton.ForeColor = System.Drawing.Color.Transparent;
            this.playListsButton.Location = new System.Drawing.Point(122, 12);
            this.playListsButton.Name = "playListsButton";
            this.playListsButton.Size = new System.Drawing.Size(104, 31);
            this.playListsButton.TabIndex = 15;
            this.playListsButton.TabStop = false;
            this.playListsButton.Text = "Плейлисты";
            this.playListsButton.UseVisualStyleBackColor = false;
            // 
            // albumsButton
            // 
            this.albumsButton.BackColor = System.Drawing.Color.Transparent;
            this.albumsButton.CausesValidation = false;
            this.albumsButton.FlatAppearance.BorderSize = 0;
            this.albumsButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.albumsButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.SteelBlue;
            this.albumsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.albumsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.albumsButton.ForeColor = System.Drawing.Color.Transparent;
            this.albumsButton.Location = new System.Drawing.Point(232, 12);
            this.albumsButton.Name = "albumsButton";
            this.albumsButton.Size = new System.Drawing.Size(104, 31);
            this.albumsButton.TabIndex = 16;
            this.albumsButton.TabStop = false;
            this.albumsButton.Text = "Альбомы";
            this.albumsButton.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.checkBox1);
            this.panel1.Location = new System.Drawing.Point(28, 90);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 46);
            this.panel1.TabIndex = 17;
            // 
            // checkBox1
            // 
            this.checkBox1.BackColor = System.Drawing.Color.Transparent;
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBox1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.checkBox1.FlatAppearance.BorderSize = 5;
            this.checkBox1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.checkBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.checkBox1.Location = new System.Drawing.Point(3, 3);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(40, 40);
            this.checkBox1.TabIndex = 0;
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // MusicListForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.albumsButton);
            this.Controls.Add(this.playListsButton);
            this.Controls.Add(this.allMusicButton);
            this.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MusicListForm";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button allMusicButton;
        private System.Windows.Forms.Button playListsButton;
        private System.Windows.Forms.Button albumsButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}