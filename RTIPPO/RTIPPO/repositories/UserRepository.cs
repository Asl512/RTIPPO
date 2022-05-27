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
        public string enter(string login, string password)
        {
            if (login == "" || password == "")
            {
                return "Введите логин и пароль";
            }
            else
            {
                DataBase dbLog = new DataBase("select login, password from users");
                foreach (DataRow row in dbLog.data.Rows)
                {
                    var cells = row.ItemArray;
                        if (cells[0].ToString().Trim() == login.Trim() && cells[1].ToString().Trim() == password.Trim())
                        {
                            auth = true;
                            return "";
                        }
                }
                return "Пользователь с такими данными не зарегистрирован";
            }
        }

        public string registration(string login, string password, int location)
        {
            if (login == "" || password == "")
            {
                return "Введите логин и пароль";
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
                new DataBase("INSERT INTO public.users(id_location, password, login) VALUES("+location+", '"+password+"', '"+login+"')");
                auth= true;
                return "";
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
