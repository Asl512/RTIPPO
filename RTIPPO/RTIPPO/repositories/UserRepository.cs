using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTIPPO.repositories
{
    class UserRepository
    {
        private bool auth=false;
        public bool enter(string login, string password)
        {
            if (login == "" || password=="")
            {
                return false;
            }
            else
            {
                auth=true;
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
            if (auth)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public DataTable getUser(String login)
        {
            DataBase db = new DataBase("SELECT login,password,status.name," +
            "location.name AS Город" +
            "FROM users" +
            "INNER JOIN location ON location.id = users.id_location" +
            "INNER JOIN status ON status.id = users.id_status" +
            "WHERE login = '" + login + "'");
            return db.data;
        }
    }
}
