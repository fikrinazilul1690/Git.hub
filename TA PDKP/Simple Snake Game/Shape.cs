using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Simple_Snake_Game
{
    class Shape
    {
        public int x
        {
            set;
            get;
        }
        public int y
        {
            set;
            get;
        }

        public Shape()
        {
            x = 0;
            y = 0;
        }
    }
}
