using System;

namespace SRP
{
    public class Book
    {

        public string Title { get ; }
        public string Author { get ; }
        public string Code { get ;  }
        /*No se puede reutilizar la clase fáclmente ya que tiene responsabilidades adicionales de saber en que sector y estante se encuentra.
        public string LibrarySector { get ; set; }
        public string LibraryShelve { get ; set; }
        */
        public Book(String title, String author, String code)
        {
            this.Title = title;
            this.Author = author;
            this.Code = code;
        }
        /**************************************************************************************
        public void ShelveBook(String sector, String shelve)
        {
            this.LibrarySector = sector;
            this.LibraryShelve = shelve;
        }
        ***************************************************************************************/
    }
}