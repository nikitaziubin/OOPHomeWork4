using Int;

internal class Program
{
    private static void Main(string[] args)
    {
        string name;
        int x, y;
        Console.WriteLine("Hello, World!");
        string Geofobject;
        Console.Write("Enter River(R) or Mounting(M): ");
        Geofobject = Console.ReadLine();
        if (Geofobject == "R")
        {
            River a = new River(3, 6000, "Dirpo", 7, 9);
            a.getInformation();

        }
        else
        {
            Mounting b = new Mounting("Mounting Top", "Goverla", 2, 3);
            b.getInformation();
        }
    }
}