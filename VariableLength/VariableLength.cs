using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableLength
{
    class VariableLength
    {
        static void Main(string[] args)
        {
            string[] numbersInput = Console.ReadLine().Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries);
            int n = int.Parse(Console.ReadLine());
            Dictionary<char, int> codeTable = new Dictionary<char,int>();
            for (int i = 0; i < n; i++)
            {
                string codeTableLine = Console.ReadLine();
                string numberString = codeTableLine.Substring(1);
                int number = int.Parse(numberString);
                codeTable.Add(codeTableLine[0], number);
            }
            StringBuilder numbersToBin = new StringBuilder();
            for (int i = 0; i < numbersInput.Length; i++)
            {
                int number = int.Parse(numbersInput[i]);
                numbersToBin.Append(Convert.ToString(number, 2).PadLeft(8, '0'));
            }
            string binaryString = numbersToBin.ToString();
            binaryString = binaryString.TrimEnd('0');
            binaryString += '0';
            StringBuilder text = new StringBuilder();
            int startIndex = 0;
            int endIndex = 0;
            endIndex = binaryString.IndexOf('0');
            int bitLength = 0;
            bitLength = endIndex;
            char currentChar = codeTable.FirstOrDefault(x => x.Value == bitLength).Key;
            text.Append(currentChar);
            while (endIndex > 0)
            {
                startIndex = endIndex +1;
                endIndex = binaryString.IndexOf('0', endIndex+1);
                bitLength = endIndex - startIndex;
                currentChar = codeTable.FirstOrDefault(x => x.Value == bitLength).Key;
                text.Append(currentChar);
            }
            Console.WriteLine(text.ToString());

        }
    }
}
