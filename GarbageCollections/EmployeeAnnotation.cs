using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GarbageCollections
{
    class Employer
    {
        int id;
        string name;
        public Employer(int i, string n)
        {
            id = i;
            name = n;
        }
        [NewAttribute("Accessor", "Give values of Employee Id")]
        public int getId()
        {
            return id;
        }
        [NewAttribute("Accessor", "Give values of Employee Name")]
        public string getName()
        {
            return name;
        }
    }
    class Employee
    {
        int id;
        string name;
        public Employee(int i, string n)
        {
            id = i;
            name = n;
        }
        [NewAttribute("Accessor", "Give values of Employee Id")]
        public int getId()
        {
            return id;
        }
        [NewAttribute("Accessor", "Give values of Employee Name")]
        public string getName()
        {
            return name;
        }
    }
}
