// 1
/*
using System;

namespace C1Prac
{
    class mda
    {
        static void Main()
        {
            Console.Write("Введите кол-во камней и драгоценностей: \n");
            string stones = Console.ReadLine();
            string goldstones = Console.ReadLine();
            int count = 0;
            for (int i = 0; i < stones.Length; i++)
            {
                for (int j = 0; j < goldstones.Length; j++)
                {
                    if (goldstones[i] == stones[j])
                    {
                        count++;
                    }
                }
            }
            Console.Write($"Количество совпадений: {count}");  
        }
    }
}

*/
// 2

/*

*/

// 3
/*
using System;
using System.Collections.Generic;
namespace C1Prac
{
    class mda
    {
        static bool result(List <int> nums)
        {
            nums.Sort();
            for (int i = 0; i < nums.Count - 1; i++)
            {
                if (nums[i] == nums[i + 1])
                {
                    return true;
                }
            }
            return false;
        }
        static void Main()
        {
            int limit = 5;
            List<int> nums = new List<int>();
            for (int i = 0; i < limit; i++)
            {
                Console.Write("Введите числа в массив: ");
                int number = Convert.ToInt32(Console.ReadLine());
                nums.Add(number);
            }
            Console.Write($"{String.Join(", ", nums)} - {result(nums)}");
        }
    }
}
*/