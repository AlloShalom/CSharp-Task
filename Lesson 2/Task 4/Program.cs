//Напишите программу, которая на вход принимает натуральное число N, а на выходе показывает его цифры через запятую.


//Решение первое. Цифры идут в обратном порядке.
int Number = new Random().Next(1, 9999);
Console.WriteLine(Number);

while (Number > 0) {
    int n = Number % 10;
    Number /= 10;
    Console.Write(n + ", ");
}

//Решение второе. Здесь с цифрами всё в порядке, но с этим вариантом пришлось шурудить интернет.
/*Console.WriteLine("Введите число:");
string n = Console.ReadLine();

for (int i = 0; i < n.Length; i++) {
    Console.Write(n[i] + "{3}, ");
}
*/
