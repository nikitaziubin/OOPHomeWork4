

using System.Xml.Linq;

namespace Task4
{
    internal static class staticClass
    {
        //private int ad;
        //private string nameS;

        //public staticClass() { }
        //public staticClass(int name)
        //    : this(name, "") { Console.WriteLine(name); }
        //public staticClass(string a)
        //    : this(0, a) { Console.WriteLine(a); }
        //public staticClass(int a, string name)
        //{
        //    nameS = name;
        //    ad = a;

        //}
        private static int a;
        private static int c;
        static staticClass()
        {
            a = 1;
        }
        public static int geta()
        {
            return a;
        }
    }

}
