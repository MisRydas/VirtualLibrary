using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace VirtualLibraryApp
{
    public interface IItem
    {
        String TableName();
        String TypesInString();
        String ValuesInString();
    }
}
