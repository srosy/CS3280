using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPModeling
{
    public class WeberClass
    {
        //fields, operations. all fields are public.
        public string _classID;
        public string _className;
        public string _classNumber;
        public Instructor _instructor;
        public string _department;
        public int _maxCapacity;
        public int _currentEnrollment;
        public int _MAX_STUDENT_CAPACITY = 30;

        public Student[] _students;

        // default ctor
        public WeberClass()
        {
            _students = new Student[_MAX_STUDENT_CAPACITY];
        }

        // ctor with parameters
        public WeberClass(string classId, string className, string classNumber, Instructor instructor, string department, int maxCapacity)
        {
            _classID = classId;
            _className = className;
            _classNumber = classNumber;
            _instructor = instructor;
            _department = department;
            _maxCapacity = maxCapacity;
            _currentEnrollment = 0;
            _students = new Student[maxCapacity];
        }

        //operations
        public void PrintClassInfo()
        {
            Console.WriteLine($"\n*** Weber Class Info for {_className} ***");

            GetType().GetFields().ToList().ForEach(f =>
            {
                if (f.FieldType.Name.ToLower().Equals("instructor"))
                {
                    var instructor = f.GetValue(this) as Instructor;
                    Console.WriteLine($"{char.ToUpper(f.Name.Replace("_", "")[0]) + f.Name.Substring(2)}: {instructor._firstName} {instructor._lastName}");
                }
                else
                    Console.WriteLine($"{char.ToUpper(f.Name.Replace("_", "")[0]) + f.Name.Substring(2)}: {f.GetValue(this)}");
            });
        }

        public bool IsMaxCapacityReached()
        {
            return _currentEnrollment >= _maxCapacity;
        }

        public void PrintListOfStudentsForClass()
        {
            Console.WriteLine($"\n*** Weber Class Enrollement for {_className} ({_currentEnrollment}/{_maxCapacity}) ***");
            var index = 0;
            _students.Where(s => s != null).ToList().ForEach(s =>
            {
                index++;
                Console.WriteLine($"Student #{index} - {s._firstName} {s._lastName}");
            });
        }
    }
}
