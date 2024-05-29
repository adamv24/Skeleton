using System;

namespace ClassLibrary
{
    public class clsReviewUser
    {
        public int UserID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Department { get; set; }

        public bool FindUser(string userName, string password)
        {
            throw new NotImplementedException();
        }
    }
}