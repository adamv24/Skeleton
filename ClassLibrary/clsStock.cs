using System;

namespace ClassLibrary
{
    public class clsStock
    {
        public bool Active { get; set; }
        public DateTime DateAdded { get; set; }
        public int IsbnID { get; set; }
        public string BookName { get; set; }
        public string BookAuthor { get; set; }
        public int QuantityAvailable { get; set; }
        public decimal Price { get; set; }
    }
}