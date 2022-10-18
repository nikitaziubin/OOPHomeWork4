using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface
{
    internal class River : Interface1
    {
        private int riverSpeed;
        private int length;

        public River(int riverSpeed, int length, string name, int x, int y)
        {
            this.riverSpeed = riverSpeed;
            this.length = length;
        }
        public virtual void getInformation()
        {
            Console.WriteLine($"Riverlength: {length}\nRiverSpeed: {riverSpeed}\n");
        }
    }
}

