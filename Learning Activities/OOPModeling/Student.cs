using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPModeling
{
    public class Student
    {
        public string _firstName;
        public string _lastName;
        public string _studentId;
        public int _noOfClassesCurrentlyEnrolled;
        public int MAX_CLASSES_STUDENT_IS_ALLOWED = 4;

        public WeberClass[] _weberClasses;

        public Student()
        {
            _weberClasses = new WeberClass[MAX_CLASSES_STUDENT_IS_ALLOWED];
            _noOfClassesCurrentlyEnrolled = 0;
        }

        public Student(string studentId, string firstName, string lastName)
        {
            _studentId = studentId;
            _lastName = lastName;
            _firstName = firstName;
            _noOfClassesCurrentlyEnrolled = 0;
            _weberClasses = new WeberClass[MAX_CLASSES_STUDENT_IS_ALLOWED];
        }

        public void RegistersForAClass(WeberClass weberClass)
        {
            if (IsMaxStudentLimitReached())
                Console.WriteLine("*** Student is registered for maximum courses. Try next semester. ***");
            else
            {
                // the student stil cannot register if class is full
                if (weberClass.IsMaxCapacityReached())
                    Console.WriteLine($"*** Sorry {_firstName} {_lastName}, the class [{weberClass._className}] enrollement limit is reached. Try next semester. ***");
                else
                {
                    _weberClasses[_noOfClassesCurrentlyEnrolled] = weberClass;
                    weberClass._students[weberClass._currentEnrollment] = this;
                    _noOfClassesCurrentlyEnrolled++;
                    weberClass._currentEnrollment++;
                }
            }
        }

        public bool IsMaxStudentLimitReached()
        {
            return _noOfClassesCurrentlyEnrolled >= 4;
        }

        public void PrintStudentInfo()
        {
            Console.WriteLine($"\n*** Printing Student Info {_firstName} {_lastName} ***");
            foreach (var f in GetType().GetFields().Take(5))
            {
                Console.WriteLine($"{char.ToUpper(f.Name.Replace("_", "")[0]) + f.Name.Substring(2)}: {f.GetValue(this)}");
            }
        }

        public void PrintClassesInformationForStudent()
        {
            Console.WriteLine($"\n******** Classes for Student {_firstName} {_lastName} ********");
            _weberClasses.Where(c => c != null).ToList().ForEach(c =>
            {
                c.PrintClassInfo();
            });
        }
    }
}
