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
        public DataTable getRecords(Sorting dateSort = Sorting.not, Sorting nameSort = Sorting.not, Sorting genderSort = Sorting.not, 
            Sorting locationSort = Sorting.not, Sorting userSort = Sorting.not, Sorting categorySort = Sorting.not, ColumnSort lastColumnSort = ColumnSort.not,
            string location = null, string category = null, string gender = null, string dateFrom = null, string dateBeafor = null, int offset = 0)
        {

            DataBase db = new DataBase(
                "SELECT records.id AS Номер, " +
                "date AS Дата, " +
                "animals.name AS Кличка, " +
                "category.name AS Категория, " +
                "gender.name AS Пол," +
                "users.login AS Пользователь, " +
                "location.name AS Город " +
                "FROM records " +
                "INNER JOIN location ON location.id = records.id_location " +
                "INNER JOIN users ON users.id = records.id_user " +
                "INNER JOIN animals ON animals.id = records.id_animal " +
                "INNER JOIN category ON category.id = animals.id_category " +
                "INNER JOIN gender ON gender.id = animals.id_gender " +
                getWhere(location:location, category:category, gender: gender,dateFrom: dateFrom,dateBeafor: dateBeafor) +
                getOrder(dateSort: dateSort, nameSort: nameSort, genderSort: genderSort, locationSort: locationSort, userSort: userSort, categorySort: categorySort, lastColumnSort: lastColumnSort) +
                "LIMIT 2" +
                "OFFSET " + offset
                );
            return db.data;
        }

        private string getOrder(Sorting dateSort, Sorting nameSort, Sorting genderSort,Sorting locationSort, Sorting userSort, Sorting categorySort, ColumnSort lastColumnSort)
        {
            List<string> orderList = new List<string>();

            switch (lastColumnSort)
            {
                case ColumnSort.date:
                    orderList.Add("date " + statusOrder(dateSort));
                    break;
                case ColumnSort.name:
                    orderList.Add("animals.name " + statusOrder(nameSort));
                    break;
                case ColumnSort.gender:
                    orderList.Add("gender.name " + statusOrder(genderSort));
                    break;
                case ColumnSort.user:
                    orderList.Add("users.login " + statusOrder(userSort));
                    break;
                case ColumnSort.category:
                    orderList.Add("category.name " + statusOrder(categorySort));
                    break;
                case ColumnSort.location:
                    orderList.Add("location.name " + statusOrder(locationSort));
                    break;
            }

            if (genderSort != Sorting.not && lastColumnSort != ColumnSort.gender)
            {
                orderList.Add("gender.name " + statusOrder(genderSort));
            }

            if (categorySort != Sorting.not && lastColumnSort != ColumnSort.category)
            {
                orderList.Add("category.name " + statusOrder(categorySort));
            }

            if (locationSort != Sorting.not && lastColumnSort != ColumnSort.location)
            {
                orderList.Add("location.name " + statusOrder(locationSort));
            }

            if (dateSort != Sorting.not && lastColumnSort != ColumnSort.date)
            {
                orderList.Add("date " + statusOrder(dateSort));
            }

            if (nameSort != Sorting.not && lastColumnSort != ColumnSort.name)
            {
                orderList.Add("animals.name " + statusOrder(nameSort));
            }

            if (userSort != Sorting.not && lastColumnSort != ColumnSort.user)
            {
                orderList.Add("users.login " + statusOrder(userSort));
            }

            string order = "";
            if(orderList.Count > 0)
            {
                order += "ORDER BY " + String.Join(", ", orderList.ToArray())+" ";
            }
            Console.WriteLine(order);

            return order;
        }

        private string statusOrder(Sorting status)
        { 
            if(status == Sorting.ascending)
            {
                return "ASC";
            }
            else
            {
                return "DESC";
            }
        }

        private string getWhere(string location = null, string category = null, string gender = null,
            string dateFrom = null, string dateBeafor = null)
        {
            string where = "";
            void checkWhere()
            {
                if (where != "")
                {
                    where += "AND ";
                }
                else
                {
                    where += "WHERE ";
                }
            }

            if (location != null && location != "Все")
            {
                checkWhere();
                where += "(location.name = '" + location + "') ";
            }

            if (category != null && category != "Все")
            {
                checkWhere();
                where += "(category.name = '" + category + "') ";
            }

            if (gender != null && gender != "Все")
            {
                checkWhere();
                where += "(gender.name = '" + gender + "') ";
            }


            if (dateFrom != null)
            {
                checkWhere();
                where += "(date >= '" + dateFrom + "') ";
            }

            if (dateBeafor != null)
            {
                checkWhere();
                where += "(date <= '" + dateBeafor + "') ";
            }
            return where;
        }
        public DataTable getOne(string index)
        {
            DataBase db = new DataBase(
               "SELECT date , "+
               "animals.name, "+
               "category.name , " +
               "gender.name , " +
               "location.name, " +
               "animals.photo " +
               "FROM records " +
               "INNER JOIN location ON location.id = records.id_location " +
               "INNER JOIN users ON users.id = records.id_user " +
               "INNER JOIN animals ON animals.id = records.id_animal " +
               "INNER JOIN category ON category.id = animals.id_category " +
               "INNER JOIN gender ON gender.id = animals.id_gender " +
               "where records.id = "+index);
            return db.data;

        }
    }
}