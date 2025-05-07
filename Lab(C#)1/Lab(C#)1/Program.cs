using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            // Меню
            Console.WriteLine("Выберите задание:");
            Console.WriteLine("1 - Вычисление a^n (возведение в степень)");
            Console.WriteLine("2 - Преобразование числа x в число n (перестановка цифр)");
            Console.WriteLine("0 - Выход из программы");
            Console.Write("Ваш выбор: ");

            // Ввод данных
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    //Задание 1
                    PowerCalculator.Run();
                    break;
                case "2":
                    // Задание 2
                    NumberTransformer.Run();
                    break;
                case "0":
                    // Выход
                    return;
                default:
                    // Ошибка
                    Console.WriteLine("Ошибка: Неверный выбор. Пожалуйста, введите 1, 2 или 0.");
                    break;
            }

            // Пауза перед возвратом в меню
            Console.WriteLine("\nНажмите любую клавишу для возврата в меню...");
            Console.ReadKey();  // Ожидаем нажатия любой клавиши
            Console.Clear();    // Очищаем консоль перед следующим выводом меню
        }
    }
}

class PowerCalculator
{
    public static void Run()
    {
        Console.WriteLine("\n--- Задача 1: Вычисление a^n ---");

        // Запрашиваем и считываем основание и показатель степени
        Console.Write("Введите число a (основание): ");
        int a = int.Parse(Console.ReadLine());  // Преобразуем ввод в целое число

        Console.Write("Введите степень n (показатель): ");
        int n = int.Parse(Console.ReadLine());

        int result = 1;

        // Вычисляем a^n с помощью цикла умножения
        for (int i = 0; i < n; i++)
        {
            result *= a;
        }

        // Выводим результат
        Console.WriteLine($"Результат: {a}^{n} = {result}");
    }
}

class NumberTransformer
{
    public static void Run()
    {
        
    }
}