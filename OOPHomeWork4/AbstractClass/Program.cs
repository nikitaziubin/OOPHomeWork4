using Class;  

internal class Program
{
    private static void Main(string[] args)
    {
        string name;
        int x, y;
        Console.WriteLine("Hello, World!");
        string Geofobject;
        Console.Write("Enter River(R) or Mounting(M)");
        Geofobject = Console.ReadLine();
        if (Geofobject == "R")
        {
            Console.Write("Enter River name: ");
            name = Console.ReadLine();
            Console.Write("Enter x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y: ");
            y = Convert.ToInt32(Console.ReadLine());
            River a = new River(name, x, y);
            a.getInformation();

        }
        else
        {
            Console.Write("Enter Mounting name: ");
            name = Console.ReadLine();
            Console.Write("Enter x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y: ");
            y = Convert.ToInt32(Console.ReadLine());
            Mounting b = new Mounting("Mounting Top", "Goverla", 2, 3);
            b.getInformation();
        }
    }
}