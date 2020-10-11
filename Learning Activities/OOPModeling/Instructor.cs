using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPModeling
{
    public class Instructor
    {
        //fields + operations
        public string _firstName;
        public string _lastName;
        public string _wNumber;
        public string _department;

        public Instructor() { }

        public Instructor(string fname, string lname, string wnumber, string dept)
        {
            _firstName = fname;
            _lastName = lname;
            _wNumber = wnumber;
            _department = dept;
        }

        public void OffersACourse(ClassCatalog catalog, WeberClass weberClass)
        {
            weberClass._instructor = this;
            weberClass._department = _department;
            catalog._weberClasses[catalog._curentClassesCount] = weberClass;
            catalog._curentClassesCount++;
        }

        public void OffersACourse(ClassCatalog catalog, string classID, string className, string classNum, int classCapacity)
        {
            WeberClass weberClass = new WeberClass(classID, className, classNum, this, _department, classCapacity);
            catalog._weberClasses[catalog._curentClassesCount] = weberClass;
            catalog._curentClassesCount++;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"*** Printing Instructor Info for {_firstName} {_lastName} ***");
            foreach (var f in GetType().GetFields())
            {
                Console.WriteLine($"{char.ToUpper(f.Name.Replace("_", "")[0]) + f.Name.Substring(2)}: {f.GetValue(this)}");
            }
        }
    }
}
