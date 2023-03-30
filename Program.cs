using System;

namespace ParseAndTryParse
{
    class Program
    {
        static void Main(string[] args) 
        {
            Program.EvenNumber(20);

            Program P = new Program();
            int Sum = P.Add(12, 23);

            Console.WriteLine("Sum = {0}", Sum);

        }

        //Instance Method
        public int Add(int FN, int SN)
        {
            return FN + SN;
        }

        //Static Method
        public static void EvenNumber(int Target)
        {
            int start = 0;

            while(start <= Target)
            {
                Console.WriteLine(start);
                start = start + 2;
            }
          
        }
    }
}
