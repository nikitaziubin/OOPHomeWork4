namespace Interface 
{
    internal class Mounting
    {
        private string top;
        public Mounting(string top, string name, int x, int y)
        {
            this.top = top;
        }

        public virtual void getInformation()
        {
            Console.WriteLine($"Top: {top}\n");
        }
    }
}
