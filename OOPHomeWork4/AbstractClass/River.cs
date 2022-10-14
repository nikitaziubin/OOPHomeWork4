
using System.Security.Cryptography.X509Certificates;

namespace DZ4
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
            Console.WriteLine($"Name: {name} \n Riverlength: {length} RiverSpeed: {riverSpeed}, X: {x} Y: {y}");
        }
    }
}
