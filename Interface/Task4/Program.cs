using Task4;

struct A
{

    public int sI;
    public string sStr;
}

class B
{
    static int Get()
    {
        return 0;
    }
    int Get()
    {
        return 0;
    }
    public int cI;
    public A cA;
}


internal class Program
{
    static void Main()
    {
        A a1 = new A();
        A a2 = a1;
        a2.sStr = "aaa";
        a2.sI = 10;
        B b1 = new B();
        B b2 = b1;

        b2.cA = a1;
        b2.cI = 5;
        Console.Write("b1.CA.sI={0}, b1.cA.sStr={1}, b1.cI={2}; b2.CA.sI={3}, b2.cA.sStr={4}, b2.cI={5}. ",
        b1.cA.sI, b1.cA.sStr, b1.cI, b2.cA.sI, b2.cA.sStr, b2.cI);
        Console.ReadKey(true);
    }
}





