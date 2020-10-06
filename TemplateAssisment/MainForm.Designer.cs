namespace TemplateAssisment
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.GunShootButton = new System.Windows.Forms.Button();
            this.ShootAwayButton = new System.Windows.Forms.Button();
            this.ScoreNumber = new System.Windows.Forms.Label();
            this.Score = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.SpinButton = new System.Windows.Forms.Button();
            this.ReloadRevolver = new System.Windows.Forms.Button();
            this.QuitGame = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // GunShootButton
            // 
            this.GunShootButton.Location = new System.Drawing.Point(639, 264);
            this.GunShootButton.Name = "GunShootButton";
            this.GunShootButton.Size = new System.Drawing.Size(149, 47);
            this.GunShootButton.TabIndex = 1;
            this.GunShootButton.Text = "Shoot At Head";
            this.GunShootButton.UseVisualStyleBackColor = true;
            this.GunShootButton.Click += new System.EventHandler(this.GunShootButton_Click);
            // 
            // ShootAwayButton
            // 
            this.ShootAwayButton.Location = new System.Drawing.Point(639, 139);
            this.ShootAwayButton.Name = "ShootAwayButton";
            this.ShootAwayButton.Size = new System.Drawing.Size(149, 41);
            this.ShootAwayButton.TabIndex = 2;
            this.ShootAwayButton.Text = "Shoot Away";
            this.ShootAwayButton.UseVisualStyleBackColor = true;
            this.ShootAwayButton.Click += new System.EventHandler(this.ShootAwayButton_Click);
            // 
            // ScoreNumber
            // 
            this.ScoreNumber.AutoSize = true;
            this.ScoreNumber.Location = new System.Drawing.Point(685, 33);
            this.ScoreNumber.Name = "ScoreNumber";
            this.ScoreNumber.Size = new System.Drawing.Size(45, 17);
            this.ScoreNumber.TabIndex = 3;
            this.ScoreNumber.Text = "Score";
            this.ScoreNumber.Click += new System.EventHandler(this.label1_Click);
            // 
            // Score
            // 
            this.Score.Location = new System.Drawing.Point(688, 53);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(100, 22);
            this.Score.TabIndex = 4;
            this.Score.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-7, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(811, 450);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // SpinButton
            // 
            this.SpinButton.Location = new System.Drawing.Point(639, 202);
            this.SpinButton.Name = "SpinButton";
            this.SpinButton.Size = new System.Drawing.Size(149, 43);
            this.SpinButton.TabIndex = 8;
            this.SpinButton.Text = "Spin";
            this.SpinButton.UseVisualStyleBackColor = true;
            this.SpinButton.Click += new System.EventHandler(this.SpinButton_Click);
            // 
            // ReloadRevolver
            // 
            this.ReloadRevolver.Location = new System.Drawing.Point(639, 327);
            this.ReloadRevolver.Name = "ReloadRevolver";
            this.ReloadRevolver.Size = new System.Drawing.Size(149, 48);
            this.ReloadRevolver.TabIndex = 9;
            this.ReloadRevolver.Text = "Reload Revolver";
            this.ReloadRevolver.UseVisualStyleBackColor = true;
            this.ReloadRevolver.Click += new System.EventHandler(this.ReloadRevolver_Click);
            // 
            // QuitGame
            // 
            this.QuitGame.Location = new System.Drawing.Point(639, 394);
            this.QuitGame.Name = "QuitGame";
            this.QuitGame.Size = new System.Drawing.Size(149, 44);
            this.QuitGame.TabIndex = 10;
            this.QuitGame.Text = "Quit Game";
            this.QuitGame.UseVisualStyleBackColor = true;
            this.QuitGame.Click += new System.EventHandler(this.QuitGame_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.QuitGame);
            this.Controls.Add(this.ReloadRevolver);
            this.Controls.Add(this.SpinButton);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.ScoreNumber);
            this.Controls.Add(this.ShootAwayButton);
            this.Controls.Add(this.GunShootButton);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Main Form";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button GunShootButton;
        private System.Windows.Forms.Button ShootAwayButton;
        private System.Windows.Forms.Label ScoreNumber;
        private System.Windows.Forms.TextBox Score;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button SpinButton;
        private System.Windows.Forms.Button ReloadRevolver;
        private System.Windows.Forms.Button QuitGame;
    }
}

