using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

namespace _02.Bunnies
{
    class Bunnies
    {
        static void Main(string[] args)
        {
            List<int> cages = new List<int>();

            while (true)
            {
                string inputBunnies = Console.ReadLine();
                if (inputBunnies == "END")
                {
                    break;
                }
                else
                {
                    cages.Add(int.Parse(inputBunnies));
                }
            }

            //foreach (int buniies in cages)
            //{
            //    Console.WriteLine(buniies);
            //
            int cycleCounter = 0;
            while (true)
            {

                int sum = 0;
                for (int i = 0; i <= cycleCounter; i++)
                {
                    sum += cages[i];
                }
                int bunnieSum = 0;
                BigInteger bunnieProduct = 1;
                if (cycleCounter + 1 + sum > cages.Count)
                {
                    break;
                }
                for (int i = cycleCounter + 1; i < cycleCounter + 1 + sum; i++)
                {
                    bunnieSum += cages[i];
                    bunnieProduct *= cages[i];
                }
                StringBuilder cagesResult = new StringBuilder();
                cagesResult.Append(bunnieSum.ToString());
                cagesResult.Append(bunnieProduct.ToString());
                for (int i = cycleCounter + 1 + sum; i < cages.Count; i++)
                {
                    cagesResult.Append(cages[i]);
                }
                cagesResult.Replace("0", string.Empty);
                cagesResult.Replace("1", string.Empty);
                //Console.WriteLine(bunnieSum);
                //Console.WriteLine(bunnieProduct);
                cages.Clear();
                for (int i = 0; i < cagesResult.Length; i++)
                {
                    cages.Add(cagesResult[i] - '0');
                }
                cycleCounter++;
            }

            for (int i = 0; i < cages.Count; i++)
            {
                if (i < cages.Count - 1)
                {
                    Console.Write("{0} ", cages[i]);
                }
                else
                {
                    Console.Write("{0}", cages[i]);
                }
            }
            //Console.WriteLine();
            //Console.WriteLine(cagesResult.ToString());
        }
    }
}
