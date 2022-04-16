using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RTIPPO.models
{
    class User_Model
    {
        public int id;
        public string name;
        public string email;
        public string password;
        public Location_Model location;
        public Status_Model status;
    }
}
