using System;
using System.Text;

class TRES4
{
    static void Main(string[] args)
    {
        ulong numberInput = ulong.Parse(Console.ReadLine());
        StringBuilder result = new StringBuilder();
        if (numberInput==0)
        {
            Console.WriteLine("LON+");
        }
        while (numberInput > 0)
        {
            ulong remainder = numberInput % 9;
            numberInput /= 9;
            switch (remainder)
            {
                case 0:
                    result.Insert(0, "LON+");
                    break;
                case 1:
                    result.Insert(0, "VK-");
                    break;
                case 2:
                    result.Insert(0, "*ACAD");
                    break;
                case 3:
                    result.Insert(0, "^MIM");
                    break;
                case 4:
                   result.Insert(0, "ERIK|");
                    break;
                case 5:
                    result.Insert(0, "SEY&");
                    break;
                case 6:
                    result.Insert(0, "EMY>>");
                    break;
                case 7:
                    result.Insert(0, "/TEL");
                    break;
                case 8:
                   result.Insert(0, "<<DON");
                    break;
            }
                
        }
        Console.WriteLine(result.ToString());
    }
}
