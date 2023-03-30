using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 // 1
namespace C2Prac
{

    class Program
    {
        static void Main()
        {
            int limiter = 5;
            int studentcount = 0;
            Student[] students = new Student[5];
            Random rand = new Random();
            while (true)
            {
                Console.Write("\nВведите число 1, что бы добавить студента");
                Console.Write("\nВведите число 2, что бы напечатать студента");
                Console.Write("\nВведите число 0, что бы завершить программу\n- ");
                int unswer = int.Parse(Console.ReadLine()!);
                switch (unswer)
                {
                    case 0:
                        Console.Write("Работа завершена");
                        return;
                    case 1:
                        if (studentcount == limiter)
                        {
                            Console.WriteLine("Больше не возможно добавить студентов");
                            break;
                        }
                        Student student = new Student();
                        Console.Write("Введите фамилию студента: ");
                        student.surName = Console.ReadLine()!;
                        Console.Write("Введите дату рождения студента: ");
                        student.dateOfBirthday = Convert.ToDateTime(Console.ReadLine()!);
                        Console.Write("Введите номер группы студента: ");
                        student.groupNumber = Convert.ToInt32(Console.ReadLine());
                        for (int i = 0; i < limiter; i++)
                        {
                            student.marks[i] = rand.Next(2, 5);
                        }
                        students[studentcount] = student;
                        studentcount++;
                        break;
                    case 2:
                        for (int i = 0; i < studentcount; i++)
                        {
                            Console.WriteLine($"Фамилия: {students[i].surName}");
                            Console.WriteLine($"Дата рождения: {students[i].dateOfBirthday.ToShortDateString()}");
                            Console.WriteLine($"Номер группы: {students[i].groupNumber}");
                            Console.WriteLine($"Успеваемость: {string.Join(", ", students[i].marks)}");
                        }
                        break;
                }
            }
        }
    }
}
*/

/*
//2
namespace C2Prac
{
    class Trains
    {
        static void Main()
        {
            Train train1 = new Train();

            Random rnd1 = new Random();
            int parts1 = rnd1.Next(0, 66);
            int minutes1 = parts1 * 5;
            train1.timeOfOut = new TimeSpan(0, minutes1, 0);

            train1.finishTrialName = "Томск";

            Train train2 = new Train();

            Random rnd2 = new Random();
            int parts2 = rnd2.Next(0, 66);
            int minutes2 = parts2 * 5;
            train2.timeOfOut = new TimeSpan(0, minutes2, 0);

            train2.finishTrialName = "Самара";

            Train train3 = new Train();

            Random rnd3 = new Random();
            int parts3 = rnd3.Next(0, 66);
            int minutes3 = parts3 * 5;
            train3.timeOfOut = new TimeSpan(0, minutes3, 0);

            train3.finishTrialName = "Тюмень";

            Train trains = new Train();

            Console.Write("Введите номер поезда (1-3): ");
            trains.trainNumber = Convert.ToInt32(Console.ReadLine());

            switch(trains.tranNumber)
            {
                case 1:
                    Console.Write("Поезд номер 1:");
                    Console.Write($"\nВремя: {train1.timeOfOut}");
                    Console.Write($"\nМесто назначения: {train1.finishTrialName}");
                    break;
                case 2:
                    Console.Write("Поезд номер 2:");
                    Console.Write($"\nВремя: {train2.timeOfOut}");
                    Console.Write($"\nМесто назначения: {train2.finishTrialName}");
                    break;
                case 3:
                    Console.Write("Поезд номер 3:");
                    Console.Write($"\nВремя: {train3.timeOfOut}");
                    Console.Write($"\nМесто назначения: {train3.finishTrialName}");
                    break;
            }
        }
    }
}
*/

/*
//3
namespace C2Prac
{
    class Nums
    {
        static void Main()
        {
            Numbers numesOne = new Numbers();
            while (true)
            {
                Console.Write("\nЗвершить работу? (Введите 0) ");
                Console.Write("\nВывести числа на экран? (Введите 1) ");
                Console.Write("\nИзменить числа? (Введите 2) ");
                Console.Write("\nПосчитать сумму чисел? (Введите 3) ");
                Console.Write("\nНайти наибольшее значение? (Введите 4) \n- ");
                int unswer = Convert.ToInt32(Console.ReadLine());
                switch (unswer)
                {
                    case 0:
                        Console.WriteLine("Вы завершили программу");
                        return;
                    case 1:
                        Console.WriteLine(" ");
                        Console.Write(numesOne.justNums(numesOne.firstNumber, numesOne.secondNumber));
                        Console.WriteLine(" ");
                        break;
                    case 2:
                        Console.Write("\nПервое число: ");
                        numesOne.firstNumber = Convert.ToInt32(Console.ReadLine());
                        Console.Write("\nВторое число: ");
                        numesOne.secondNumber = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.Write("\nСумма значений чисел: ");
                        Console.Write(numesOne.numsPlusNums(numesOne.firstNumber, numesOne.secondNumber));
                        Console.WriteLine(" ");
                        break;
                    case 4:
                        Console.Write("\nНаибольшее значение: ");
                        Console.Write(numesOne.muxNums(numesOne.firstNumber, numesOne.secondNumber));
                        Console.WriteLine(" ");
                        break;
                }
            }
        }
    }
}
*/

/*
//4
namespace C2Prac
{
    class Nums
    {
        static void Main()
        {
            Number MainCounter = new Number();
            while (true)
            {
                Console.Write("\nОстановить работу (Введите 0)");
                Console.Write("\nВывести счетчик на экран (Введите 1)");
                Console.Write("\nВвести произвольный счетчик (Введите 2)");
                Console.Write("\nУвеличить счетчик (Введите 3)");
                Console.Write("\nУменьшить счетчик (Введите 4)");
                Console.Write("\nЗначение: ");
                int unswer = Convert.ToInt32(Console.ReadLine());
                switch (unswer)
                {
                    case 0:
                        Console.WriteLine("\nВы завершили программу");
                        return;
                    case 1:
                        Console.Write("\nСчетчик: ");
                        Console.Write(MainCounter.counter);
                        break;
                    case 2:
                        Console.Write("\nЗначение: ");
                        MainCounter.counter = Convert.ToInt32(Console.ReadLine());
                        break;
                    case 3:
                        Console.Write("\nДействие выполнено: ");
                        MainCounter.plusUnswer();
                        break;
                    case 4:
                        Console.Write("\nДействие выполнено: ");
                        MainCounter.minusUnswer();
                        break;
                }
            }
        }
    }
}
*/

/*
//5
namespace C2Prac
{
    class mdauzj
    {
        static void Main()
        {
            Names user = new Names();
            while (true)
            {
                Console.Write("Изменить данные? (Введите число 1) \nПоказать данные? (Введите число 2)\nЗавершить работу? (Введите число 0) \n-");
                int unswer = int.Parse(Console.ReadLine());
                switch (unswer)
                {
                    case 0:
                        Console.WriteLine("\nВы завершили программу");
                        Console.Write($"\nИмя {user.FirstName} удалено");
                        Console.Write($"\nФамилия {user.Surname} удалена\n");
                        return;
                    case 1:
                        Console.Write("Имя: ");
                        String name1 = Console.ReadLine();
                        Console.Write("Фамилия: ");
                        String name2 = Console.ReadLine();
                        user = new Names(name1, name2);
                        break;
                    case 2:
                        Console.WriteLine(user.FirstName);
                        Console.WriteLine(user.Surname);
                        break;
                }
            }
        }
    }
}
*/