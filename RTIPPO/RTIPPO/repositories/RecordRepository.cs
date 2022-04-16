using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTIPPO.repositories
{
    class RecordRepository
    {
        DataTable getAll()
        {
            DataBase db = new DataBase("SELECT date AS Дата, " +
                "animals.name AS Кличка, " +
                "category.name AS Категория, " +
                "gender.name AS Гендер," +
                "users.login AS Пользователь, " +
                "location.name AS Город " +
                "FROM records " +
                "INNER JOIN location ON location.id = records.id_location " +
                "INNER JOIN users ON users.id = records.id_user " +
                "INNER JOIN animals ON animals.id = records.id_animal " +
                "INNER JOIN category ON category.id = animals.id_category " +
                "INNER JOIN gender ON gender.id = animals.id_gender");
            return db.data;
        }

        DataTable getOne(int id)
        {
            DataBase db = new DataBase("SELECT date AS Дата, " +
                "animals.name AS Кличка, " +
                "category.name AS Категория, " +
                "gender.name AS Гендер," +
                "users.login AS Пользователь, " +
                "location.name AS Город " +
                "FROM records " +
                "INNER JOIN location ON location.id = records.id_location " +
                "INNER JOIN users ON users.id = records.id_user " +
                "INNER JOIN animals ON animals.id = records.id_animal " +
                "INNER JOIN category ON category.id = animals.id_category " +
                "INNER JOIN gender ON gender.id = animals.id_gender" +
                "WHERE records.id = " + id.ToString());
            return db.data;
        }
    }
}
