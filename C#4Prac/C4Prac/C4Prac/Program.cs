using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
namespace C4Prac
{
    class Nums
    {
        static void Main()
        {
            List<int> finishNums = new List<int>();
            List<int> nums = new List<int>() { 1, 5, 10, 50, 100, 500, 1000 };
            Console.Write("Введите число: ");
            string romeNumber = Console.ReadLine();

            for (int i = 0; i < romeNumber.Length; i++)
            {
                switch (romeNumber[i])
                {
                    case 'I':
                        finishNums.Add(nums[0]);
                        break;
                    case 'V':
                        finishNums.Add(nums[1]);
                        break;
                    case 'X':
                        finishNums.Add(nums[2]);
                        break;
                    case 'L':
                        finishNums.Add(nums[3]);
                        break;
                    case 'C':
                        finishNums.Add(nums[4]);
                        break;
                    case 'D':
                        finishNums.Add(nums[5]);
                        break;
                    case 'M':
                        finishNums.Add(nums[6]);
                        break;
                }
            }

            int unswer = 0;

            for (int i = 0; i < romeNumber.Length - 1; i++)
            {
                if (finishNums[i] < finishNums[i + 1])
                {
                    finishNums[i] -= finishNums[i] * 2; 
                }
            }
            for (int i = 0; i < romeNumber.Length; i++)
            {
                unswer += finishNums[i];
            }

            Console.Write($"Значение на арабском: {unswer}");
        } 
    }
}