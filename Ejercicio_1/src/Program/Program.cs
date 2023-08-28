using System;

namespace SRP
{

    class Program
    {
        static void Main()
        {
            //book1.ShelveBook("A","7");
            //book2.ShelveBook("B","3");
            Sector sector1 = new Sector("1");
            Sector sector2 = new Sector("2");
            Shelf shelf1 = new Shelf("A");
            Shelf shelf2 = new Shelf("B");
            Book book1 = new Book("Design Patterns","Erich Gamma & Others","001-034");
            Book book2 = new Book("Pro C#","Troelsen","001-035");
            Book book3 = new Book("Pro Design","Erich Troelsen", "001-036");
            sector1.AddShelf(shelf1);
            shelf1.AddBook(book1);

            sector1.PrintSector();
            shelf1.PrintShelf();

            sector2.AddShelf(shelf2);    
            shelf2.AddBook(book2);
            shelf2.AddBook(book3);

            sector2.PrintSector();
            shelf2.PrintShelf();

        }
    }
}