// Напишите программу, которая выводит
// третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число, от 0 до n -> ");
int numder = Convert.ToInt32(Console.ReadLine());


int result = numder % 100;

Console.WriteLine($"Третья цифра числа: {result}");