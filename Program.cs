Console.Clear();
Console.WriteLine("Введите номер задачи: 19, 21, или 23");
int z = Convert.ToInt32(Console.ReadLine());



// Задача 19 - Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

if (z == 19)
{
    Console.WriteLine("Введите пятизначное число");
    bool isParsedNum = int.TryParse(Console.ReadLine(), out int num);

    int count = CountDigit(num);

    if (!isParsedNum || count != 5)
    {
        Console.WriteLine("Ошибка! Не правильно введены данные");
        return;
    }

    int[] array = AddingDigitsToArray(num, count);

    bool result = PalindromeCheck(array);

    if (result)
    {
        Console.WriteLine("Да, число палиндром");
    }
    else
    {
        Console.WriteLine("Нет, число не палиндром");
    }
}

// метод - считает количество цифр в числе
int CountDigit(int number)
{
    int count;
    for (count = 0; number != 0; count++)
    {
        number /= 10;
    }
    return count;
}

// метод - заносит все цифры числа в массив
int[] AddingDigitsToArray(int number, int size)
{
    int[] array = new int[size];
    for (int i = array.Length - 1; i >= 0; i--)
    {
        array[i] = number % 10;
        number /= 10;
    }
    return array;
}

//метод - проверяет является ли число, записанное цифрами в массиве, палиндромом
bool PalindromeCheck(int[] array)
{
    bool result = false;

    for (int i = 0; i < array.Length / 2; i++)
    {
        if (array[i] == array[array.Length - 1 - i])
        {
            result = true;
        }
        else
        {
            result = false;
        }
    }
    return result;
}





// Задача 21 - Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

if (z == 21)
{
    Console.WriteLine("Введите координаты первой точки");
    bool isParsedXA = int.TryParse(Console.ReadLine(), out int xA);
    bool isParsedYA = int.TryParse(Console.ReadLine(), out int yA);
    bool isParsedZA = int.TryParse(Console.ReadLine(), out int zA);

    Console.WriteLine("Введите координаты второй точки");
    bool isParsedXB = int.TryParse(Console.ReadLine(), out int xB);
    bool isParsedYB = int.TryParse(Console.ReadLine(), out int yB);
    bool isParsedZB = int.TryParse(Console.ReadLine(), out int zB);

    if (!isParsedXA || !isParsedYA || !isParsedZA || !isParsedXB || !isParsedYB || !isParsedZB)
    {
        Console.WriteLine("Ошибка! Не правильно введены данные");
        return;
    }

    double distanceDot = Distance3D(xA, yA, zA, xA, yB, zB);
    Console.WriteLine($"Расстояние между точками {distanceDot}");
}

// метод - находит расстояние между двумя точками в 3D пространстве по заданным координатам
double Distance3D(int x1, int y1, int z1, int x2, int y2, int z2)
{
    double dis = Math.Sqrt((x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2) + (z1 - z2) * (z1 - z2));
    return dis;
}





// Задача 23 - Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

if (z == 23)
{
    Console.WriteLine("Введите число");
    bool isParsedN = int.TryParse(Console.ReadLine(), out int n);

    if (!isParsedN || n <= 0)
    {
        Console.WriteLine("Ошибка! Не правильно введены данные");
        return;
    }

    int[] arrayCubes = TableOfCubes(n);
    PrintArray(arrayCubes);
}

// метод - задаёт массив, состоящий из кубов чисел от 1 до заданного
int[] TableOfCubes(int number)
{
    int[] array = new int[number];

    for (int i = 0; i < number; i++)
    {
        array[i] = (i + 1) * (i + 1) * (i + 1);
    }
    return array;
}

// метод - распечатывает массив
void PrintArray(int[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
}