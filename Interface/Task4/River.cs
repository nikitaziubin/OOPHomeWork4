namespace Task4
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
        public void getInformation(string name, int x, int y)
        {
            Console.WriteLine($"Name: {name}\nRiverlength: {length}\nRiverSpeed: {riverSpeed}\nX: {x}\nY: {y}");
        }
    }
}
