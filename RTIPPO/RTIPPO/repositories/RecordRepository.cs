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
            Sorting locationSort = Sorting.not, Sorting userSort = Sorting.not, Sorting categorySort = Sorting.not,
            string location = null, string category = null, string gender = null, string dateFrom = null, string dateBeafor = null)
        {

            DataBase db = new DataBase(
                "SELECT date AS Дата, " +
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
                getOrder(dateSort: dateSort, nameSort: nameSort, genderSort: genderSort, locationSort: locationSort, userSort: userSort, categorySort: categorySort)
                );
            return db.data;
        }

        private string getOrder(Sorting dateSort, Sorting nameSort, Sorting genderSort,Sorting locationSort, Sorting userSort, Sorting categorySort)
        {
            string order = "";
            void checkOrder()
            {
                if (order != "")
                {
                    order += ", ";
                }
                else
                {
                    order += "ORDER BY ";
                }
            }

            if (dateSort != Sorting.not)
            {
                checkOrder();
                order += "date " + statusOrder(dateSort);
            }

            if (nameSort != Sorting.not)
            {
                checkOrder();
                order += "animals.name " + statusOrder(nameSort);
            }
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
    }
}