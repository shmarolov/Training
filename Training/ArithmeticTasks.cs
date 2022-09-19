using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training
{
    internal static class ArithmeticTasks
    {
       internal static string Method((int x, int y) tuple)
        {
            var res = (x: tuple.y, y: tuple.x);
            return $"x={res.x}, y={res.y}";
        }
       internal static int Kvadrat(int s)
        {
            int p = 4 * s;
            return p;
        }
        internal static int Krug(int r)
        {
            int d = 2 * r;
            return d;
        }
        internal static int Kub(int a)
        {
            int v = a * a * a;
            return v;
        }
        internal static int Kub2(int a)
        {
            int s = 6 * a * a;
            return s;
        }
        internal static int Sredne(int x, int y)
        {
            int s = x + y / 2;
            return s;
        }
        internal static int Sredne2(int x, int y)
        {
            int d = x * y;
            int s = (int)Math.Sqrt(d);
            return s;
        }
        internal static int Plotno(int x, int y)
        {
            return x / y;
        }
        internal static int PlotnoNas(int x, int y) { return x / y; }
        internal static double Gipot(int x, int y)
        {
            double c = Math.Sqrt(x + y);
            return c;
        }
        internal static double Kolco(int x, int y)
        {
            double Pi = 3.14;
            double k = (Pi * x * x) - (Pi * y * y);
            return k;
        }
        internal static double PerimetTre(int x, int y)
        {
            double p = Math.Sqrt((x * x) + (y * y)) + x + y;
            return p;
        }
        internal static double PerimetTra(int x, int y, int z)
        {
            var p = z * Math.Sqrt(x + y) / 2;
            return p;
        }
        internal static double PerPramU(int x, int y)
        {
            double P = 2 * (x * y);
            return P;
        }
        internal static double DlinPramU(int x, int y)
        {
            double p = Math.Sqrt((x * x) + (y * y));
            return p;
        }
        internal static double ObPramP(int x, int y, int z)
        {
            return x * y * z;
        }
        internal static double PloPramP(int x, int y, int z) { return 2 * (x * y + y * z + z * x); }
        internal static double RastKor(int x, int y, int z, int h) { return Math.Sqrt((x - y) * (x - y)) + ((z - h) * (z - h)); }
        internal static double PerTrap(int x, int y, int z, int h) { return x * y * z * h; }
        internal static double PloTrap(int x, int y, int z) 
        {
            double tg = Math.Tan(z); 
            double d = (y - x) / 2; 
            double h = tg * d; 
            double s = (d * h) + (x * h); 
            return s;
        }
        internal static double SlojPerTre(int x0, int y0, int x1, int y1, int x2, int y2)
        {
            double a = Math.Sqrt(Math.Pow((x0 + x1), 2.0) + Math.Pow(y0 + y1, 2.0));
            double b = Math.Sqrt(Math.Pow((x1 + x2), 2.0) + Math.Pow(y1 + y2, 2.0));
            double c = Math.Sqrt(Math.Pow((x2 + x0), 2.0) + Math.Pow(y2 + y0, 2.0));
            double P = (a + b + c);
            return P;
        }
        internal static double Konfety(int x, int y, int z, int xx, int yy, int zz)
        {
            double xxx = x * xx; // x это кг конфет xx это сумма конфет за кг
            double yyy = y * yy;
            double zzz = z * zz;
            double sum = xxx + yyy + zzz;
            return sum;
        }
        internal static double Pc(int x, int y, int z, int h)
        {
            double n = x + y + z + h; //общая стоимость пк
            double p = n * 3; //стоимость за 3 пк
            return p;
        }
        internal static double Oldsqr(int x, int y)
        {
            return Math.Sqrt(x + y);
        }
        internal static double OldsqrRaz(int x, int y)
        {
            double xysqr = Math.Sqrt(x + y);
            double xraz = xysqr - x;
            return xraz;
        }
        internal static double OldsqrRaz2(int x, int y)
        {
            double xysqr = Math.Sqrt(x + y);
            double yraz = xysqr - y;
            return yraz;
        }
        internal static double Vtrecha(int x, int y)
        {
            double rast = 100;
            double kmh = x + y;
            double vstr = rast / kmh;
            return vstr;
        }
        internal static double Oprej(int x, int y, int z)
        {
            double d = z + (x - y) * 0.5;
            return d;
        }
        internal static double CelcF(int x)
        {
            double far = x * 1.8 + 32;
            return far;
        }
        internal static double CelcK(int x)
        {
            double kelv = x + 273;
            return kelv;
        }
        internal static double FarC(int x)
        {
            double celc = (x - 32) * 5 / 9;
            return celc;
        }
    }
}
