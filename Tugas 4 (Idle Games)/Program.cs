using System;
using System.Numerics;
using System.Linq;
using System.Text;
class Program
{
    static void Main(string[] args)
    {
        // number of arrays
        int[] numbers = new int[5]; 

        while (true)
        {
            //Initialize an index (numbers of units)
            int index = numbers.Length - 1;

            //[index] == 9 set it as 0
            while (index >= 0 && numbers[index] == 9)
                numbers[index--] = 0;

            // if index < 0 (if all digits were 9)
            if (index < 0)
            {
                return;
            }
            
            //else increment the value at [index]
            else
                numbers[index]++;

            //Perform the same operation for each character 'digit'
            //which is an element in the variable numbers
            foreach (int digit in numbers)
                Console.Write(digit + " ");
            Console.WriteLine(" ");
        }
    }
}
//{
//    Decimal intVariable = 0;
//    intVariable++;
//    string output = intVariable.ToString().PadLeft(19, '0');

//    for (Decimal i = 0; i < 10000000000000000000; i++)
//    {
//        output = i.ToString().PadLeft(19, '0');

//        Console.WriteLine(output);
//    }
//    Console.ReadLine();
//}
//int[] digits = new int[5];
//int n = digits.Length;
//Array.Reverse(digits);
//int carry = 0;
//for (int i = 0; i < n; i++)
//{
//    if (i == 0)
//        digits[i] = digits[i] + 1 + carry;
//    else if
//        (carry != 0)
//        digits[i] = digits[i] + carry;
//    carry = digits[i] / 10;
//    if (carry != 0)
//        digits[i] = digits[i] % 10;
//}
//if (carry != 0)
//    digits[digits.Length - 1] = carry;
//Array.Reverse(digits);
//for (int i = 0; i < n; i++)
//{
//    Console.Write(digits[i]);
//}
//while (index >= 0 && digits[index] == 9)
//    digits[index--] = 0;
//if (index < 0)
//{
//    Array.Resize(ref digits, index + 1);
//    digits[0] = 1;
//}
//else
//    digits[index]++;

//foreach (int digit in digits)
//    Console.Write(digit + " ");