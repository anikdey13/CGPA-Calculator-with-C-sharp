using System;

namespace CGPAcalculator
{
    class Program
    {
        static void Main()
        {
            double CGPA;

            float first = Single.Parse(Console.ReadLine());
            float second = Single.Parse(Console.ReadLine());
            float third = Single.Parse(Console.ReadLine());
            float fourth = Single.Parse(Console.ReadLine());
            float fifth = Single.Parse(Console.ReadLine());
            float sixth = Single.Parse(Console.ReadLine());
            float seventh = Single.Parse(Console.ReadLine());
            float eighth = Single.Parse(Console.ReadLine());

            CGPA = (first + second + third + fourth + fifth + sixth + seventh + eighth) / (8);

            Console.WriteLine("Your CGPA is:" + String.Format("{0:0.00}", CGPA));

        }
    }
}