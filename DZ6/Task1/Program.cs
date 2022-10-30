using System.Text.Json;
//using System.Text.Json.Serialization;
using Task1;

internal class Program
{
    private static void Main(string[] args)
    {
        const string path = "./Json.json";
        var jsonConect = File.ReadAllText(path);
        var books = JsonSerializer.Deserialize<Book[]>(jsonConect, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        });

    }
}