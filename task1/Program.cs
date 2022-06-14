// **Задача 19** 
// 
// Напишите программу, которая принимает на вход пятизначное число и проверяет, является ли оно палиндромом.
// 
// 14212 -> нет
// 
// 12821 -> да
// 
// 23432 -> да

using System;
using static System.Console;
Clear();

Write("Введите число: ");

string str = ReadLine();
int num = int.Parse(str);

int temp = 1;
int length = 0;
bool ifPalindrome = true;
int temp1, temp2, temp3, temp4;

for (int i=1; i <= num; i*=10)
{
   length++;
   temp *= 10;
}

int half1 = num/(Convert.ToInt32(Math.Pow(10, ((length%2 == 0 ? length : length+1)/2))));
int half2 = Convert.ToInt32(num % Math.Pow(10, (length/2)));

temp1=10;
temp2=1;
temp3 = Convert.ToInt32(Math.Pow(10, (length/2)));
temp4 = temp3/10;

for (int i = 1; i <= (length/2); i++)
{
     if ((half2 % (temp1) / temp2) != (half1 % (temp3) / temp4)) ifPalindrome = false;
    temp1*=10;
    temp2*=10;
    temp3/=10;
    temp4/=10;
}
Write($"Числовой метод: {str} это ");
WriteLine (ifPalindrome ? "полиндром" : "не полиндром");


ifPalindrome = true;
for (int i = 0; i < str.Length; ++i)
{
   if (str[i] != str[(str.Length-1)-i])
   {
      ifPalindrome = false;
   }
}

Write($"Строковый метод: {str} это ");
WriteLine (ifPalindrome ? "полиндром" : "не полиндром");