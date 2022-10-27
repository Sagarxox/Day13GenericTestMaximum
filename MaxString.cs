using System;

namespace Day13Generics
{
    public class FindMaxString
    {

        public void MaximumString(string FirstVal, string Secondval, string ThirdVal)
        {
            if (FirstVal.CompareTo(Secondval) > 0 && FirstVal.CompareTo(ThirdVal) > 0 ||
               FirstVal.CompareTo(Secondval) >= 0 && FirstVal.CompareTo(ThirdVal) > 0 ||
               FirstVal.CompareTo(Secondval) > 0 && FirstVal.CompareTo(ThirdVal) >= 0)
            {
                Console.WriteLine("first value is greatest");
            }
            if (Secondval.CompareTo(FirstVal) > 0 && Secondval.CompareTo(ThirdVal) > 0 ||
               Secondval.CompareTo(FirstVal) >= 0 && Secondval.CompareTo(ThirdVal) > 0 ||
               Secondval.CompareTo(FirstVal) > 0 && Secondval.CompareTo(ThirdVal) >= 0)
            {
                Console.WriteLine("Second value is greatest");
            }
            if (ThirdVal.CompareTo(FirstVal) > 0 && ThirdVal.CompareTo(Secondval) > 0 ||
               ThirdVal.CompareTo(FirstVal) >= 0 && ThirdVal.CompareTo(Secondval) > 0 ||
               ThirdVal.CompareTo(FirstVal) > 0 && ThirdVal.CompareTo(Secondval) >= 0)
            {
                Console.WriteLine("third value is greatest");
            }



        }
    }


}

