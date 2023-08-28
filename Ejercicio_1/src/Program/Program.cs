using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            Sector sector1 = new Sector("PrimerSector");
            Shelf shelf1 = new Shelf(1);
            Console.WriteLine(sector1.Name);
            Console.WriteLine(shelf1.numShelf);
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            //book1.ShelveBook("A","7");
            //book2.ShelveBook("B","3");
            Console.WriteLine(book1.Title);
            Console.WriteLine(book2.Title);
        }
    }
}