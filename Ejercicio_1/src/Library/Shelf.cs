//Conocer la lista de libros que hay en el estante
using System;
using System.Collections.Generic;

namespace SRP
{
    public class Shelf
    {
        public string Id { get;}
        public Shelf(string id)
        {
            this.Id = id;
        }
        private List<Book> BookShelf = new List<Book>();
        //Podría tener un id o nombre
        //public string ShelfName { get; set; }

        public void AddBook(Book book)
        {
            this.BookShelf.Add(book);
        }
        public void RemoveBook(Book book)
        {
            this.BookShelf.Remove(book);
        }
        public void PrintShelf()
        {
            foreach (Book book in this.BookShelf)
            {  
                Console.WriteLine($"{book.Title} está en la shelf {this.Id}");
            }
        }
    }
}
