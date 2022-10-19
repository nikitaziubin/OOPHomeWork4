using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int
{
    internal class Mounting : Interface1
    {
        private string name;
        private int x;
        private int y;
        private string top;
        public Mounting(string top, string name, int x, int y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
            this.top = top;
        }

        public void getInformation()
        {
            Console.WriteLine($"Name: {name}\nTop: {top}\nX: {x}\nY: {y}");
        }
    }
}
