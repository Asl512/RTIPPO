using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTIPPO.models
{
    class Record_Model
    {
        public int id;
        public Animal_Model animal;
        public DateTime date;
        public User_Model user;
        public Location_Model location;
    }
}
