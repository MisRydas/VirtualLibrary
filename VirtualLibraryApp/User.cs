using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualLibraryApp
{
    class User
    {
        int Id { get; set; }
        String UserName { get; set; }
        String FirstName { get; set; }
        String LastName { get; set; }
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
