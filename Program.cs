using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Трикутник
{
    class Program
    {
        static void Main(string[] args)
        {
            int a1; int b1;
            int a2; int b2;
            int a3; int b3;

            Console.WriteLine("Програма для обчислення довжин сторiн трикутника та кутiв за його координатами");
            Console.WriteLine("Введiть х - координату вершини А");
            a1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть y - координату вершини А");
            b1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введiть х - координату вершини B");
            a2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть y - координату вершини B");
            b2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Введiть х - координату вершини C");
            a3 = int.Parse(Console.ReadLine());
            Console.WriteLine("Введiть y - координату вершини C");
            b3 = int.Parse(Console.ReadLine());

            int x1; int y1;
            int x2; int y2;
            int x3; int y3;

            x1 = a2 - a1; y1 = b2 - b1;// AB
            x2 = a3 - a2; y2 = b3 - b2;// BC
            x3 = a1 - a3; y3 = b1 - b3;// CA

            double lengthAB;   double lengthBC;  double lengthCA;

            lengthAB = Math.Sqrt(Math.Pow(x1, 2) + Math.Pow(y1,2));
            lengthBC = Math.Sqrt(Math.Pow(x2, 2) + Math.Pow(y2, 2));
            lengthCA = Math.Sqrt(Math.Pow(x3, 2) + Math.Pow(y3, 2));

            Console.WriteLine("Довжина AB - " + Math.Round(lengthAB,2));
            Console.WriteLine("Довжина BC - " + Math.Round(lengthBC,2));
            Console.WriteLine("Довжина CA - " + Math.Round(lengthCA,2));

            double COSalfa; double COSbeta; double COSgamma;

            COSalfa = (x1 * x2 + y1 * y2) / (lengthAB * lengthBC);
            COSbeta = (x2 * x3 + y2 * y3) / (lengthBC * lengthCA);
            COSgamma = (x3 * x1 + y3 * y1) / (lengthCA * lengthAB);

            Console.WriteLine("Косинус кута А - " + Math.Round(COSalfa,3));
            Console.WriteLine("Косинус кута B - " + Math.Round(COSbeta, 3));
            Console.WriteLine("Косинус кута C - " + Math.Round(COSgamma, 3));

            double gradus1 = Math.Acos(COSalfa) * 180 / (2 * Math.PI);
            double gradus2 = Math.Acos(COSbeta) * 180 / (2 * Math.PI);
            double gradus3 = Math.Acos(COSgamma) * 180 / (2 * Math.PI);
            Console.WriteLine("Кут 1 - " + (Math.Round(gradus1,2)));
            Console.WriteLine("Кут 2 - " + (Math.Round(gradus2, 2)));
            Console.WriteLine("Кут 3 - " + (Math.Round(gradus3, 2)));
            Console.WriteLine("Сума кутiв - " + (gradus1+gradus2+gradus3));

            Console.ReadLine();
        }
    }
}
