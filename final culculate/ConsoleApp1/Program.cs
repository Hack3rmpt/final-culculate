int action = 1;
double firstNum;
double secondNum;
double result;

while (action != 9)
{

    Console.WriteLine("Выберете действие:");
    Console.WriteLine("1.Сложение\n2.Вычетание второго из первого  \n3.Умножение \n4.Деление \n5.Возвести в степень \n6.Квадратный корень \n7.1 процент от числа \n8.Факториал \n9 выйти из программы");
    action = Convert.ToInt32(Console.ReadLine());

    if (action == 1)
    {
        Console.Clear();
        Console.Write("Введите первое число: ");
        firstNum = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        secondNum = Convert.ToDouble(Console.ReadLine());

        result = firstNum + secondNum;
        Console.WriteLine($"{firstNum} + {secondNum} = {result}");
        Console.WriteLine();
    }

    else if (action == 2)
    {
        Console.Clear();
        Console.Write("Введите первое число: ");
        firstNum = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        secondNum = Convert.ToDouble(Console.ReadLine());

        result = secondNum - firstNum;
        Console.WriteLine($"{secondNum} - {firstNum} = {result}");
        Console.WriteLine();
    }

    else if (action == 3)
    {
        Console.Clear();
        Console.Write("Введите первое число: ");
        firstNum = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        secondNum = Convert.ToDouble(Console.ReadLine());

        result = secondNum * firstNum;
        Console.WriteLine($"{secondNum} * {firstNum} = {result}");
        Console.WriteLine();
    }

    else if (action == 4)
    {
        Console.Clear();
        Console.Write("Введите первое число: ");
        firstNum = Convert.ToDouble(Console.ReadLine());

        Console.Write("Введите второе число: ");
        secondNum = Convert.ToDouble(Console.ReadLine());

        result = firstNum / secondNum;
        Console.WriteLine($"{firstNum} / {secondNum} = {result}");
        Console.WriteLine();
    }

    else if (action == 5)
    {
        Console.Clear();
        Console.Write("Введите число: ");

        firstNum = Convert.ToInt32(Console.ReadLine());
        Console.Write("Введите степень ");

        secondNum = Convert.ToDouble(Console.ReadLine());
        result = Math.Pow(firstNum, secondNum);
        Console.WriteLine($"{firstNum} ^ {secondNum} = {result}");
        Console.WriteLine();
    }

    else if (action == 6)
    {
        Console.Clear();
        Console.Write("Введите число: ");

        firstNum = Convert.ToDouble(Console.ReadLine());
        Console.Write("Введите степень ");

        secondNum = Convert.ToDouble(Console.ReadLine());
        result = Math.Pow(firstNum, secondNum);
        Console.WriteLine($"{firstNum} ^ {secondNum} = {result}");
        Console.WriteLine();
    }

    else if (action == 7)
    {
        Console.Clear();
        Console.Write("Введите число: ");
        firstNum = Convert.ToDouble(Console.ReadLine());
        result = firstNum / 100;
        Console.WriteLine($"1% от {firstNum} = {result}");
        Console.WriteLine();
    }

    else if (action == 8)
    {
        Console.Clear();
        result = 1;
        Console.Write("Введите число: ");
        firstNum = Convert.ToDouble(Console.ReadLine());

        for (int i = 1; i <= firstNum; i++)
        {
            result *= i;
        }
        Console.WriteLine(result);
        Console.Clear();
    }
    else
    {
        Console.Clear();
        if (action != 9) Console.WriteLine("в ввели не сущетвующее действие");
        Console.WriteLine();
    }
}


