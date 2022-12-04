/*задача1. Написать программу, которая выдает число из отрезка (10,99) и поазывает
наибольшую цифру числа*/
// Random random=new Random();
// int number=0;
// number=random.Next(10,100);
// Console.WriteLine(number);
// int a=number%10;
// int b=number/10;
// if (a>b)
// Console.WriteLine("a>b");
// else if (b>a)
// Console.WriteLine("b>a");
// else if (b==a)
// Console.WriteLine(b==a);


/*string text="kkk";
string example="text";
Console.WriteLine("LLL {1} jjjj mu name is and {0}", text,example);//text (0),example(1)*/

// string text ="kkk";
// string example="text";
// Console.WriteLine($"LLL {text+example} jjjj mu name is and");


//Задача 2. Написать программу, которая выводит случайное трехзначное число
// и удаляет вторую цифру этого числа

// Console.Write("Введи трёхзначное число: ");
// string stringNumber =Console.ReadLine();
// Console.WriteLine("after del "+stringNumber[0]+stringNumber[2]);

// Random random=new Random();
// int number=0;
// number=random.Next(100,1000);
// Console.WriteLine(number);
// int a=number/100;
// int b=number%10;
// Console.WriteLine ("двузначное число"+a+b);

//Задача 3. Напишите программу, которая принимает на вход два числа и выводит. 
// Является ли первое число кратным второму. Если число 1 не кратно числу 2, то программа
// выводит остаток деления.

// Console.WriteLine("Введите первое число");
// int a=Convert.ToInt32 (Console.ReadLine());
// Console.WriteLine("Введите второе число");
// int b=Convert.ToInt32 (Console.ReadLine());
// int n=a%b;
// if (n==0)
// Console.WriteLine("число кратное");
// else 
// Console.WriteLine ("Остаток от деления" + n);



//Задача 4. Напишите программу, которая принимает на вход число и проверяет, 
// кратно ли оно одновременно 7 и 23.
Console.WriteLine("введите число");
int a=Convert.ToInt32(Console.ReadLine());
if (a%161==0)
Console.WriteLine("Число кратное и 7 и 23");
else
Console.WriteLine("Число некратное и 7 и 23");
