using DayOfTheWeekApp.Core;
using System;

namespace DayOfTheWeekApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            var guesser = new DayGuesser();
            guesser.IntroduceTheApplication();
            guesser.AskUserDateOfBirth();
            guesser.CalculateDateOfTheWeek();
            guesser.PrintDateOfTheWeek();
                



        }
    }
}
