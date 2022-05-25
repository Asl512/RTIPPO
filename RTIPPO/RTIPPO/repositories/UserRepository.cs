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

        private bool auth=false;
        public bool enter(string login, string password)
        {
            if (login == "" || password=="")
            {
                return false;
            }
            else
            {

                auth =true;
                return true;
                
            }
            
        }

        public string registration(string login, string password, int location)
        {
            if (login == "" || password == "")
            {
                return "Введите логин и парооль";
            }
            else
            {
                DataBase db = new DataBase("select login from users");
                foreach (DataRow row in db.data.Rows)
                {
                    var cells = row.ItemArray;
                    foreach (object cell in cells)
                    {
                        Console.Write("\t{0}", cell);
                        if (cell.ToString().Trim() == login.Trim())
                        {
                            return "Пользователь с таким логином уже существует";
                        }
                    }
                }
                new DataBase("INSERT INTO public.users(id_location, password, login, id_status) VALUES(0, '"+password+"', '"+login+"', 0)");
                auth= true;
                return "";
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
