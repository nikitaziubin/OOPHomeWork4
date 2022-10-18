using Class;  

internal class Program
{
    private static void Main(string[] args)
    {
        string name, geofObject;
        int x, y;
        Console.Write("Enter River(R) or Mounting(M): ");
        geofObject = Console.ReadLine();
        if (geofObject == "R")
        {
            River a = new River(1, 2, "dnipro1", 4, 5);
            a.getInformation();
        }
        else
        {
            Mounting b = new Mounting("Top", "Goverla", 2, 3);
            b.getInformation();
        }
    }
}