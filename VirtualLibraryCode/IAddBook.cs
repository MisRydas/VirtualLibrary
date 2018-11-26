using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface IAddBook
    {
        event Action ButtonPressed;

        String Name { get; }
        String ISBN13 { get; }
        String ISBN10 { get; }
        String Author { get; }
        String Genre { get; }
        String Publisher { get; }
        String Published { get; }
        String ListPrice { get; }
        String CoverLink { get; }
        void OnBookAdded();
        void OnError(string message);

    }
}
