namespace LineComparisionProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Comparison comparison = new Comparison(4, 8, 12, 16); ;
            double line1 = comparison.CalcLength();
            Console.WriteLine("Length of 1st Line: " + line1);
            Comparison linecomparison = new Comparison(4, 8, 12, 16);
            double line2 = linecomparison.CalcLength();
            Console.WriteLine("Length of 2nd Line: " + line2);
            if (line1 == line2)
                Console.WriteLine("Both Lines are Equal");
            else
                Console.WriteLine("Both Lines are not Equal");
        }
    }
}