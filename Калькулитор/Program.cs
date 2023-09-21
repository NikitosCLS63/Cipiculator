Console.WriteLine("Выберите какое действие вы хотите выполнить:");
Console.WriteLine("1.+");
Console.WriteLine("2.-");
Console.WriteLine("3.*");
Console.WriteLine("4./");
Console.WriteLine("5.Возвести в степень N");
Console.WriteLine("6.Найти квадратный корень");
Console.WriteLine("7.Найти 1 процент из числа");
Console.WriteLine("8.Найти факториал числа");
Console.WriteLine("9.Уйти");


string input = Console.ReadLine();
int x = Convert.ToInt32(input);
do
{

    if (x == 1)
    {
        Console.WriteLine("Введите первое число");
        string a = Console.ReadLine();
        int cifraone = Convert.ToInt32(a);
        Console.WriteLine("Введите второе число");
        string b = Console.ReadLine();
        int cifratoo = Convert.ToInt32(b);
        Console.WriteLine("Результат:");
        Console.WriteLine(cifraone + cifratoo);
        Console.WriteLine("Введите цифру действия ещё раз");
        input = Console.ReadLine();
        x = Convert.ToInt32(input);
    }
    else if (x == 2)
    {
        Console.WriteLine("Введите первое число");
        string a = Console.ReadLine();
        int cifraone = Convert.ToInt32(a);
        Console.WriteLine("Введите второе число");
        string b = Console.ReadLine();
        int cifratoo = Convert.ToInt32(b);
        Console.WriteLine("Результат:");
        Console.WriteLine(cifraone - cifratoo);
        Console.WriteLine("Введите цифру действия ещё раз");
        input = Console.ReadLine();
        x = Convert.ToInt32(input);
    }
    else if (x == 3)
    {
        Console.WriteLine("Введите первое число");
        string a = Console.ReadLine();
        int cifraone = Convert.ToInt32(a);
        Console.WriteLine("Введите второе число");
        string b = Console.ReadLine();
        int cifratoo = Convert.ToInt32(b);
        Console.WriteLine("Результат:");
        Console.WriteLine(cifraone * cifratoo);
        Console.WriteLine("Введите цифру действия ещё раз");
        input = Console.ReadLine();
        x = Convert.ToInt32(input);
    }
    else if (x == 4)
    {
        Console.WriteLine("Введите первое число");
        string a = Console.ReadLine();
        int cifraone = Convert.ToInt32(a);
        Console.WriteLine("Введите второе число");
        string b = Console.ReadLine();
        int cifratoo = Convert.ToInt32(b);
        Console.WriteLine("Результат:");
        Console.WriteLine(cifraone / cifratoo);
        Console.WriteLine("Введите цифру действия ещё раз");
        input = Console.ReadLine();
        x = Convert.ToInt32(input);
    }
    else if (x == 5)
    {
        Console.WriteLine("Введите число, которое надо возвести в степень");
        string a = Console.ReadLine();
        int cifraone = Convert.ToInt32(a);
        Console.WriteLine("Введите cтепень , в которую надо возвести число");
        string b = Console.ReadLine();
        int cifratoo = Convert.ToInt32(b);
        Console.WriteLine("Результат:");
        Console.WriteLine(Math.Pow(cifraone, cifratoo));
        Console.WriteLine("Введите цифру действия ещё раз");
        input = Console.ReadLine();
        x = Convert.ToInt32(input);
    }
    else if (x == 6)
    {
        Console.WriteLine("Введите число");
        string a = Console.ReadLine();
        int cifraone = Convert.ToInt32(a);
        Console.WriteLine("Квадратный корень заданного числа равен :");
        Console.WriteLine(Math.Sqrt(cifraone));
        Console.WriteLine("Введите цифру действия ещё раз");
        input = Console.ReadLine();
        x = Convert.ToInt32(input);
    }
    else if (x == 7)
    {
        Console.WriteLine("Введите первое число");
        string a = Console.ReadLine();
        int cifraone = Convert.ToInt32(a);
        Console.WriteLine("1% от заданного числа:");
        Console.WriteLine(cifraone / 100);
        Console.WriteLine("Введите цифру действия ещё раз");
        input = Console.ReadLine();
        x = Convert.ToInt32(input);
    }
    else if (x == 8)
    {
        Console.WriteLine("Введите число, фактариал которого выхотите узнать");
        string a = Console.ReadLine();
        int cifraone = Convert.ToInt32(a);
        int factorial = 1;
        for (int i = 2; i <= cifraone; i++)
        {
            factorial = factorial * i;
        }
        Console.WriteLine("Результат:");
        Console.WriteLine(factorial);
        Console.WriteLine("Введите цифру действия ещё раз");
        input = Console.ReadLine();
        x = Convert.ToInt32(input);
    }
} while (x != 9);
Console.WriteLine("Завешение программы.");
