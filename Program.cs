namespace Day13Generics

{
    public class Program
    {
        static void Main(string[] args)
        {

            //FindMaxNum findMaxNum = new FindMaxNum();
            //findMaxNum.MaximumNum(10, 20, 30);
            //FindMaxFloat findMaxfloat = new FindMaxFloat();
            //findMaxfloat.MaximumFloat(33.6, 96.5, 7.8);

            FindMaxString findMaxstring = new FindMaxString();
            findMaxstring.MaximumString("ball", "hello", "bye");
        }
    }
}

