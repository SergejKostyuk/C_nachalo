// // Напишите программу, которая принимает на
// вход цифру, обозначающую день недели, и проверяет,
// является ли этот день выходным.
// // 6 -> да
// // 7 -> да
// // // 1 -> нет

Console.WriteLine("Введите цифру, от 1 до 7 дня недели");
string [] array = {"понедельник","вторник","среда","четверг","пятница","суббота","воскресенье"};
int num = Convert.ToInt32(Console.ReadLine()) - 1;

if (num >= 0 && num <=7)
{
    bool dey = Dey (num);
    Console.Write($"Сегодня {array[num]}, ");
    Console.WriteLine(dey?"будний день":"выходной день");
}
else Console.WriteLine("Введите коректное число!");

bool Dey(int numb)
{
    return (numb >=0 && numb <=4);
}