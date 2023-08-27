// Напишите программу, которая принимает на
// вход пятизначное число и проверяет, является ли оно
// палиндромом.

bool CheckingNumber (int numberChecking)
{
    if (numberChecking < 100000 && numberChecking >= 10000)
    {
        return true;
    }
    return false;
} 

bool NumberPalindrome (int num)
{
    int symbol1 = num / 10000;
    int symbol5 = num % 10;
    int symbol2 = (num / 1000) %10;
    int symbol4 = (num % 100) / 10;
    if (symbol1==symbol5 && symbol2 == symbol4)
    {
        return true;
    }
    return false;
} 

Console.WriteLine("Введите пятизначное число: ");
int number = Convert.ToInt32(Console.ReadLine());

bool checkingResult = CheckingNumber (number); 
if (checkingResult == true)
{
    bool  palindrome = NumberPalindrome (number);
    string result = palindrome ? $"Число {number} является палиндромом.": $"Число {number} не является палиндромом.";
    Console.WriteLine(result);
}
else Console.WriteLine("Неверное число!");


