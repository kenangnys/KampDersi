using System;

namespace RefAndOutParameters
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------ref------------");
            Number num = new Number();

            int num1 = 10;
            Console.WriteLine(num1);
            num.Numberss(num1);
            Console.WriteLine(num1);

            Referans nums = new Referans();

            int num3 = 10;
            int num4 = 20;
            Console.WriteLine(num3);
            nums.Numbers(ref num3, ref num4);
            Console.WriteLine(num3);

            Console.WriteLine("-------------out------------");

            int num5 = 10;
            int num6 = 20;
            Console.WriteLine(num5+num6);
            Out Ot = new Out();

            Ot.outt(out num6);
            Console.WriteLine(num5+num6);



        }
    }
}
