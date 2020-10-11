using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPModeling
{
    public class ClassCatalog
    {
        public WeberClass[] _weberClasses;
        public int _curentClassesCount;
        public int MAX_UNIVERSITY_CLASS_CAPACITY = 100;

        public ClassCatalog()
        {
            _weberClasses = new WeberClass[MAX_UNIVERSITY_CLASS_CAPACITY];
            _curentClassesCount = 0;
        }

        public ClassCatalog(int universityCapacity)
        {
            _weberClasses = new WeberClass[universityCapacity];
            _curentClassesCount = 0;
        }

        public void PrintCatalog()
        {
            Console.WriteLine("\n*** Printing the Course Catalog ***");
            for (int i = 0; i < _weberClasses.Length; i++)
            {
                WeberClass weberClass = _weberClasses[i];
                if (weberClass != null)
                {
                    weberClass.PrintClassInfo();
                }
            }
        }
    }
}
