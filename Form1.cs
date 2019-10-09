using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Snakee
{
    public partial class Form1 : Form
    {
        private List<Circle> Snake = new List<Circle>();

        Image i1 = Image.FromFile("C:/Users/User/Desktop/glowaa.png");
        static int eaten = 0;
        static int timer = 0;

        Random random = new Random();
        private Circle food = new Circle();

        public Form1()
        {
            InitializeComponent();

            speed_gif.Hide();
            speed_lbl.Hide();


            //Set settings to default
            new Settings();


            food = new Circle
            {
                X = random.Next(0, pictureBox1.Size.Width / Settings.Width),
                Y = random.Next(0, pictureBox1.Size.Height / Settings.Height)
            };

            //Set game speed and start timer
            gameTimer.Interval = 1000 / Settings.Speed;
            gameTimer.Tick += UpdateScreen;
            gameTimer.Start();


            timer1.Stop();

            //Start New game
            StartGame();
        }

        private void StartGame()
        {

            //Set settings to default
            new Settings();

            //Create new player object
            Snake.Clear();
            Circle head = new Circle { X = 3, Y = 1 };
            Snake.Add(head);


                Circle circle = new Circle
                {
                    X = 3,
                    Y = 1
                    
                };
                Snake.Add(circle);
        }


        private void UpdateScreen(object sender, EventArgs e)
        {
            if (timer == 2)
            {
                timer1.Stop();
                speed_gif.Hide();
                speed_lbl.Hide();

                timer = 0;
            }

            if (Input.KeyPressed(Keys.Right) && Settings.direction != Direction.Left)
            {
                Settings.direction = Direction.Right;
                imgRight();
            }
                
            else if (Input.KeyPressed(Keys.Left) && Settings.direction != Direction.Right)
            {
                Settings.direction = Direction.Left;
                imgLeft();
            }
                
            else if (Input.KeyPressed(Keys.Up) && Settings.direction != Direction.Down)
            {
                Settings.direction = Direction.Up;
                imgUp();
            }
                
            else if (Input.KeyPressed(Keys.Down) && Settings.direction != Direction.Up)
            {
                Settings.direction = Direction.Down;
                imgDown();
            }
               

            for (int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Settings.direction)
                    {
                        case Direction.Right:

                            Snake[i].X++;
                            

                            if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                            {
                                
                                generateFood();


                            }
                            break;


                        case Direction.Left:

                            Snake[i].X--;

                            if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                            {
                                generateFood();
                            }
                            break;

                        case Direction.Up:

                            Snake[i].Y--;
                            if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                            {
                                generateFood();
                            }
                            break;
                        case Direction.Down:

                            Snake[i].Y++;

                            if (Snake[0].X == food.X && Snake[0].Y == food.Y)
                            {
                                generateFood();
                            }
                            break;
                    }
                

                    for (int check_body = 1; check_body < Snake.Count; check_body++)
                    {
                        if (Snake[i].X == Snake[check_body].X &&
                            Snake[i].Y == Snake[check_body].Y)
                        {
                            Die();
                        }
                    }
                }
                else
                {
                    Snake[i].X = Snake[i - 1].X;
                    Snake[i].Y = Snake[i - 1].Y;
                }


                if ( Snake[0].X < 0 || Snake[0].Y < 0 || Snake[0].X >= pictureBox1.Size.Width/Settings.Width 
                    || Snake[0].Y >= pictureBox1.Size.Height/Settings.Height )
                {
                    Die();
                }
            }
            pictureBox1.Invalidate();
        }
                
        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {

            Graphics canvas = e.Graphics;


            Image i2 = Image.FromFile("C:/Users/User/Desktop/ogon.png");
            Image food_img = Image.FromFile("C:/Users/User/Desktop/obiad.png");
            //Set colour of snake

            //Draw snake
            for (int i = 0; i < Snake.Count; i++)
                {

                    if (i == 0)
                {
                    Point p = new Point(Snake[i].X * Settings.Width, Snake[i].Y * Settings.Height);
                    canvas.DrawImage(i1, p);
                }
                    else
                {
                    Point p = new Point(Snake[i].X * Settings.Width, Snake[i].Y * Settings.Height);
                    canvas.DrawImage(i2, p);
                }

                canvas.DrawImage(food_img, food.X * Settings.Width,
                                  food.Y * Settings.Height);
                }
            
        }


        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
             Input.ChangeState(e.KeyCode, true);
    
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {

             Input.ChangeState(e.KeyCode, false);

        }

        private void imgUp()
        {
            i1 = Image.FromFile("C:/Users/User/Desktop/glowaa.png");
            i1.RotateFlip(RotateFlipType.Rotate180FlipNone);
        }

        private void imgDown()
        {
            i1 = Image.FromFile("C:/Users/User/Desktop/glowaa.png");
        }

        private void imgRight()
        {
            i1 = Image.FromFile("C:/Users/User/Desktop/glowaa.png");
            i1.RotateFlip(RotateFlipType.Rotate270FlipNone);
        }

        private void imgLeft()
        {
            i1 = Image.FromFile("C:/Users/User/Desktop/glowaa.png");
            i1.RotateFlip(RotateFlipType.Rotate90FlipNone);
        }



        private void generateFood()
        {
            gameTimer.Stop();
            int Xx = 0;
            int Yy = 0;
            bool check = true;

            do
            {
                Xx = random.Next(0, pictureBox1.Size.Width / Settings.Width);
                Yy = random.Next(0, pictureBox1.Size.Height / Settings.Height);

                check = true;

                for (int check_food = 0; check_food < Snake.Count; check_food++)
                {
                    if (Snake[check_food].X == Xx && Snake[check_food].Y == Yy)
                    {
                        check = false;

                        break;
                    }
                }
            }
            while (check == false);


            Circle circle = new Circle
            {
                X = Snake[Snake.Count - 1].X,
                Y = Snake[Snake.Count - 1].Y
            };

            Snake.Add(circle);

            food = new Circle
            {
                X = Xx,
                Y = Yy
            };

            gameTimer.Start();

            eaten++;
            string myString = eaten.ToString();
            label_eaten.Text = myString;

            if (eaten == 10 || eaten == 20 || eaten == 25 || eaten == 30 || eaten == 35
                || eaten == 40 || eaten == 42 || eaten == 44 || eaten == 46 || eaten >= 47)
            {
                   Settings.Speed++;
                   gameTimer.Interval = 1000 / Settings.Speed;

                timer1.Interval = 1;
                timer1.Start();
                
            }
            else if(eaten == 50)
            {
                gameTimer.Stop();
                string message = "                      You are the Winner";
                string caption = "Przemyslaw Drzewicz is proud of you";

                MessageBoxButtons buttons = MessageBoxButtons.YesNo;
                DialogResult result;

                // Displays the MessageBox.

                result = MessageBox.Show(message, caption, buttons);

                if (result == System.Windows.Forms.DialogResult.Yes)
                {

                    // Closes the parent form.

                    this.Close();
                }
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Interval = 2000;
            speed_gif.Show();
            speed_lbl.Show();
            speed_lbl.BringToFront();

            timer++;
        }

        private void Die()
        {
            gameTimer.Stop();
            string message = "                      You are Dead";
            string caption = "Try again";
            
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.

            result = MessageBox.Show(message, caption, buttons);

            if (result == System.Windows.Forms.DialogResult.Yes)
            {

                // Closes the parent form.

                this.Close();
            }
        }
    }
}