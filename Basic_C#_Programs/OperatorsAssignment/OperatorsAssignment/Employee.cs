using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperatorsAssignment
{
    public class Employee : Person
    {
        public int ID { get; set; }

        public static bool operator ==(Employee name, Employee name2)
        {
            if (name.ID == name2.ID)
            {
                return true;
            }

            else
            {
                return false;
            }
        }

        public static bool operator !=(Employee name, Employee name2)
        {
            return name.ID != name2.ID;
        }

       
    }

}

