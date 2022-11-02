using DayOfTheWeekApp.Core;
using System;

namespace DayOfTheWeekApp
{
    public class DayGuesser
    {

        public DayCalculator Calculator { get; set; }

        public DateTimeOffset UserDateOfBirth { get; set; }

        public  DayOfTheWeek UserDayOfTheWeek { get; set; }

        public void IntroduceTheApplication()
        {
            System.Console.WriteLine("Witam, chciałbym Ci wyliczyć dzień tygodnia na podstawie Twojej daty urodzenia");
            Calculator = new DayCalculator();


        }
        public void AskUserDateOfBirth()
        {
            System.Console.WriteLine("Podaj mi swoją datę urodzenia: ");
            
            
            //czytanie daty urodzenia
            var userDate = Console.ReadLine();


        var succeded =  DateTimeOffset.TryParse(userDate, out var date);


            if (succeded)
            {
                UserDateOfBirth = date;
                return;
            }

            Console.WriteLine("Format daty zły. Podaj ponownie format dd/mm/yyyy");
            
            AskUserDateOfBirth();




        }
        public void CalculateDateOfTheWeek()
        {
            if (UserDateOfBirth ==null)
            {
                Console.WriteLine("Próbowano obliczyć dzien tygodnia bez podania daty urodzenia");
                return;
            }

         UserDayOfTheWeek  = Calculator.CalcudateDayOfTheWeek(UserDateOfBirth);

            


            

        }
        public void PrintDateOfTheWeek()
        {
            Console.WriteLine("Obliczony dzień tygodnia to: " + UserDayOfTheWeek.ToPolishString());

        }

    }
}
