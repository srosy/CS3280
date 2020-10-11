using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace OOPModeling
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
             We will have one instruct that instructor will offer 2 courses.
             So catalog will hav tow courses. We will have 2 students. 
             First student will register for both the courses in catalog. 
             Second student will register for only one course in the catalog.
             */

            Instructor instructor1 = new Instructor("Arpit", "Christi", "W123456", "CS");
            //instructor1.PrintInfo();

            ClassCatalog classCatalog = new ClassCatalog();

            WeberClass weberClassFinance = new WeberClass("12345", "Finanace 101", "FIN101", instructor1, "Finanace", 30);
            instructor1.OffersACourse(classCatalog, weberClassFinance);
            instructor1.OffersACourse(classCatalog, "98765", "Windows OOP", "CS3290", 24);
            WeberClass smallSizedClass = new WeberClass("45612", "Small Class 101", "SM101", instructor1, "EE", 2);
            instructor1.OffersACourse(classCatalog, smallSizedClass);
            //weberClassFinance.PrintClassInfo();


            Student student1 = new Student("W99999", "Aric", "Doe");
            Student student2 = new Student("W88888", "Jane", "Lee");
            Student student3 = new Student("W10650098", "Spencer", "Rosenvall");

            student1.RegistersForAClass(classCatalog._weberClasses.FirstOrDefault());
            student1.RegistersForAClass(classCatalog._weberClasses[1]);
            student1.RegistersForAClass(smallSizedClass);

            student2.RegistersForAClass(classCatalog._weberClasses.FirstOrDefault());
            student2.RegistersForAClass(smallSizedClass);

            student3.RegistersForAClass(classCatalog._weberClasses[1]);
            student3.RegistersForAClass(smallSizedClass);

            classCatalog.PrintCatalog();

            student1.PrintStudentInfo();
            student2.PrintStudentInfo();

            student1.PrintClassesInformationForStudent();

            Console.WriteLine("\n***Total Enrollement in all courses ***");
            classCatalog._weberClasses.Where(c => c != null).ToList().ForEach(c =>
            {
                c.PrintListOfStudentsForClass();
            });

            Console.ReadLine();
            Console.ReadLine();
        }
    }
}
