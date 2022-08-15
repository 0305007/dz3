// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.

// 14212 -> нет

// 12821 -> да

// 23432 -> да

// 1 2 3 4 5 не является  палиндромом, т.к. первая цифра не равно последней цифре, а последнее не равно первой цифре, так же 2 цифра не равна 4 цифре 

// 1 2   3 4  

// Порядок нахождения цифр из пятизначного числа 
/* Примерами правильного палиндрома явлется 12321, 54345*/


// Console.WriteLine("Введите на вход пятизначное число и проверяет, является ли оно палиндромом");

// string? numberStringa = Console.ReadLine();

// int numbera = int.Parse(numberStringa!);

// int result1 = numbera / 10000;

// int result2 = numbera % 10000 / 1000;

// int result3 = numbera % 100 / 10;

// int result4 = numbera % 10;



// if (numbera > 9999 && numbera < 100000)

// {
//     if (result1 == result4 && result2 == result3)
//     {
//         Console.WriteLine("число " + numbera + " является палиндромным");
//     }
//     else
//     {
//         Console.WriteLine("число " + numbera + " не является палиндромным");
//     }
// }




// Напишите программу, которая принимает на вход координаты двух точек и находит расстояние между ними в 3D пространстве.

// A (3,6,8); B (2,1,-7), -> 15.84

// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine ("Введите число х1");

// string? numberStringa = Console.ReadLine();

// int x1 = int.Parse(numberStringa!);


// Console.WriteLine ("Введите число y1");

// string? numberStringb = Console.ReadLine();

// int y1 = int.Parse(numberStringb!);


// Console.WriteLine ("Введите число z1");

// string? numberStringc = Console.ReadLine();

// int z1 = int.Parse(numberStringc!);


// Console.WriteLine ("Введите число х2");

// string? numberStringd = Console.ReadLine();

// int x2 = int.Parse(numberStringd!);


// Console.WriteLine ("Введите число y2");

// string? numberStringe = Console.ReadLine();

// int y2 = int.Parse(numberStringe!);


// Console.WriteLine ("Введите число z2");

// string? numberStringf = Console.ReadLine();

// int z2 = int.Parse(numberStringf!);

// double result = Math.Sqrt((x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1) + (z2 - z1) * (z2 - z1));

// Console.WriteLine (result);



// 2 вариант

// Console.Clear();
// Console.WriteLine("Введите кооррдинаты A. Необходимо вводить числа через пробел ");
// string[] num1 = Console.ReadLine().Split(' ');
// int x1 = int.Parse(num1[0]);
// int y1 = int.Parse(num1[1]);
// int z1 = int.Parse(num1[2]);
// Console.Clear();
// Console.WriteLine("Введите кооррдинаты B. Необходимо вводить числа через пробел ");
// string[] num2 = Console.ReadLine().Split(' ');
// int x2 = int.Parse(num2[0]);
// int y2 = int.Parse(num2[1]);
// int z2 = int.Parse(num2[2]);
// Console.Clear();
// Console.WriteLine("--------------------------------------------------------"); 
// double result1 = Math.Pow((x2-x1),2);
// double result2 = Math.Pow((y2-y1),2);
// double result3 = Math.Pow((z2-z1),2);
// double result4 = Math.Sqrt(result1+ result2+ result3);
// Console.WriteLine("Расстояние между точками " + result4);
// Console.WriteLine("--------------------------------------------------------");




// Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N.

// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125

// Console.WriteLine("Напишите программу, которая принимает на вход число (N) и выдаёт таблицу кубов чисел от 1 до N");

// string? numberStringa = Console.ReadLine();

// int numbera = int.Parse(numberStringa!);

// int i = 1;
// if (numbera > 0)
// {
//     while (i <= numbera)
//     {
//         double result = Math.Pow(i, 3);
//         i++;
//         Console.WriteLine(result);
//     }
// }
// else
// {
//     Console.WriteLine("отрицательные числа не проверяются");
// }
