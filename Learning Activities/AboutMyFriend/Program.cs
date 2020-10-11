using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using AboutMyself;

namespace AboutMyFriend
{
    class Program
    {
        static void Main(string[] args)
        {
            Print("*** Starting AboutMyFriend Program ***\n\n");

            MyPersonalInformation personalInfo = new MyPersonalInformation();
            Print($"Introducing my amigo...{personalInfo.MyName()}!\n", true);

            Print($"Here's what {personalInfo.MyName()} is up to for the months of {MonthOfYear.September}," +
                $" {MonthOfYear.October}, {MonthOfYear.November}, and {MonthOfYear.December}:\n", true);

            Print($"In {MonthOfYear.September}, {GetFirstName(personalInfo.MyName())} is: ");
            personalInfo.WhatImportantAmIDoingThisMonth(MonthOfYear.September);

            Print($"In {MonthOfYear.October}, {GetFirstName(personalInfo.MyName())} is: ");
            personalInfo.WhatImportantAmIDoingThisMonth(MonthOfYear.October);

            Print($"In {MonthOfYear.November}, {GetFirstName(personalInfo.MyName())} is: ");
            personalInfo.WhatImportantAmIDoingThisMonth(MonthOfYear.November);

            Print($"In {MonthOfYear.December}, {GetFirstName(personalInfo.MyName())} is: ");
            personalInfo.WhatImportantAmIDoingThisMonth(MonthOfYear.December);

            Print($"\nWhat a great guy {GetFirstName(personalInfo.MyName())} is!", true);

            Print("\n*** Program Finished ***", true);

            Console.ReadLine();
        }

        public static void Print(string message, [Optional] bool printLn)
        {
            if (printLn)
                Console.WriteLine(message);
            else
                Console.Write(message);
        }

        public static string GetFirstName(string fullName)
        {
            return fullName.Split(' ')[0];
        }
    }
}
