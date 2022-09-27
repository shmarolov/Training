using System;

namespace Training
{
    class Train
    {
        static void Main(string[] args)
        {
            int counter = 0;

            List<string> answers = new List<string>();
            answers.Add(ArithmeticTasks.Method((10, 5)));

            List<double> numerals = new List<double>();
            numerals.Add(ArithmeticTasks.Kvadrat(5));
            numerals.Add(ArithmeticTasks.Krug(4));
            numerals.Add(ArithmeticTasks.Kub(2));
            numerals.Add(ArithmeticTasks.Kub2(2));
            numerals.Add(ArithmeticTasks.Sredne(3, 7));
            numerals.Add(ArithmeticTasks.Sredne2(3, 7));
            numerals.Add(ArithmeticTasks.Plotno(10, 5));
            numerals.Add(ArithmeticTasks.PlotnoNas(15342, 5432));
            numerals.Add(ArithmeticTasks.Gipot(3, 7));
            numerals.Add(ArithmeticTasks.Kolco(32, 53));
            numerals.Add(ArithmeticTasks.PerimetTre(15, 10));
            numerals.Add(ArithmeticTasks.PerimetTra(15, 10, 20));
            numerals.Add(ArithmeticTasks.PerPramU(14, 11));
            numerals.Add(ArithmeticTasks.DlinPramU(14, 11));
            numerals.Add(ArithmeticTasks.ObPramP(12, 11, 17));
            numerals.Add(ArithmeticTasks.PloPramP(12, 11, 17));
            numerals.Add(ArithmeticTasks.RastKor(12, 11, 17, 13));
            numerals.Add(ArithmeticTasks.PerTrap(12, 11, 17, 13));
            numerals.Add(ArithmeticTasks.PloTrap(12, 11, 90));
            numerals.Add(ArithmeticTasks.SlojPerTre(12, 11, 17, 13, 14, 15));
            numerals.Add(ArithmeticTasks.Konfety(2, 1, 3, 100, 150, 120));
            numerals.Add(ArithmeticTasks.Pc(1200, 1100, 1700, 1300));
            numerals.Add(ArithmeticTasks.Oldsqr(12, 16));
            numerals.Add(ArithmeticTasks.OldsqrRaz(12, 16));
            numerals.Add(ArithmeticTasks.OldsqrRaz2(12, 16));
            numerals.Add(ArithmeticTasks.Vtrecha(10, 20));
            numerals.Add(ArithmeticTasks.Oprej(20, 30, 10));
            numerals.Add(ArithmeticTasks.CelcF(20));
            numerals.Add(ArithmeticTasks.CelcK(20));
            numerals.Add(ArithmeticTasks.FarC(450));
            numerals.Add(ArithmeticTasks2.KgCent(50));
            numerals.Add(ArithmeticTasks2.KgTon(380));
            numerals.Add(ArithmeticTasks2.MKm(542));
            numerals.Add(ArithmeticTasks2.DayWeek(30));
            numerals.Add(ArithmeticTasks2.SekH(17652));
            numerals.Add(ArithmeticTasks2.HourM(1499));
            numerals.Add(ArithmeticTasks2.MinS(421));
            numerals.Add(ArithmeticTasks2.Square(543, 130));
            numerals.Add(ArithmeticTasks2.DayMon(30));
            numerals.Add(ArithmeticTasks2.DayMon2(32));
            numerals.Add(ArithmeticTasks2.TwoDig1(25));
            numerals.Add(ArithmeticTasks2.TwoDig2(25));
            numerals.Add(ArithmeticTasks2.TwoDig3(25));
            numerals.Add(ArithmeticTasks2.TwoPer(25));
            numerals.Add(ArithmeticTasks2.ThreeDig1(252));
            numerals.Add(ArithmeticTasks2.ThreeDig2(252));
            numerals.Add(ArithmeticTasks2.ThreeDig3(252));
            numerals.Add(ArithmeticTasks2.ThreeRev2(252, 252));


            List<string> mathStrings = new List<string>();
            mathStrings.Add(ArithmeticTasks2.MonDay(5));
            mathStrings.Add(ArithmeticTasks2.ThreeRev("252").ToString());

            foreach (var numeral in numerals)
            {
                counter++;
                Console.WriteLine($"{counter}. {numeral}");
            }

            foreach (var mathstring in mathStrings)
            {
                counter++;
                Console.WriteLine($"{counter}. {mathstring}");
            }
        }
    }
}