using System;
using System.Collections.Generic;
using System.Text;

namespace CS3280InterfaceRunTimePoly
{
    //TODO: Implement IComparable interface. 
    public class Person : IComparable
    {
        string FirstName { get; set; }
        string LastName { get; set; }
        string SSN { get; set; }

        public Person() { }

        public Person(string firstname, string lastname, string ssn)
        {
            FirstName = firstname;
            LastName = lastname;
            SSN = ssn;
        }

        public override string ToString()
        {
            return "*******" + FirstName + " " + LastName + " " + SSN;
        }

        // The comparision definition relies on SSN. 

        public int CompareTo(object obj)
        {
            if (obj is Person)
            {
                Person p = obj as Person;
                return string.Compare(this.SSN, p.SSN);
            }
            return -1;
        }
    }
}

