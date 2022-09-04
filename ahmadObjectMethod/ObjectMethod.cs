using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ahmadObjectMethod
{
    internal class ObjectMethod
    {
        public string name; 
        public int level; 
        public double CGPA;
        public ObjectMethod(string aName, int aLevel, double aCGPA)
        {
            name = aName;
            level = aLevel;
            CGPA = aCGPA;
        }
        public bool hasHonours()
        {
            if(CGPA >= 6.1)
            {
                return true;
            }
            return false;
        }
            }
}
