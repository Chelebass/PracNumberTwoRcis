using System;  
using System.Collections.Generic;
using System.Text;
using System.Linq;

/*
//1
namespace C3Prac
{
    class Program
    {
        static void Main()
        {
            Worker people = new Worker();
            while (true)
            {
                Console.WriteLine("\nЗавершить работу? (Число 0)");
                Console.WriteLine("Ввести данные о рабочем? (Число 1)");
                Console.WriteLine("Добавить ставку за день? (Число 2)");
                Console.WriteLine("Указать кол-во отработанных дней? (Число 3)");
                Console.Write("Вывести информацию о рабочем? (Число 4)\n- ");

                int unswer = Convert.ToInt32(Console.ReadLine());
                switch (unswer)
                {
                    case 0:
                        Console.WriteLine("Вы завершили программу");
                        return;
                    case 1:
                        Console.Write("Имя рабочего: ");
                        people.name = Console.ReadLine();
                        Console.Write("Фамилия рабочего: ");
                        people.surname = Console.ReadLine();
                        break;
                    case 2:
                        Console.Write("Ставка: ");
                        people.rate = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.Write("Кол-во дней: ");
                        people.days = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 4:
                        Console.Write("Рабочий: \n");
                        Console.Write($"{people.name} {people.surname}\n__________");
                        Console.Write($"\nСтавка: {people.rate}\n__________");
                        Console.Write($"\nОтработанно: {people.days} дня(дней)\n__________");
                        Console.Write($"\nЗарплата: {people.GetSalary()} рубля(рублей)\n");
                        break;
                }
            }
        }
    }
}
*/

/*
//2
namespace C3Prac;

class Program
{
    static void Main()
    {
        Worker people = new Worker();
        while (true)
        {
            Console.WriteLine("\nЗавершить работу? (Число 0)");
            Console.WriteLine("Ввести данные о рабочем? (Число 1)");
            Console.WriteLine("Добавить ставку за день? (Число 2)");
            Console.WriteLine("Указать кол-во отработанных дней? (Число 3)");
            Console.Write("Вывести информацию о рабочем? (Число 4)\n- ");

            int unswer = Convert.ToInt32(Console.ReadLine());
            switch (unswer)
            {
                case 0:
                    Console.WriteLine("Вы завершили программу");
                    return;
                case 1:
                    Console.Write("Имя рабочего: ");
                    people.Name = Console.ReadLine();
                    Console.Write("Фамилия рабочего: ");
                    people.Surname = Console.ReadLine();
                    break;
                case 2:
                    Console.Write("Ставка: ");
                    people.Rate = Convert.ToInt32(Console.ReadLine());
                    break;
                case 3:
                    Console.Write("Кол-во дней: ");
                    people.Days = Convert.ToInt32(Console.ReadLine());
                    break;
                case 4:
                    Console.Write("Рабочий: \n");
                    Console.Write($"{people.Name} {people.Surname}\n__________");
                    Console.Write($"\nСтавка: {people.Rate}\n__________");
                    Console.Write($"\nОтработанно: {people.Days} дня(дней)\n__________");
                    Console.Write($"\nЗарплата: {people.GetSalary()} рубля(рублей)\n");
                    break;
            }
        }
    }
}
*/

/*
//3
namespace C3Prac;

class Program
{
    static void Main()
    {
        Calculation someActions = new Calculation();
        while (true)
        {
            Console.WriteLine("\nЗавершить работу? (Число 0)");
            Console.WriteLine("Изменить содержимое переменной? (Число 1)");
            Console.WriteLine("Добавить символ в конец строки?? (Число 2)");
            Console.WriteLine("Вывести значение? (Число 3)");
            Console.WriteLine("Вывести последний символ? (Число 4)");
            Console.Write("Удалить последний символ? (Число 4)\n- ");

            int unswer = Convert.ToInt32(Console.ReadLine());
            switch (unswer)
            {
                case 0:
                    Console.WriteLine("Вы завершили программу");
                    return;
                case 1:
                    Console.Write("\nВведите измененный вариант: ");
                    someActions.SetCalculationLine = Console.ReadLine();
                    break;
                case 2:
                    Console.Write("\nНовый символ: ");
                    string newSymbol = Console.ReadLine();
                    someActions.SetLastSymbolCalculationLine(newSymbol);
                    break;
                case 3:
                    Console.Write("\nПредложение: \n");
                    string justSentence = someActions.calculationLine;
                    Console.Write (someActions.GetCalculationLine);
                    break;
                case 4:
                    Console.Write("\nПоследний символ: ");
                    Console.Write (someActions.GetLastSymbol());
                    break;
                case 5:
                    Console.Write("\nПредложение после удаления: ");
                    Console.Write (someActions.DeleteLastSymbol());
                    break;
            }
        }
    }
}
*/