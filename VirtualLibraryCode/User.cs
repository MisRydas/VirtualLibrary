using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public class User : IItem
    {
        public int Id { get; set; }
        public String UserName { get; set; }
        public String FirstName { get; set; }
        public String LastName { get; set; }
        public Boolean IsAdmin { get; set; }

        public String Password { private get; set; }
        public String TableName()
        {
            return "Users";
        }
        public String TypesInString()
        {
            return "(UserName, Password, FirstName, LastName)";
        }
        public String ValuesInString()
        {
            return String.Format("('{0}', '{1}', '{2}', '{3}')",
                                        UserName, Password, FirstName, LastName);
        }
        public static Boolean operator ==(User left, User right)
        {
            if ((left.Id == right.Id) &&
                (left.UserName == right.UserName) &&
                (left.FirstName == right.FirstName) &&
                (left.LastName == right.LastName) &&
                (left.IsAdmin == right.IsAdmin))
                return true;
            else return false;
        }
        public static Boolean operator !=(User left, User right)
        {
            if ((left.Id == right.Id) &&
                (left.UserName == right.UserName) &&
                (left.FirstName == right.FirstName) &&
                (left.LastName == right.LastName) &&
                (left.IsAdmin == right.IsAdmin))
                return false;
            else return true;
        }
    }
}
