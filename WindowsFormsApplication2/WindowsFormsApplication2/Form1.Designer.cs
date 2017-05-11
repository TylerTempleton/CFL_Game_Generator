namespace WindowsFormsApplication2
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.teamBox = new System.Windows.Forms.GroupBox();
            this.eastTeams = new System.Windows.Forms.GroupBox();
            this.eastTeam4 = new System.Windows.Forms.RadioButton();
            this.eastTeam3 = new System.Windows.Forms.RadioButton();
            this.eastTeam2 = new System.Windows.Forms.RadioButton();
            this.eastTeam1 = new System.Windows.Forms.RadioButton();
            this.westTeams = new System.Windows.Forms.GroupBox();
            this.westTeam5 = new System.Windows.Forms.RadioButton();
            this.westTeam4 = new System.Windows.Forms.RadioButton();
            this.westTeam3 = new System.Windows.Forms.RadioButton();
            this.westTeam2 = new System.Windows.Forms.RadioButton();
            this.westTeam1 = new System.Windows.Forms.RadioButton();
            this.resetButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.playCenter = new System.Windows.Forms.GroupBox();
            this.flagBox2 = new System.Windows.Forms.PictureBox();
            this.flagBox1 = new System.Windows.Forms.PictureBox();
            this.winnerText = new System.Windows.Forms.Label();
            this.finalResultLabel = new System.Windows.Forms.Label();
            this.teamScore2 = new System.Windows.Forms.TextBox();
            this.teamScore1 = new System.Windows.Forms.TextBox();
            this.playButton = new System.Windows.Forms.Button();
            this.team2Label = new System.Windows.Forms.Label();
            this.vsLabel = new System.Windows.Forms.Label();
            this.team1Label = new System.Windows.Forms.Label();
            this.teamBox.SuspendLayout();
            this.eastTeams.SuspendLayout();
            this.westTeams.SuspendLayout();
            this.playCenter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flagBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flagBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // teamBox
            // 
            this.teamBox.Controls.Add(this.eastTeams);
            this.teamBox.Controls.Add(this.westTeams);
            this.teamBox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamBox.Location = new System.Drawing.Point(31, 41);
            this.teamBox.Name = "teamBox";
            this.teamBox.Size = new System.Drawing.Size(238, 214);
            this.teamBox.TabIndex = 0;
            this.teamBox.TabStop = false;
            this.teamBox.Text = "Select Teams";
            // 
            // eastTeams
            // 
            this.eastTeams.Controls.Add(this.eastTeam4);
            this.eastTeams.Controls.Add(this.eastTeam3);
            this.eastTeams.Controls.Add(this.eastTeam2);
            this.eastTeams.Controls.Add(this.eastTeam1);
            this.eastTeams.Location = new System.Drawing.Point(123, 32);
            this.eastTeams.Name = "eastTeams";
            this.eastTeams.Size = new System.Drawing.Size(109, 158);
            this.eastTeams.TabIndex = 1;
            this.eastTeams.TabStop = false;
            this.eastTeams.Text = "East";
            // 
            // eastTeam4
            // 
            this.eastTeam4.AutoSize = true;
            this.eastTeam4.Location = new System.Drawing.Point(7, 91);
            this.eastTeam4.Name = "eastTeam4";
            this.eastTeam4.Size = new System.Drawing.Size(92, 18);
            this.eastTeam4.TabIndex = 3;
            this.eastTeam4.TabStop = true;
            this.eastTeam4.Text = "Argonauts";
            this.eastTeam4.UseVisualStyleBackColor = true;
            this.eastTeam4.CheckedChanged += new System.EventHandler(this.eastTeam4_CheckedChanged);
            // 
            // eastTeam3
            // 
            this.eastTeam3.AutoSize = true;
            this.eastTeam3.Location = new System.Drawing.Point(7, 68);
            this.eastTeam3.Name = "eastTeam3";
            this.eastTeam3.Size = new System.Drawing.Size(92, 18);
            this.eastTeam3.TabIndex = 2;
            this.eastTeam3.TabStop = true;
            this.eastTeam3.Text = "Redblacks";
            this.eastTeam3.UseVisualStyleBackColor = true;
            this.eastTeam3.CheckedChanged += new System.EventHandler(this.eastTeam3_CheckedChanged);
            // 
            // eastTeam2
            // 
            this.eastTeam2.AutoSize = true;
            this.eastTeam2.Location = new System.Drawing.Point(7, 44);
            this.eastTeam2.Name = "eastTeam2";
            this.eastTeam2.Size = new System.Drawing.Size(87, 18);
            this.eastTeam2.TabIndex = 1;
            this.eastTeam2.TabStop = true;
            this.eastTeam2.Text = "Alouettes";
            this.eastTeam2.UseVisualStyleBackColor = true;
            this.eastTeam2.CheckedChanged += new System.EventHandler(this.eastTeam2_CheckedChanged);
            // 
            // eastTeam1
            // 
            this.eastTeam1.AutoSize = true;
            this.eastTeam1.Location = new System.Drawing.Point(6, 19);
            this.eastTeam1.Name = "eastTeam1";
            this.eastTeam1.Size = new System.Drawing.Size(92, 18);
            this.eastTeam1.TabIndex = 0;
            this.eastTeam1.TabStop = true;
            this.eastTeam1.Text = "Tiger Cats";
            this.eastTeam1.UseVisualStyleBackColor = true;
            this.eastTeam1.CheckedChanged += new System.EventHandler(this.eastTeam1_CheckedChanged);
            // 
            // westTeams
            // 
            this.westTeams.Controls.Add(this.westTeam5);
            this.westTeams.Controls.Add(this.westTeam4);
            this.westTeams.Controls.Add(this.westTeam3);
            this.westTeams.Controls.Add(this.westTeam2);
            this.westTeams.Controls.Add(this.westTeam1);
            this.westTeams.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.westTeams.Location = new System.Drawing.Point(10, 31);
            this.westTeams.Name = "westTeams";
            this.westTeams.Size = new System.Drawing.Size(107, 159);
            this.westTeams.TabIndex = 0;
            this.westTeams.TabStop = false;
            this.westTeams.Text = "West";
            // 
            // westTeam5
            // 
            this.westTeam5.AutoSize = true;
            this.westTeam5.Location = new System.Drawing.Point(7, 116);
            this.westTeam5.Name = "westTeam5";
            this.westTeam5.Size = new System.Drawing.Size(105, 18);
            this.westTeam5.TabIndex = 4;
            this.westTeam5.TabStop = true;
            this.westTeam5.Text = "Roughriders";
            this.westTeam5.UseVisualStyleBackColor = true;
            this.westTeam5.CheckedChanged += new System.EventHandler(this.westTeam5_CheckedChanged);
            // 
            // westTeam4
            // 
            this.westTeam4.AutoSize = true;
            this.westTeam4.Location = new System.Drawing.Point(7, 92);
            this.westTeam4.Name = "westTeam4";
            this.westTeam4.Size = new System.Drawing.Size(116, 18);
            this.westTeam4.TabIndex = 3;
            this.westTeam4.TabStop = true;
            this.westTeam4.Text = "Blue Bombers";
            this.westTeam4.UseVisualStyleBackColor = true;
            this.westTeam4.CheckedChanged += new System.EventHandler(this.westTeam4_CheckedChanged);
            // 
            // westTeam3
            // 
            this.westTeam3.AutoSize = true;
            this.westTeam3.Location = new System.Drawing.Point(7, 68);
            this.westTeam3.Name = "westTeam3";
            this.westTeam3.Size = new System.Drawing.Size(79, 18);
            this.westTeam3.TabIndex = 2;
            this.westTeam3.TabStop = true;
            this.westTeam3.Text = "Eskimos";
            this.westTeam3.UseVisualStyleBackColor = true;
            this.westTeam3.CheckedChanged += new System.EventHandler(this.westTeam3_CheckedChanged);
            // 
            // westTeam2
            // 
            this.westTeam2.AutoSize = true;
            this.westTeam2.Location = new System.Drawing.Point(7, 44);
            this.westTeam2.Name = "westTeam2";
            this.westTeam2.Size = new System.Drawing.Size(104, 18);
            this.westTeam2.TabIndex = 1;
            this.westTeam2.TabStop = true;
            this.westTeam2.Text = "Stampeders";
            this.westTeam2.UseVisualStyleBackColor = true;
            this.westTeam2.CheckedChanged += new System.EventHandler(this.WestTeam2_CheckedChanged);
            // 
            // westTeam1
            // 
            this.westTeam1.AutoSize = true;
            this.westTeam1.Location = new System.Drawing.Point(7, 20);
            this.westTeam1.Name = "westTeam1";
            this.westTeam1.Size = new System.Drawing.Size(60, 18);
            this.westTeam1.TabIndex = 1;
            this.westTeam1.TabStop = true;
            this.westTeam1.Text = "Lions";
            this.westTeam1.UseVisualStyleBackColor = true;
            this.westTeam1.CheckedChanged += new System.EventHandler(this.westTeam1_CheckedChanged);
            // 
            // resetButton
            // 
            this.resetButton.Location = new System.Drawing.Point(48, 328);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(75, 23);
            this.resetButton.TabIndex = 1;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = true;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(146, 328);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(75, 23);
            this.exitButton.TabIndex = 0;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // playCenter
            // 
            this.playCenter.Controls.Add(this.flagBox2);
            this.playCenter.Controls.Add(this.flagBox1);
            this.playCenter.Controls.Add(this.winnerText);
            this.playCenter.Controls.Add(this.finalResultLabel);
            this.playCenter.Controls.Add(this.teamScore2);
            this.playCenter.Controls.Add(this.teamScore1);
            this.playCenter.Controls.Add(this.playButton);
            this.playCenter.Controls.Add(this.team2Label);
            this.playCenter.Controls.Add(this.vsLabel);
            this.playCenter.Controls.Add(this.team1Label);
            this.playCenter.Font = new System.Drawing.Font("Lucida Sans", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playCenter.Location = new System.Drawing.Point(275, 41);
            this.playCenter.Name = "playCenter";
            this.playCenter.Size = new System.Drawing.Size(487, 310);
            this.playCenter.TabIndex = 3;
            this.playCenter.TabStop = false;
            this.playCenter.Text = "Match";
            // 
            // flagBox2
            // 
            this.flagBox2.Location = new System.Drawing.Point(298, 72);
            this.flagBox2.Name = "flagBox2";
            this.flagBox2.Size = new System.Drawing.Size(148, 103);
            this.flagBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flagBox2.TabIndex = 9;
            this.flagBox2.TabStop = false;
            // 
            // flagBox1
            // 
            this.flagBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("flagBox1.InitialImage")));
            this.flagBox1.Location = new System.Drawing.Point(30, 72);
            this.flagBox1.Name = "flagBox1";
            this.flagBox1.Size = new System.Drawing.Size(135, 103);
            this.flagBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.flagBox1.TabIndex = 8;
            this.flagBox1.TabStop = false;
            // 
            // winnerText
            // 
            this.winnerText.AutoSize = true;
            this.winnerText.Location = new System.Drawing.Point(177, 256);
            this.winnerText.Name = "winnerText";
            this.winnerText.Size = new System.Drawing.Size(106, 18);
            this.winnerText.TabIndex = 7;
            this.winnerText.Text = "Winner Here";
            // 
            // finalResultLabel
            // 
            this.finalResultLabel.AutoSize = true;
            this.finalResultLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finalResultLabel.Location = new System.Drawing.Point(176, 184);
            this.finalResultLabel.Name = "finalResultLabel";
            this.finalResultLabel.Size = new System.Drawing.Size(105, 20);
            this.finalResultLabel.TabIndex = 6;
            this.finalResultLabel.Text = "Final Result";
            // 
            // teamScore2
            // 
            this.teamScore2.Enabled = false;
            this.teamScore2.Location = new System.Drawing.Point(347, 206);
            this.teamScore2.Name = "teamScore2";
            this.teamScore2.Size = new System.Drawing.Size(100, 26);
            this.teamScore2.TabIndex = 5;
            // 
            // teamScore1
            // 
            this.teamScore1.Enabled = false;
            this.teamScore1.Location = new System.Drawing.Point(30, 206);
            this.teamScore1.Name = "teamScore1";
            this.teamScore1.Size = new System.Drawing.Size(100, 26);
            this.teamScore1.TabIndex = 4;
            // 
            // playButton
            // 
            this.playButton.Enabled = false;
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(194, 123);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(75, 23);
            this.playButton.TabIndex = 3;
            this.playButton.Text = "Play";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // team2Label
            // 
            this.team2Label.AutoSize = true;
            this.team2Label.Location = new System.Drawing.Point(344, 32);
            this.team2Label.Name = "team2Label";
            this.team2Label.Size = new System.Drawing.Size(62, 18);
            this.team2Label.TabIndex = 2;
            this.team2Label.Text = "Team2";
            // 
            // vsLabel
            // 
            this.vsLabel.AutoSize = true;
            this.vsLabel.Location = new System.Drawing.Point(220, 32);
            this.vsLabel.Name = "vsLabel";
            this.vsLabel.Size = new System.Drawing.Size(29, 18);
            this.vsLabel.TabIndex = 1;
            this.vsLabel.Text = "VS";
            // 
            // team1Label
            // 
            this.team1Label.AutoSize = true;
            this.team1Label.Location = new System.Drawing.Point(52, 32);
            this.team1Label.Name = "team1Label";
            this.team1Label.Size = new System.Drawing.Size(67, 18);
            this.team1Label.TabIndex = 0;
            this.team1Label.Text = "Team 1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.ClientSize = new System.Drawing.Size(791, 383);
            this.Controls.Add(this.playCenter);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.teamBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "CFL Game Simulator";
            this.teamBox.ResumeLayout(false);
            this.eastTeams.ResumeLayout(false);
            this.eastTeams.PerformLayout();
            this.westTeams.ResumeLayout(false);
            this.westTeams.PerformLayout();
            this.playCenter.ResumeLayout(false);
            this.playCenter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flagBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flagBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox teamBox;
        private System.Windows.Forms.GroupBox eastTeams;
        private System.Windows.Forms.GroupBox westTeams;
        private System.Windows.Forms.RadioButton eastTeam4;
        private System.Windows.Forms.RadioButton eastTeam3;
        private System.Windows.Forms.RadioButton eastTeam2;
        private System.Windows.Forms.RadioButton eastTeam1;
        private System.Windows.Forms.RadioButton westTeam5;
        private System.Windows.Forms.RadioButton westTeam4;
        private System.Windows.Forms.RadioButton westTeam3;
        private System.Windows.Forms.RadioButton westTeam2;
        private System.Windows.Forms.RadioButton westTeam1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.GroupBox playCenter;
        private System.Windows.Forms.PictureBox flagBox2;
        private System.Windows.Forms.PictureBox flagBox1;
        private System.Windows.Forms.Label winnerText;
        private System.Windows.Forms.Label finalResultLabel;
        private System.Windows.Forms.TextBox teamScore2;
        private System.Windows.Forms.TextBox teamScore1;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label team2Label;
        private System.Windows.Forms.Label vsLabel;
        private System.Windows.Forms.Label team1Label;
    }
}

