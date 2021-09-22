using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Students
    {
        public string name;
        public string department;
        public double gpa;
    

    public Students(string aName, string aDepartment, double aGpa)
    {
        name = aName;
        department = aDepartment;
        gpa = aGpa;
        }

        public bool HasHonors()
        {
            if (gpa >= 3.5)
            {
                return true;
            }
            return false;
        }

    }
}
