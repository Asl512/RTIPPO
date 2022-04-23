﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTIPPO.repositories
{
    class RecordRepository
    {
        public DataTable record;
        public void enter(int id)
        {
            record = record;
        }
        public void getAll()
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
            record =  db.data;
        }

        public void soringRecords(string column)
        {
            record = record;
        }

        public void filterRecords(DateTime afterDate, DateTime beaforeDate, string location, string gender, string category)
        {
            record = record;
        }
    }
}
