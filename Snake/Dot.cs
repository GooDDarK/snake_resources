using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Dot
    {
        public int x;
        public int y;
        public char symb;

        public Dot(int _x, int _y, char _symb)
        {
            x = _x;
            y = _y;
            symb = _symb;
        }

        public Dot(Dot d)
        {
            x = d.x;
            y = d.y;
            symb = d.symb;
        }

        public void Move(int offset, Direction dir)
        {
            if (dir == Direction.RIGHT)
            {
                x = x + offset;
            }
            else if (dir == Direction.LEFT)
            {
                x = x - offset;
            }
            else if (dir == Direction.UP)
            {
                y = y + offset;
            }
            else if (dir == Direction.DOWN)
            {
                y = y - offset;
            }
        }

        public void Paint()
        {
            Console.SetCursorPosition(x, y);
            Console.WriteLine(symb);
        }
    }
}
