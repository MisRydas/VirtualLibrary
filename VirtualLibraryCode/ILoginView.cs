using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic
{
    public interface ILoginView
    {
        event Action ButtonPressed;
        String Username { get; }
        String Password { get; }
        LoginDataProvider loginData { get; } //ar sito reikia cia?
        void OnLoginSuccess();
        void OnError(string message);

    }
}
