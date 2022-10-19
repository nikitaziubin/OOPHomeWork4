using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Int
{
    internal class River : Interface1
    {
        private int x;
        private int y;
        private string name;
        private int riverSpeed;
        private int length;

        public River(int riverSpeed, int length, string name, int x, int y)
        {
            this.x = x;
            this.y = y;
            this.name = name;
            this.riverSpeed = riverSpeed;
            this.length = length;
        }
        public void getInformation()
        {
            Console.WriteLine($"Name: {name}\nRiverlength: {length}\nRiverSpeed: {riverSpeed}\nX: {x}\nY: {y}");
        }
    }
}
