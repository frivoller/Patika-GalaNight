using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        // guest list
        List<string> ziyaretciler = new List<string> { "Pedro Pascal", "Keanu Reeves", "Ajdar", "Melis Yıldız", "Cate Blanchett" };

        // foreach dongusu
        foreach (string isim in ziyaretciler)
        {
            Console.WriteLine(isim);
        }

        Console.ReadKey();
    }
}
