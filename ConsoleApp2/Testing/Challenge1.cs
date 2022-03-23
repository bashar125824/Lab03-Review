using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testing
{
    public class Challenge1
    {
         public static int challenge1()
        {
            int result = 1;
        Console.WriteLine("Please enter 3 numbers : ");
            string[] numbers = Console.ReadLine().Split(' ');

            if (numbers.Length< 3)
            {
                return 0;
            }


    int[] intNumbers = new int[numbers.Length];

            for (int i = 0; i<intNumbers.Length; i++)
            {
                char character = char.Parse(numbers[i]);
                if (Char.IsDigit(character) == false) {
                    numbers[i] = "1";
                }

intNumbers[i] = Convert.ToInt32(numbers[i]);

            }

            if (intNumbers.Length > 3)
{
    Console.Write("The product of these 3 numbers is :");

    result = intNumbers[0] * intNumbers[1] * intNumbers[2];
    return result;
}

else
{
    Console.Write("The product of these 3 numbers is :");
    result = intNumbers[0] * intNumbers[1] * intNumbers[2];
    return result;
}
        }
    }
}
