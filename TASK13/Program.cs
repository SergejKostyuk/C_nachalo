// Напишите программу, которая выводит
// третью цифру заданного числа или сообщает,
// что третьей цифры нет.
// 645 -> 5
// 78 -> третьей цифры нет
// 32679 -> 6

Console.WriteLine("Введите число, от 0 до n -> ");
int number = Convert.ToInt32(Console.ReadLine());

if (number<0) number = number *-1; 

if (CheckThreeNumbers (number))
{
    while (number > 999)
    {
       number = number/10; 
    }
    int lastDigit = number%10;
    Console.WriteLine("Последняя цифра:  " + lastDigit);  
}
else 
{
    Console.WriteLine("Нет третьего числа");
}

bool CheckThreeNumbers (int numb)
{
    return numb >= 100;
}