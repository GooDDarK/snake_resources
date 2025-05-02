using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class VerticalLine : Figure
    {
        public VerticalLine(int yUp, int yDown, int x, char symb)
        {
            lList = new List<Dot>();

            for (int y = yUp; y <= yDown; y++)
            {
                Dot dot = new Dot(x, y, symb);
                lList.Add(dot);
            }
        }
    }
}
