namespace DZ4
{
    internal abstract class GeagraficObject
    {
        protected int x;
        protected int y;
        protected string name;
        public GeagraficObject(int x, int y, string name)
        {
            this.x = x;
            this.y = y;
            this.name = name;
        }

        public virtual void getInformation()
        {

        }



    }
}
