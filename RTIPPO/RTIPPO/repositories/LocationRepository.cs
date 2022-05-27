using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTIPPO.repositories
{
    class LocationRepository
    {
    public DataTable getAll()
        {
            DataBase db = new DataBase("SELECT id, name FROM location");
            return db.data;
        }
    }
}
