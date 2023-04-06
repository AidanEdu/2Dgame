namespace WorldsHardestGame
{
    partial class MenuScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.playButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.scoreLabel = new System.Windows.Forms.Label();
            this.scoreButtonLabel = new System.Windows.Forms.Button();
            this.backLabel = new System.Windows.Forms.Button();
            this.scoreInfoLabel = new System.Windows.Forms.Label();
            this.xLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Impact", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(84, 75);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(636, 80);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "WORLDS HARDEST GAME";
            // 
            // playButton
            // 
            this.playButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(307, 240);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(175, 58);
            this.playButton.TabIndex = 1;
            this.playButton.Text = "PLAY";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // quitButton
            // 
            this.quitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.Location = new System.Drawing.Point(307, 340);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(175, 58);
            this.quitButton.TabIndex = 2;
            this.quitButton.Text = "QUIT";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // scoreLabel
            // 
            this.scoreLabel.AutoSize = true;
            this.scoreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreLabel.Location = new System.Drawing.Point(312, 171);
            this.scoreLabel.Name = "scoreLabel";
            this.scoreLabel.Size = new System.Drawing.Size(93, 31);
            this.scoreLabel.TabIndex = 5;
            this.scoreLabel.Text = "Score:";
            this.scoreLabel.Visible = false;
            // 
            // scoreButtonLabel
            // 
            this.scoreButtonLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreButtonLabel.Location = new System.Drawing.Point(21, 450);
            this.scoreButtonLabel.Name = "scoreButtonLabel";
            this.scoreButtonLabel.Size = new System.Drawing.Size(123, 34);
            this.scoreButtonLabel.TabIndex = 6;
            this.scoreButtonLabel.Text = "SCORE INFO";
            this.scoreButtonLabel.UseVisualStyleBackColor = true;
            this.scoreButtonLabel.Click += new System.EventHandler(this.scoreButtonLabel_Click);
            // 
            // backLabel
            // 
            this.backLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.backLabel.Enabled = false;
            this.backLabel.Location = new System.Drawing.Point(169, 171);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(468, 265);
            this.backLabel.TabIndex = 7;
            this.backLabel.UseVisualStyleBackColor = false;
            // 
            // scoreInfoLabel
            // 
            this.scoreInfoLabel.AutoSize = true;
            this.scoreInfoLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.scoreInfoLabel.Font = new System.Drawing.Font("Impact", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scoreInfoLabel.Location = new System.Drawing.Point(285, 248);
            this.scoreInfoLabel.Name = "scoreInfoLabel";
            this.scoreInfoLabel.Size = new System.Drawing.Size(0, 29);
            this.scoreInfoLabel.TabIndex = 8;
            this.scoreInfoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // xLabel
            // 
            this.xLabel.AutoSize = true;
            this.xLabel.BackColor = System.Drawing.Color.SteelBlue;
            this.xLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xLabel.Location = new System.Drawing.Point(594, 187);
            this.xLabel.Name = "xLabel";
            this.xLabel.Size = new System.Drawing.Size(24, 24);
            this.xLabel.TabIndex = 9;
            this.xLabel.Text = "X";
            this.xLabel.Click += new System.EventHandler(this.xLabel_Click_1);
            // 
            // MenuScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.Controls.Add(this.xLabel);
            this.Controls.Add(this.scoreInfoLabel);
            this.Controls.Add(this.backLabel);
            this.Controls.Add(this.scoreButtonLabel);
            this.Controls.Add(this.scoreLabel);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.titleLabel);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "MenuScreen";
            this.Size = new System.Drawing.Size(800, 500);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.Label scoreLabel;
        private System.Windows.Forms.Button scoreButtonLabel;
        private System.Windows.Forms.Button backLabel;
        private System.Windows.Forms.Label scoreInfoLabel;
        private System.Windows.Forms.Label xLabel;
    }
}
