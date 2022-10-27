using System;

namespace Day13Generics

{
    public class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Find Maximum of given inputs");
            int[] intArray = { 190, 521, 607, 400, 20 };
            GenericMaximum<int> generic = new GenericMaximum<int>(intArray);
            generic.PrintMaxValue();
            double[] doubleArray = { 40.2, 3.4, 6.2, 75.5, 5.86 };
            GenericMaximum<double> genericDouble = new GenericMaximum<double>(doubleArray);
            genericDouble.PrintMaxValue();
            string[] stringArray = { "CAMERA", "HELLO", "CAT", "BIKE", "WINDOW" };
            GenericMaximum<string> genericString = new GenericMaximum<string>(stringArray);
            genericString.PrintMaxValue();
            Console.ReadLine();
        }
    }
}

