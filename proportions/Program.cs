using System;

namespace proportions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            proportions(2_904, 44_468);
        }

        public static void proportions(decimal a, decimal b)
        {
            //    if 44468 is 100 %
            //    then 2904 is x %


            decimal c = (a * 100) / b;
            decimal d = c * 700;
            decimal e = b / 4233;
            Console.WriteLine($"Result:\n\tif {neatResult(b)} is 100%\n\tthen {neatResult(a)} is {neatResult(c)}%\n");
            Console.WriteLine($"d: {neatResult(d)} No round {d}\n");
            Console.WriteLine($"e: {neatResult(e)} No round {e} \n");
        }

        public static string neatResult(decimal a)
        {
            string fmt1 = "#,##0.0";
            string result = Math.Round(a, 1).ToString(fmt1);
            return result;
        }
    }
}

