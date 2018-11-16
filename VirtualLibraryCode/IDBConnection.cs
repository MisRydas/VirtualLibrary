using System;
using System.Data;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VirtualLibraryCode
{
	public interface IDBConnection
	{
		void Query(String query); //Paprastas metodas INSERT, DELETE sakiniams vykdyti, negražina rezultato.

		DataTable SelectQuery(String query); //Metodas SELECT sakiniams vykdyti, nes gražina reikšme supildytą į DataTable
	}
}
