using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlStructure
{
    public enum DaysOfWeek3280
    {
        SUNDAY,
        MONDAY,
        TUESDAY,
        WEDNESDAY,
        THURSDAY,
        FRIDAY,
        SATURDAY
    };

    public class ClassSchedule
    {
        public void WhatAreYouDoingToday(DaysOfWeek3280 day)
        {
            switch (day)
            {
                case DaysOfWeek3280.MONDAY:
                    Console.WriteLine("In 3550");
                    break;
                case DaysOfWeek3280.TUESDAY:
                    Console.WriteLine("In 3280 and 3750");
                    break;
                case DaysOfWeek3280.WEDNESDAY:
                    Console.WriteLine("In 3550");
                    break;
                case DaysOfWeek3280.THURSDAY:
                    Console.WriteLine("In 3280 and 3750");
                    break;
                case DaysOfWeek3280.FRIDAY:
                    Console.WriteLine("In Office in 302F");
                    break;
                case DaysOfWeek3280.SATURDAY:
                    Console.WriteLine("At home");
                    break;
                default: break;
            }
        }
    }
}
