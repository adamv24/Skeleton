using System;

namespace ClassLibrary
{
    public class clsAuthor
    {
        public bool IsBestSeller { get; set; }
        public string AuthorBiography { get; set; }
        public string AuthorName { get; set; }
        public int AuthorId { get; set; }
        public DateTime DateJoined { get; set; }
        public decimal AverageRating { get; set; }
        public int TotalBooksSold { get; set; }
    }
}
