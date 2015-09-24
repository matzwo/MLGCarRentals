using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core
{
    class Admin
    {
        string login;
        string password;
        DateTime lastLogIn;

        void setLogin(string log) { this.login = log; }
        string getLogin() { return this.login; }

        void setPasword(string psswd) { this.password = psswd; }
        string getPassword() { return this.password; }

        void setLastLogIn(DateTime llog) { this.lastLogIn = llog; }
        DateTime getLastLogIn() { return this.lastLogIn; }
    }
}
