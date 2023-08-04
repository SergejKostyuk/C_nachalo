// Напишите программу, которая будет принимать на
// вход два числа и выводить, является ли первое число
// кратным второму. Если первое число не кратно
// второму, то программа выводит остаток от деления.
// 34, 5 -> не кратно, остаток 4
// 16, 4 -> кратно

Console.WriteLine("Введите первое число: ");
int num1 = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int num2 = Convert.ToInt32(Console.ReadLine());

int remainder = Remainder(num1,num2);

if (remainder == 0) Console.WriteLine("Число " + num1 + " кратное числу " + num2);
else Console.WriteLine("Число " + num1 + "  не кратное числу " + num2 + ". Остаток от деления: " + remainder);

int Remainder(int numb1, int numb2)
{
    return numb1 % numb2;
}


