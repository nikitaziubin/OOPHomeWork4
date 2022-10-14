namespace DZ4
{
    internal class Mounting : GeagraficObject
    {
        private string top;
        public Mounting(string top, string name, int x, int y) : base(x, y, name)
        {
            this.name = name;
        }

        public virtual void getInformation()
        {
            //Console.WriteLine($"Name: {name}/n Top: {top}, X: {x} Y: {y}");
        }
    }
}
