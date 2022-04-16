using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTIPPO.repositories
{
    class GenderAnimalRepository
    {
        public DataTable getAll()
        {
            DataBase db = new DataBase("SELECT id, name FROM gender");
            return db.data;
        }
    }
}
