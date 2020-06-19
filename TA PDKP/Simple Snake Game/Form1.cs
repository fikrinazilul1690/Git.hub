using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace Simple_Snake_Game
{
    public partial class Form1 : Form
    {
        private List<Shape> Snake = new List<Shape>();
        private Shape Food = new Shape();
        Setting call = new Setting();
        int points;
        DialogResult hasil;
        int widht = 16;
        int height = 16;
        int score, speed;
        bool aktif = false;
        public Form1()
        {
            InitializeComponent();
            txtScore.Visible = false;
            numScore.Visible = false;
            txtLevel.Visible = true;
            groupBox1.Visible = true;
            button1.Visible = true;
            button2.Visible = true;
            button3.Visible = true;
            button4.Visible = true;
            button5.Visible = true;
            button6.Visible = true;
            button6.Enabled = false;
        }
        private void StartGame()
        {
            txtScore.Visible = true;
            numScore.Visible = true;
            txtLevel.Visible = false;
            groupBox1.Visible = false;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            button1.Visible = false;
            button2.Visible = false;
            button3.Visible = false;
            button4.Visible = false;
            button5.Visible = false;
            button6.Visible = false;
            txtGameOver.Visible = false;
            Snake.Clear();
            Shape head = new Shape();
            new Setting();
            head.x = 10;
            head.y = 10;
            Snake.Add(head);
            score = 0;
            call.setScore(score);

            numScore.Text = call.getScore().ToString();
            GenerateFood();
        }
        private void GenerateFood()
        {
            call.setWidth(widht);
            call.setHeight(height);
            int maxXpos = SnakesArena.Size.Width / call.getWidth();
            int maxYpos = SnakesArena.Size.Height / call.getHeight();

            Random random = new Random();
            Food = new Shape();
            Food.x = random.Next(0, maxXpos);
            Food.y = random.Next(0, maxYpos);
        }
        private void UpdateScreen(object sender, EventArgs e)
        {
            if(Setting.GameOver == true)
            {
                if (aktif == true)
                {
                    StartGame();
                }
            }
            else
            {
                if (KeyInput.KeyPressed(Keys.Right) && Setting.arah != Arah.Left)
                    Setting.arah = Arah.Right;
                else if (KeyInput.KeyPressed(Keys.Left) && Setting.arah != Arah.Right)
                    Setting.arah = Arah.Left;
                else if (KeyInput.KeyPressed(Keys.Up) && Setting.arah != Arah.Down)
                    Setting.arah = Arah.Up;
                else if (KeyInput.KeyPressed(Keys.Down) && Setting.arah != Arah.Up)
                    Setting.arah = Arah.Down;

                MovePlayer();
            }
            SnakesArena.Invalidate();
        }

        private void MovePlayer()
        {
            for(int i = Snake.Count - 1; i >= 0; i--)
            {
                if (i == 0)
                {
                    switch (Setting.arah)
                    {
                        case Arah.Right:
                            Snake[i].x++;
                            break;
                        case Arah.Left:
                            Snake[i].x--;
                            break;
                        case Arah.Up:
                            Snake[i].y--;
                            break;
                        case Arah.Down:
                            Snake[i].y++;
                            break;
                        default:
                            break;
                    }
                    call.setWidth(widht);
                    call.setHeight(height);
                    int maxXpos = SnakesArena.Size.Width / call.getWidth();
                    int maxYpos = SnakesArena.Size.Height / call.getHeight();
                    if (Snake[i].x < 0 || Snake[i].y < 0 || Snake[i].x >= maxXpos || Snake[i].y >= maxYpos)
                    {
                        Die();
                    }

                    for (int j=1;j<Snake.Count; j++)
                    {
                        if (Snake[i].x == Snake[j].x && Snake[i].y == Snake[j].y)
                        {
                            Die();
                        }
                    }

                    if (Snake[0].x == Food.x && Snake[0].y == Food.y)
                    {
                        eat();
                    }
                    if (Snake[0].x == Food.x && Snake[0].y == Food.y)
                    {
                        eat();
                    }
                }
                else
                {
                    Snake[i].x = Snake[i - 1].x;
                    Snake[i].y = Snake[i - 1].y;
                }
            }
        }

        private void eat()
        {
            Food.x = Snake[Snake.Count - 1].x;
            Food.y = Snake[Snake.Count - 1].y;
            Snake.Add(Food);
            
            score += call.getPoints();
            call.setScore(score);
            numScore.Text = call.getScore().ToString();

            GenerateFood();
        }
        private void Die()
        {
            Setting.GameOver = true;
            aktif = false;
        }

        private void SnakesArena_Paint(object sender, PaintEventArgs e)
        {
            Graphics canvas = e.Graphics;

            if(!Setting.GameOver)
            {
                Brush snakeColour;

                for(int i = 0; i < Snake.Count; i++)
                {
                    if (i == 0)
                        snakeColour = Brushes.Black;
                    else
                        snakeColour = Brushes.Gray;
                    call.setWidth(widht);
                    call.setHeight(height);
                    canvas.FillEllipse(snakeColour, new Rectangle(Snake[i].x * call.getWidth(), Snake[i].y * call.getHeight(), call.getWidth(), call.getHeight()));
                    canvas.FillEllipse(Brushes.Red, new Rectangle(Food.x * call.getWidth(), Food.y * call.getHeight(), call.getWidth(), call.getHeight()));
                }
            }
            else
            {
                string gameOver = "Game Over\nYour Final Score is: " + call.getScore() + "\nClick Retry to Try Again";
                txtGameOver.Text = gameOver;
                txtGameOver.Visible = true;
                groupBox1.Visible = true;
                txtLevel.Visible = true;
                txtScore.Visible = false;
                numScore.Visible = false;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                aktif = false;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            KeyInput.ChangeState(e.KeyCode, true);
        }
        private void Reset()
        {
            timer1.Tick -= UpdateScreen;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Reset();
            speed = 10;
            points = 10;
            call.setPoints(points);
            call.setSpeed(speed);
            StartGame();
            timer1.Interval = 1000 / call.getSpeed();
            timer1.Tick += UpdateScreen;
            timer1.Start();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Reset();
            speed = 15;
            points = 20;
            call.setPoints(points);
            call.setSpeed(speed);
            StartGame();
            timer1.Interval = 1000 / call.getSpeed();
            timer1.Tick += UpdateScreen;
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Reset();
            speed = 25;
            points = 30;
            call.setPoints(points);
            call.setSpeed(speed);
            StartGame();
            timer1.Interval = 1000 / call.getSpeed();
            timer1.Tick += UpdateScreen;
            timer1.Start();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Reset();
            speed = 33;
            points = 50;
            call.setPoints(points);
            call.setSpeed(speed);
            StartGame();
            timer1.Interval = 1000 / call.getSpeed();
            timer1.Tick += UpdateScreen;
            timer1.Start();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hasil = MessageBox.Show("Ingin Keluar ??", "options", MessageBoxButtons.YesNo);

            if (hasil == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            aktif = true;
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            KeyInput.ChangeState(e.KeyCode, false);
        }
    }
}
