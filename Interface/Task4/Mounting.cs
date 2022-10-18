namespace Task4
{
    internal class Mounting : Interface1
    {
        private string top;
        public Mounting(string top, string name, int x, int y)
        {
            this.top = top;
        }

        public void getInformation(string name, int x, int y)
        {
            Console.WriteLine($"Name: {name}\nTop: {top}\nX: {x}\nY: {y}");
        }
    }
}
