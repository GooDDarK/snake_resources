using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dot line = new Dot(4, 7, '*');
            Snake snake = new Snake(line, 3, Direction.RIGHT);

            Console.ReadLine();
        }
    }
}
