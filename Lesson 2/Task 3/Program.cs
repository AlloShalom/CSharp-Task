//Напишите программу, которая принимает на вход целое число из отрезка [10, 99] и показывает наибольшую цифру числа.

int Number = new Random().Next(10, 99);
Console.WriteLine(Number);

int FirstNumber = Number / 10;
int SecondNumber = Number % 10;

if (FirstNumber > SecondNumber){
    Console.WriteLine(FirstNumber);
}
else if (FirstNumber < SecondNumber){
    Console.WriteLine(SecondNumber);
} 
else {Console.WriteLine("Числа равны");}