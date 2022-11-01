using System;
using System.Text.Json;
//using System.Text.Json.Serialization;
using Task1;

internal class Program
{
    static void print(Book book)
    {
        Console.WriteLine(book.publishingHouseId);
        Console.WriteLine(book.title);
        Console.WriteLine(book.PublishingHouse.id);
        Console.WriteLine(book.PublishingHouse.name);
        Console.WriteLine(book.PublishingHouse.adress);
    }
    private static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        const string path = "./Json.json";
        var jsonConect = File.ReadAllText(path);
        var books = JsonSerializer.Deserialize<Book[]>(jsonConect, new JsonSerializerOptions
        {
            PropertyNameCaseInsensitive = true,
        });
        int num = Convert.ToInt32(Console.ReadLine());
        print(books[num]);
    }
}