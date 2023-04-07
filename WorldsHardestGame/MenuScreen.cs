using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldsHardestGame
{
    public partial class MenuScreen : UserControl
    {
        public MenuScreen()
        {
            InitializeComponent();
            scoreInfoLabel.Visible = false; 
            backLabel.Visible = false;
            xLabel.Visible = false;
            xLabel.Enabled = false;
           

            if (Form1.score != 0)
            {
                scoreLabel.Visible = true;
                scoreLabel.Text = $"SCORE: {Form1.score}"; 
            }
            else
            {
                scoreLabel.Visible = false;
            }

            scoreInfoLabel.Text = $"LOWER SCORE IS BETTER\n1s = 50\n1 life = -1000"; 
            
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            Form1.timer.Start();
            Form1.playSound(Form1.pingSound);
            Form1.ChangeScreen(this, new GameScreen());
        }

        private void quitButton_Click(object sender, EventArgs e)
        {
            Form1.playSound(Form1.pingSound);
            Form f = this.FindForm();
            f.Close();
        }

        private void scoreButtonLabel_Click(object sender, EventArgs e)
        {
            Form1.playSound(Form1.pingSound);
            xLabel.Visible = true;
            xLabel.Enabled = true;
            scoreInfoLabel.Visible = true;
            backLabel.Visible = true;
        }

        private void xLabel_Click_1(object sender, EventArgs e)
        {
            Form1.playSound(Form1.pingSound);
            xLabel.Visible = false;
            xLabel.Enabled = false;
            scoreInfoLabel.Visible = false;
            backLabel.Visible = false;
        }
    }
}
