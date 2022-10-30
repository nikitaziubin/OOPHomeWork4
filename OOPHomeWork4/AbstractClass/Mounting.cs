namespace Class
{
    internal class Mounting : GeagraficObject
    {
        private string top;
        public Mounting(string top, string name, int x, int y) : base(x, y, name)
        {
            this.top = top;
        }

        public override void getInformation()
        {
            base.getInformation();
            Console.WriteLine($"Top: {top}\n");
        }
    }
}
