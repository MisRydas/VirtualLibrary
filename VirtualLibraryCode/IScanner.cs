using System;
using System.Data;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
	public interface IScanner
	{
		event Action ButtonPressed;

		Image BookImage { get; }
		void OnBookFound(DataView bookData);
		void OnError(string message);
	}
}
