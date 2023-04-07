using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using System.Media;

namespace WorldsHardestGame
{
    public partial class Form1 : Form
    {
        public static Stopwatch timer = new Stopwatch();
        public static int score;

        public static string winningSound = "/Resources/winningSoundLoud.wav";
        public static string pingSound = "/Resources/pingSound.wav";
        public static string deathSound = "/Resources/VideoGameDeathSoundLoud.wav";


        public Form1()
        {
            InitializeComponent();
            ChangeScreen(this, new MenuScreen());
            
        }

        public static void ChangeScreen(object sender, UserControl next)
        {
            Form f; // will either be the sender or parent of sender

            if (sender is Form)
            {
                f = (Form)sender;                          //f is sender
            }
            else
            {
                UserControl current = (UserControl)sender;  //create UserControl from sender
                f = current.FindForm();                     //find Form UserControl is on
                f.Controls.Remove(current);                 //remove current UserControl
            }
            // add the new UserControl to the middle of the screen and focus on it

            next.Location = new Point((f.ClientSize.Width - next.Width) / 2,
               (f.ClientSize.Height - next.Height) / 2);
            f.Controls.Add(next);
            next.Focus();
        }

        public static void playSound(string location)
        {
            var sound = new System.Windows.Media.MediaPlayer();
            sound.Open(new Uri(Application.StartupPath + $"{location}"));
            sound.Play();
        }
    }
}
