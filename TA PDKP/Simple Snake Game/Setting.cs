using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Snake_Game
{
    public enum Arah
    {
        Up,Down,Left,Right
    }
    class Setting
    {
        private int Width, Height, Speed, Score, Points;
        public void setWidth(int val)
        {
            this.Width = val;
        }
        public int getWidth()
        {
            return this.Width;
        }
        public void setHeight(int val)
        {
            this.Height = val;
        }
        public int getHeight()
        {
            return this.Height;
        }
        public void setSpeed(int val) 
        {
            this.Speed = val;
        }
        public int getSpeed()
        {
            return this.Speed;
        }
        public void setScore(int val) 
        {
            this.Score = val;
        }
        public int getScore()
        {
            return this.Score;
        }
        public void setPoints(int val)
        {
            this.Points = val;
        }
        public int getPoints()
        {
            return this.Points;
        }
        public static bool GameOver 
        { 
            set; 
            get;
        }
        public static Arah arah
        {
            set;
            get;
        }

        public Setting()
        {
            Width = 0;
            Height = 0;
            Score = 0;
            Speed = 0;
            Points = 0;
            GameOver = false;
            arah = Arah.Down;
        }

    }
}
