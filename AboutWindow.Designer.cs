namespace Music_Speed_And_Pitch_Changer
{
    partial class AboutWindow
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
            this.listOfDevelopersLabel = new System.Windows.Forms.Label();
            this.developersLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listOfDevelopersLabel
            // 
            this.listOfDevelopersLabel.BackColor = System.Drawing.Color.Transparent;
            this.listOfDevelopersLabel.CausesValidation = false;
            this.listOfDevelopersLabel.Enabled = false;
            this.listOfDevelopersLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.listOfDevelopersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listOfDevelopersLabel.ForeColor = System.Drawing.Color.Black;
            this.listOfDevelopersLabel.Location = new System.Drawing.Point(12, 58);
            this.listOfDevelopersLabel.Name = "listOfDevelopersLabel";
            this.listOfDevelopersLabel.Size = new System.Drawing.Size(447, 309);
            this.listOfDevelopersLabel.TabIndex = 24;
            this.listOfDevelopersLabel.Text = "Вальшин Руслан:  vk.com/ruslan_376\r\nРапиев Ильдар:  vk.com/id142840387\r\nСафронов " +
    "Иван:  vk.com/safronovvanya\r\nХусамов Альберт:  vk.com/albertkhusamov";
            // 
            // developersLabel
            // 
            this.developersLabel.BackColor = System.Drawing.Color.Transparent;
            this.developersLabel.CausesValidation = false;
            this.developersLabel.Enabled = false;
            this.developersLabel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.developersLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developersLabel.ForeColor = System.Drawing.Color.Black;
            this.developersLabel.Location = new System.Drawing.Point(12, 14);
            this.developersLabel.Name = "developersLabel";
            this.developersLabel.Size = new System.Drawing.Size(267, 44);
            this.developersLabel.TabIndex = 23;
            this.developersLabel.Text = "Разработчики:";
            this.developersLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // AboutWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listOfDevelopersLabel);
            this.Controls.Add(this.developersLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AboutWindow";
            this.Text = "AboutWindow";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label listOfDevelopersLabel;
        private System.Windows.Forms.Label developersLabel;
    }
}