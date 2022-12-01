

// // Задание 1. Задача 19. Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

Console.Clear();
Console.WriteLine("Введите целое число и программа проверит его на палиндром:");

int us_number = Convert.ToInt32(Console.ReadLine());
if (us_number > 9) {
    string conv_s = us_number.ToString();
    char[] array = conv_s.ToCharArray();
    Array.Reverse(array);
    string conv_e = new String(array);
    int us_number_conv = Convert.ToInt32(conv_e);

    if (us_number == us_number_conv) {
        Console.WriteLine("Это число - палиндром");
    }
    else {
        Console.WriteLine("Это число - не палиндром");
    }
}

else if (us_number == 0) {
    Console.WriteLine("Это ноль, просто ноль :)");
}

else if (us_number > -10 && us_number < 10) {
    Console.WriteLine("Это просто одна цифорка, а не число :)");
}

else {
    us_number = us_number * -1;
    string conv_s = us_number.ToString();
    char[] array = conv_s.ToCharArray();
    Array.Reverse(array);
    string conv_e = new String(array);
    int us_number_conv = Convert.ToInt32(conv_e);

    if (us_number == us_number_conv) {
        Console.WriteLine("Это число - палиндром");
    }
    else {
        Console.WriteLine("Это число - не палиндром");
    }
}


// // Задание 2. Задача 21. Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве

Console.WriteLine("Введите координаты первой точки (x, y, z): ");
double num_1x = Convert.ToDouble(Console.ReadLine());
double num_1y = Convert.ToDouble(Console.ReadLine());
double num_1z = Convert.ToDouble(Console.ReadLine());

Console.WriteLine("Введите координаты второй точки (x, y, z): ");
double num_2x = Convert.ToDouble(Console.ReadLine());
double num_2y = Convert.ToDouble(Console.ReadLine());
double num_2z = Convert.ToDouble(Console.ReadLine());


double form = ((num_2x - num_1x)*(num_2x - num_1x) + (num_2y - num_1y)*(num_2y - num_1y) + (num_2z - num_1z)*(num_2z - num_1z));
double distance = Math.Sqrt(form);

Console.WriteLine($"Расстояние между точками равно {distance}");

// // Задание 3. Задача 23. Напишите программу, которая принимает на вход число (N) и выдает таблицу кубов чисел от 1 до N

Console.Clear();
int DataEntry(string str)
{
    Console.WriteLine(str);
    int ourNum = int.Parse(Console.ReadLine());
    return ourNum;
}

void result3(int n)
{
    int index = 1;
    while (index <= n -1)
    {
        Console.Write(index*index*index + ", ");
        index++;
    }
    Console.Write(index*index*index);
}

int number = DataEntry("Введите число ");
result3(number);