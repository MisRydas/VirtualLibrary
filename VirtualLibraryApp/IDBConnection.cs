using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace VirtualLibraryApp
{
    public interface IDBConnection
    {
        void Query(String query); //Paprastas metodas INSERT, DELETE sakiniams vykdyti, negražina rezultato.

        DataTable SelectQuery(String query); //Metodas SELECT sakiniams vykdyti, nes gražina reikšme supildytą į DataTable
    }
}
