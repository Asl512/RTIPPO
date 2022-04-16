using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTIPPO.repositories
{
    class AnimalRepository
    {
        DataTable getAll()
        {
            DataBase db = new DataBase("SELECT animals.name, photo," +
                "category.name," +
                "gender.name" +
                "FROM animals" +
                "INNER JOIN category ON category.id = animals.id_category" +
                "INNER JOIN gender ON gender.id = animals.id_gender");
            return db.data;
        }

        DataTable getOne(int id)
        {
            DataBase db = new DataBase("SELECT animals.name, photo," +
                "category.name," +
                "gender.name" +
                "FROM animals" +
                "INNER JOIN category ON category.id = animals.id_category" +
                "INNER JOIN gender ON gender.id = animals.id_gender" +
                "WHERE animals.id = " + id.ToString());
            return db.data;
        }
    }
}
