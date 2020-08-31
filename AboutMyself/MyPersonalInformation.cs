using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AboutMyself
{
    public enum MonthOfYear
    {
        JANUARY,
        FEBRUARY,
        MARCH,
        APRIL,
        MAY,
        JUNE,
        JULY,
        AUGUST,
        SEPTEMBER,
        OCTOBER,
        NOVEMBER,
        DECEMBER
    }
    public class MyPersonalInformation
    {
        public string MyName()
        {
            return "Spencer Rosenvall";
        }

        public void WhatImportantAmIDoingThisMonth(MonthOfYear monthOfYear)
        {
            switch (monthOfYear)
            {
                case MonthOfYear.JANUARY: Console.WriteLine("Trying to stick to my New Year's resolution."); break;
                case MonthOfYear.FEBRUARY: Console.WriteLine("Trying not to freeze to death."); break;
                case MonthOfYear.MARCH: Console.WriteLine("Trying to survive the first month of family birthday parties."); break;
                case MonthOfYear.APRIL: Console.WriteLine("Getting Married."); break;
                case MonthOfYear.MAY: Console.WriteLine("Trying to survive the second month of family birthday parties."); break;
                case MonthOfYear.JUNE: Console.WriteLine("Enjoying the mild sun while it lasts."); break;
                case MonthOfYear.JULY: Console.WriteLine("Doing as many watersports as possible while it's hot and crispy outside."); break;
                case MonthOfYear.AUGUST: Console.WriteLine("Focusing on the last semester for graduation."); break;
                case MonthOfYear.SEPTEMBER: Console.WriteLine("Enjoying the warm weather as much as possible before the cold comes."); break;
                case MonthOfYear.OCTOBER: Console.WriteLine("Celebrating my brother's birthday month with him."); break;
                case MonthOfYear.NOVEMBER: Console.WriteLine("Celebrating my birthday month and trying to pretend the cold DNE."); break;
                case MonthOfYear.DECEMBER: Console.WriteLine("Thanks humanity for utilizing holidays as distractions during the cold/depressing time of year."); break;
                default: throw new Exception($"MonthOfYear doesn't contain: { monthOfYear }");
            }
        }

    }
}
