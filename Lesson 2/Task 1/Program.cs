//Напишите программу, которая принимает на вход число и проверяет, кратно ли оно одновременно 7 и 23.

Console.WriteLine("Введите число:");
int Number = Convert.ToInt32(Console.ReadLine());

if ((Number % 7) == 0 && (Number % 23) == 0) {
    Console.WriteLine("Число " + Number + " кратно 7 и 23.");
} else {Console.WriteLine("Число " + Number + " не кратно 7 и 23.");}
