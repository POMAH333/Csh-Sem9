// Урок 9. Рекурсия

//-----------------------------------------------------------------------------------

while (true)
{
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine("Введите номер задачи:");
    Console.WriteLine("64) Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.");
    Console.WriteLine("66) Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.");
    Console.WriteLine("68) Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.");
    Console.WriteLine();
    Console.WriteLine("0) Или введите 0 для выхода из программы");
    int menuNum = SetNumber("");
    Console.WriteLine();
    Console.WriteLine();
    Console.WriteLine();

    switch (menuNum)
    {
        case 0: return; break;
        case 64: Task64(); break;
        case 66: Task66(); break;
        case 68: Task68(); break;
        default: Console.WriteLine($"Задачи №{menuNum}, не существует"); break;
    }
}

//-----------------------------------------------------------------------------------

int SetNumber(string messageEnt)
{
    Console.WriteLine(messageEnt);
    int num = int.Parse(Console.ReadLine());
    return num;
}



// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

string StringRangeNumberNegativ(int number, int finish = 1)
{
    if (number == finish) return number.ToString();
    return $"{number}, {StringRangeNumberNegativ(number - 1)}";
}

void Task64()
{
    int numberN = SetNumber("Введите число N:");
    Console.WriteLine();

    Console.WriteLine(StringRangeNumberNegativ(numberN));

    Console.WriteLine();
    Console.WriteLine();
}



// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

int NaturalElementSum(int start, int finish)
{
    if (start == finish) return finish;
    return start += NaturalElementSum(start + 1, finish);
}

void Task66()
{
    int numberM = SetNumber("Введите число M:");
    int numberN = SetNumber("Введите число N:");
    Console.WriteLine();

    int sum = NaturalElementSum(numberM, numberN);
    Console.WriteLine($"M = {numberM}; N = {numberN} -> {sum}");

    Console.WriteLine();
}



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

int AkkermanFunction(int mNum, int nNum)
{
    if (mNum == 0) return nNum + 1;
    if (nNum == 0) return AkkermanFunction(mNum - 1, 1);
    return AkkermanFunction(mNum - 1, AkkermanFunction(mNum, nNum - 1));
}

void Task68()
{
    int numM = SetNumber("Введите m:");
    int numN = SetNumber("Введите n:");
    Console.WriteLine();

    if (numM < 0 || numN < 0)
    {
        Console.WriteLine($"Параметры функции не должны быть отрицательными");
    }
    else
    {
        int akkerman = AkkermanFunction(numM, numN);
        Console.WriteLine($"m = {numM}, n = {numN} -> A({numM},{numN}) = {akkerman}");
    }
}


