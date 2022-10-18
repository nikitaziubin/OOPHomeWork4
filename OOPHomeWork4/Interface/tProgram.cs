using Interface;

internal class tProgram
{
    private static void Main(string[] args)
    {
        string Geofobject;
        Console.Write("Enter River(R) or Mounting(M)");
        Geofobject = Console.ReadLine();
        if (Geofobject == "R")
        {
            River a = new River(5, 6, "jjj", 7, 9);
            a.getInformation();

        }
        else
        {
            Mounting b = new Mounting("Top", "Goverla", 2, 3);
        }
    }
}