using System;

namespace ClassLibrary
{
    public class clsOrder
    {
        public int OrderId { get; set; }
        public int ISBN { get; set; }
        public int UserId { get; set; }
        public bool? IsValid { get; set; } = true;
        public DateTime? CreatedAt { get; set; } = DateTime.Now;
        public string Status { get; set; } = "Started";
    }
}