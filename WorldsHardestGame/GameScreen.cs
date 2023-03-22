using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlTypes;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorldsHardestGame
{
    public partial class GameScreen : UserControl
    {
        public List<Rectangle> backArea = new List <Rectangle>();
        List<Point> gridBackArea = new List<Point>(); 
        List<Enemy> enemies = new List<Enemy>();

        SolidBrush greenBrush = new SolidBrush (Color.Green);
        SolidBrush blackBrush = new SolidBrush(Color.Black);
        SolidBrush whiteBrush = new SolidBrush(Color.White);

        public Rectangle bigRec = new Rectangle(160, 100, 480, 300); 
        //used in grid creation
        int gridSize = 60; 

        public GameScreen()
        {
            InitializeComponent();

            #region backgroundRectangleInitialization 

            //creates the rectangle the player can freely move on
            backArea.Add(new Rectangle(60, 190, 60, 120));
            backArea.Add(new Rectangle(120, 310 - 40, 40, 40));
            backArea.Add(bigRec);
            backArea.Add(new Rectangle(640, 250 - 20, 40, 40));
            backArea.Add(new Rectangle(680, 190, 60, 120));

            //creates the astetic grid overlayed on functional rectangles 
            int tempX = 0;
            int tempY = 0;

            for (int i = 0; i < 40; i++)
            {
                gridBackArea.Add(new Point(160 + tempX, 100 + tempY));
                tempX += 60; 

                //checks whether a new row is needed
                if (tempX / 450 == 1)
                {
                    tempX = 0;
                    tempY += 60; 
                }
            }
            #endregion


            #region enemyCreation

            for (int i = 0; i <= 7; i++)
            {
                //alternates up and down
                int add; 
                if (i % 2 == 0)
                {
                    add = bigRec.Height; 
                }
                else
                {
                    add = 0;
                }
                //creates 8 enemies
                Enemy newEnemy = new Enemy((bigRec.Width / 8)*i + bigRec.X + 10, bigRec.Y + add, 40, 6);
                enemies.Add(newEnemy);
            }
            #endregion




        }


        private void gameEngine_Tick(object sender, EventArgs e)
        {
            foreach (Enemy enemy in enemies)
            {
                enemy.Move(bigRec);
                Rectangle enemyCheck = new Rectangle(enemy.x, enemy.y, enemy.size, enemy.size);
                if (bigRec.IntersectsWith(enemyCheck))
                {
                    checkLabel.Text = $"true";
                }
                else
                {
                    checkLabel.Text = $"false";
                }
            }

            Refresh();
        }

        private void GameScreen_Paint(object sender, PaintEventArgs e)
        {
            #region backgroundRectangleGraphics

            //creates the green rectangles shown on screen
            foreach (Rectangle rect in backArea)
            {
                e.Graphics.FillRectangle(greenBrush, rect);
            }

            //overlays the green rectangles on screen other then start and finish
           for (int i =1; i < gridBackArea.Count + 1; i++)
            {
                //sure there is a better way to swap colors but this works
                if (i > 8 && i <= 16 || i > 24 && i <= 32 || i > 40)
                {
                    if (i % 2 == 0)
                    {
                        e.Graphics.FillRectangle(whiteBrush, gridBackArea[i-1].X, gridBackArea[i-1].Y, gridSize, gridSize);
                    }
                    else
                    {
                        e.Graphics.FillRectangle(blackBrush, gridBackArea[i-1].X, gridBackArea[i-1].Y, gridSize, gridSize);
                    }
                }
                else
                {
                    if (i % 2 == 0)
                    {
                        e.Graphics.FillRectangle(blackBrush, gridBackArea[i-1].X, gridBackArea[i-1].Y, gridSize, gridSize);
                    }
                    else
                    {
                        e.Graphics.FillRectangle(whiteBrush, gridBackArea[i-1].X, gridBackArea[i-1].Y, gridSize, gridSize);
                    }
                }
            }
            #endregion

           foreach (Enemy enemy in enemies)
            {
                e.Graphics.FillEllipse(greenBrush, enemy.x, enemy.y, enemy.size, enemy.size); 
            }
        }
    }
}
