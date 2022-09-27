using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    internal static class ArithmeticTasks2
    {
        internal static double KgCent(int x)
        {
            double k = x / 100; //этой формулой мы вычеслили центнер
            return k;
        }

        internal static double KgTon(int x)
        {
            double t = x / 1000; //формула кг тонна
            return t;
        }

        internal static double MKm(int x)
        {
            double k = x / 1000; //формула метр киломметр
            return k;
        }

        internal static double DayWeek(int x)
        {
            double w = x / 7; //формула день неделя
            return w;
        }

        internal static double SekH(int x)
        {
            double h = x / 3600; //формула секунда час
            return h;
        }

        internal static double HourM(int x)
        {
            double m = x / 60; //формула час минут
            return m;
        }

        internal static double MinS(int x)
        {
            double s = x / 60; //формула минута секунда
            return s;
        }

        internal static double Square(int x, int y)
        {
            double s = x / y; 
            return s;
        }

        internal static double DayMon(int x)
        {
            double w = x / 7;
            return w;
        }

        internal static double DayMon2(int x)
        {
            double w = x / 7 + 1;
            return w;
        }

        internal static string MonDay(int m)
        {
            DateTime dt = DateTime.Now;
            int n = dt.Month - m % 12;
            string month = "";
            switch (n)
            {
                case 1: month = "Январь"; break;
                case 2: month = "Февраль"; break;
                case 3: month = "Март"; break;
                case 4: month = "Апрель"; break;
                case 5: month = "Май"; break;
                case 6: month = "Июнь"; break;
                case 7: month = "Июль"; break;
                case 8: month = "Август"; break;
                case 9: month = "Сентябрь"; break;
                case 10: month = "Октябрь"; break;
                case 11: month = "Ноябрь"; break;
                case 12: month = "Декабрь"; break;
            }
            return $"Это был месяц: + {month}"; //я это скопировал, так как это стринг, оно будет в самом внизу откладки
        }

        internal static double TwoDig1(int x)
        {
            int d = x / 10; //обнаружили суольуо десятков 
            return d;
        }

        internal static double TwoDig2(int x)
        {
            int o = x % 10; //обнаружили сколько едениц
            return o;
        }

        internal static double TwoDig3(int x)
        {
            int d = x / 10;
            int o = x % 10;
            int s = d + o; //общая сумма
            return s;
        }

        internal static double TwoPer(int x)
        {
            int d = x / 10;
            int o = (x % 10) * 10;
            int s = d + o; //мы сделали перестнавку двухзначной цыфры
            return s;
        }

        internal static double ThreeDig1(int x)
        {
            int d = x / 10; //обнаружили сколько десятков 
            return d;
        }

        internal static double ThreeDig2(int x)
        {
            int o = x % 10; //обнаружили сколько едениц
            return o;
        }

        internal static double ThreeDig3(int x)
        {
            int d = x / 10;
            int o = x % 10;
            int s = d + o; //общая сумма
            return s;
        }

        internal static string ThreeRev(string x)
        {
            Int64 value = Int64.Parse(x);
            Int64 reverse_val = Int64.Parse(new string(value.ToString().Reverse().ToArray()));
            return $"Обратная запись числа: {reverse_val}"; //так же скопировал, не моя идея, но переделал под программу
                                                            //так же будет внизу откладки
        }

        internal static double ThreeRev2(int x,int y)
        {
            y = x;
            x = x / 10;
            y = y % 10;
            x = y * 100 + x;
            return x;
        }


    }
}
