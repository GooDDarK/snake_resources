using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Snake : Figure
    {
        public Snake(Dot tail, int lenght, Direction direction)
        {
            lList = new List<Dot>();
            for (int i = 0; i < lenght; i++)
            {
                Dot d = new Dot(tail);
                d.Move(i, direction);
                lList.Add(d);
            }
        }
    }
}
