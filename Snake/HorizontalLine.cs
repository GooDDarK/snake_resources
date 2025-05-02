using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class HorizontalLine : Figure
    {
        public HorizontalLine(int xStart, int xEnd, int y, char symb)
        {
            lList = new List<Dot>();

            for (int x = xStart; x <= xEnd; x++)
            {
                Dot dot = new Dot(x, y, symb);
                lList.Add(dot);
            }
        }
    }
}
