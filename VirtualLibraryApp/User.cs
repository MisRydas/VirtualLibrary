using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualLibraryApp
{
    public class User
    {
        public int Id { get; set; }
        public String UserName { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public Boolean IsAdmin { get; set; }
        public User()
        {
        }
        public User(string username)
        {
            UserName = username;
        }
        public User(int id, string username)
        {
            Id = id;
            UserName = username;
        }
    }
}
