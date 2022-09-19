using System;

namespace Training
{
    class Train
    {
        static void Main(string[] args)
        {
            double e = 4.68;
            int q = 1;
            int qq = 13;
            int qqq = 49;
            int g = 7;
            int gg = 15;
            int ggg = 100;
            Console.WriteLine("введите цифру:");
            int i = Convert.ToInt32(Console.ReadLine());
            int ii = Convert.ToInt32(Console.ReadLine());
            int iii = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение y: ");
            int y = Convert.ToInt32(Console.ReadLine());
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
            foreach (var answer in answers)
            {
                Console.WriteLine($"{e}");
                Console.WriteLine($"вы ввели: {i}");
                Console.WriteLine($"{ii}");
                Console.WriteLine("вот какое число выввели");
                Console.WriteLine($"{answer}");
                Console.WriteLine($"{q} {qq} {qqq}");
                Console.WriteLine($"{g}  {gg}  {ggg}");
                Console.WriteLine($"{i}  {ii}  {iii}");
                Console.WriteLine($"y = {7 * x * 2 + 3 * x + 6}");
                Console.WriteLine($"x = {12 * y * 2 + 7 * y + 12}");
            }
            foreach (var numeral in numerals)
            {
                counter++;
                Console.WriteLine($"{counter}. {numeral}");
            }
        }
    }
}