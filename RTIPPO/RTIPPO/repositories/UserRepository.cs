using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTIPPO.repositories
{
    public class UserRepository
    {
        private bool auth = false;
        public bool enter(string login, string password)
        {
            if (login == "" || password == "")
            {
                return false;
            }
            else
            {
                auth = true;
                return true;
            }
        }

        private bool reg = false;
        public bool registration(string login, string password, int location)
        {
            if (login == "" || password == "")
            {
                return false;
            }
            else
            {
                reg = true;
                return true;
            }
        }

        public bool checkIsLogginIn()
        {
            return auth;
        }

        public void logout()
        {
            auth = false;
        }
    }
}
