// Напишите программу, которая на вход
// принимает число и выдаёт, является
// ли число чётным (делится ли оно на два без остатка).
// 4 -> да
// -3 -> нет
// 7 -> нет

Console.WriteLine("Введите число: ");
int chislo = Convert.ToInt32(Console.ReadLine());

float result = chislo % 2;

if (result == 0)
{
    Console.WriteLine("Число " + chislo + " является чётным.");
}
else
{
    Console.WriteLine("Число " + chislo + " является не четным.");
}


