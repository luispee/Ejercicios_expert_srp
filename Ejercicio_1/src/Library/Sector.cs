//Conoce la lista de shelves
using System;
using System.Collections.Generic;
namespace SRP
{
    public class Sector
    {
        public string Id { get; }
        public Sector(String id)
        {
            this.Id = id;
        } 
        private List<Shelf> Shelves = new List<Shelf>();
        
        public void AddShelf(Shelf shelf)
        {
            this.Shelves.Add(shelf);
        }
        public void RemoveShelf(Shelf shelf)
        {
            this.Shelves.Remove(shelf);
        }
        public void PrintSector()
        {
            foreach (Shelf shelf in Shelves)
            {
                Console.WriteLine($"Sector {this.Id} tiene una shelf {shelf.Id}.");
            }
        }
        
    }

}