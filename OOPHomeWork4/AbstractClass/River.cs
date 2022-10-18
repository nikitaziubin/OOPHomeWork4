﻿namespace Class
{
    internal class River : GeagraficObject
    {
        private int riverSpeed;
        private int length;

        public River(int riverSpeed, int length, string name, int x, int y) : base(x, y, name)
        {
            this.riverSpeed = riverSpeed;
            this.length = length;
        }
        public virtual void getInformation()
        {
            base.getInformation();
            Console.WriteLine($"Riverlength: {length}\nRiverSpeed: {riverSpeed}\n");
        }
    }
}
