namespace Class
{
    internal class River : GeagraficObject
    {
        private int riverSpeed;
        private int length;

        public River( string name, int x, int y) : base(x, y, name)
        {
            this.riverSpeed = 30;
            this.length = 1900;
        }
        public override void getInformation()
        {
            base.getInformation();
            Console.WriteLine($"Riverlength: {length}\nRiverSpeed: {riverSpeed}\n");
        }
    }
}
