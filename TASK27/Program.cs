// Напишите программу, которая принимает
// на вход число и выдаёт сумму цифр в числе. 

double SumNumbers (int numb)
{
    double sum=0;
    int count=0;
    int numbOTR = numb * -1; // создаеться переменная для решения с отрицательным числом
    if (numb == 0)
    {
        return 0;
    } else if (numb >0)
    {
        while (numb > 0)
        {
            sum = sum + (numb %10);
            numb = numb /10;
        } 
        return sum;
    } else 
    while (numbOTR > 10)
    {
        sum = sum + (numbOTR %10);
        numbOTR = numbOTR /10;
        count ++; 
    } 
    double res = Convert.ToInt32(Math.Pow(10, count)); // возведение в степень количества операций
    int resul = (int) res; // перевод значения res из типа double в int
    sum = sum + numb / resul; 
    return sum;   
    
}
  
Console.WriteLine("Введите число: ");
int number = Convert.ToInt32(Console.ReadLine());

double result = SumNumbers(number);
Console.WriteLine($"Сумма цифр числа {number} ----> {result}");
