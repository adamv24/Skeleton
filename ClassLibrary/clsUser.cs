using System;

namespace ClassLibrary
{
    public class clsUser
    {
        public string HouseNo { get; set; }
        public bool Active { get; set; }
        public string PostCode { get; set; }
        public string Street { get; set; }
        public string Town { get; set; }
        public int CountyCode { get; set; }
        public int AddressId { get; set; }
        public DateTime DateAdded { get; set; }

        public int Role_Id { get; set; }
        public string Role_Name { get; set; }
    }
}