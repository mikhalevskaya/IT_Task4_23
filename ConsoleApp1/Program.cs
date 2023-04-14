using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            while (true)
            {
                info();
                string action = Console.ReadLine();
                Console.WriteLine("------------------------------");
                switch (action)
                {
                    case "0":
                        return;
                    case "1":
                        Console.WriteLine("Создан класс Student с параметрами Иванов , 15, 3");
                        Console.WriteLine(new Student("Иванов", 15, 3));
                        break;
                    case "2":
                        Console.WriteLine("Создан класс StudentStudEngl с параметрами Иванов , 15, 3, true");
                        Console.WriteLine(new StudentStudEng("Иванов", 15, 3, true));
                        break;
                    case "3":
                        Console.WriteLine("Создан класс StudentStudEngl с параметрами Иванов , 15, 3, false");
                        Console.WriteLine(new StudentStudEng("Иванов", 15, 3, false));
                        break;
                    case "4":
                        Console.WriteLine("Surname");
                        string surname = Console.ReadLine();
                        Console.WriteLine("Average score");
                        double averageScore = castToDouble();
                        if (averageScore < 0)
                        {
                            Console.WriteLine("Введите адекватное значение ");
                            break;
                        }

                        Console.WriteLine("Course");
                        int course = castToInt();
                        if (course < 0)
                        {
                            Console.WriteLine("Введите адекватное значение ");
                            break;
                        }

                        Console.WriteLine(new Student(surname, averageScore, course));
                        break;
                    case "5":
                        Console.WriteLine("Surname");
                        string surnameEn = Console.ReadLine();
                        Console.WriteLine("Average score");
                        double averageScoreEn = castToDouble();
                        if (averageScoreEn < 0)
                        {
                            Console.WriteLine("Введите адекватное значение ");
                            break;
                        }

                        Console.WriteLine("Course");
                        int courseEn = castToInt();
                        if (courseEn < 0)
                        {
                            Console.WriteLine("Введите адекватное значение ");
                            break;
                        }

                        Console.WriteLine("Studying english");
                        bool isStud = castToBoolean();
                        Console.WriteLine(new StudentStudEng(surnameEn, averageScoreEn, courseEn, isStud));
                        break;
                }
                Console.WriteLine("------------------------------");
            }
        }

        static int castToInt()
        {
            try
            {
                return int.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        static double castToDouble()
        {
            try
            {
                return double.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                return -1;
            }
        }

        static bool castToBoolean()
        {
            try
            {
                return bool.Parse(Console.ReadLine());
            }
            catch (Exception e)
            {
                return false;
            }
        }

        static void info()
        {
            Console.WriteLine("0 - Exit");
            Console.WriteLine("1 - Вывести студента с заданными значениями");
            Console.WriteLine("2 - Вывести студента изучающего иностранный язык с заданными значениями");
            Console.WriteLine("3 - Вывести студента не изучающего иностранный язык с заданными значениями");
            Console.WriteLine("4 - Задать значения и вывести студента");
            Console.WriteLine("5 - Задать значения и вывести студента  изучающего/не изучающего иностранный язык");
        }
    }
}