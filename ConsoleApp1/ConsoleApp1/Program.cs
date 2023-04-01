using System;

namespace ConsoleApp1
{
    class Figura
    {
        double par1, par2, par3;
        public Figura(double promien)
        {
            par1 = promien;
        }
        public Figura(double bokA, double bokB)
        {
            par1 = bokA; par2 = bokB; 
        }
        public Figura(double bokA, double bokB, double bokC)
        {
            par1 = bokA; par2 = bokB; par3 = bokC;  
        }
        public Figura(Figura figa)
        {
            par1 = figa.par1;
            par2 = figa.par2;
            par3 = figa.par3;
        }
        public double ObliczObwod()
        {
            if (par2 == 0)
                return 2 * Math.PI * par1;
            else if (par3 != 0)
                return par1 + par2 + par3;
            else
                return 2 * par1 + 2 * par2;
        }
        public double parametr1
        {
            set
            {
                par1 = value;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Figura p1 = new Figura(1);
            Figura p2 = new Figura(4, 5);
            Figura p3 = new Figura(2, 3, 5);
            Figura p4 = new Figura(p3);
            Figura p5 = p3;

            Console.WriteLine(p1.ObliczObwod());
            Console.WriteLine(p2.ObliczObwod());
            Console.WriteLine(p3.ObliczObwod());
            Console.WriteLine(p4.ObliczObwod());
            Console.WriteLine(p5.ObliczObwod());
            p3.parametr1 = 1;
            Console.WriteLine(p3.ObliczObwod());
            Console.WriteLine(p4.ObliczObwod());
            Console.WriteLine(p5.ObliczObwod());


            Console.ReadKey();
        }
    }
}
