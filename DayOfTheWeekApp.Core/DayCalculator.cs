using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace DayOfTheWeekApp.Core
{
    public class DayCalculator
    {
        
        public DayOfTheWeek CalcudateDayOfTheWeek(DateTimeOffset date)
        {
            var days = date.Day;
            var month = date.Month;
            var year = date.Year;

            var listOfParameters = new List<int>{ 0, 3, 2, 5, 0, 3, 5, 1, 4, 6, 2, 4 };
           
            year -= (month < 3) ? 1 : 0;

            var calculatedValue = (year + year / 4 - year / 100 + year / 400 + listOfParameters[month - 1] + days) % 7;
           
      
            return (DayOfTheWeek)(calculatedValue-1);

        





        }


    }
}
