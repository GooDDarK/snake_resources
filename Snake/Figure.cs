using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Figure
    {
        public List<Dot> lList;

        public void Draw()
        {
            foreach (Dot dot in lList)
            {
                dot.Paint();
            }
        }
    }
}
