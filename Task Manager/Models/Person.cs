using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_Manager.Models
{
    class Person
    {
        

        public Person(SqlDataReader dr)
        {
            PersonId = dr.GetInt32(0);
            FirstName = dr.GetString(1);
            LastName = dr.GetString(2);
            MiddleName = dr.GetString(3);
        }

        public int PersonId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string MiddleName { get; set; }
    }
}
