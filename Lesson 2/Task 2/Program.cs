//Напишите программу, которая принимает на вход координаты точки (X и Y), причём X ≠ 0 и Y ≠ 0 и выдаёт номер координатной четверти плоскости, в которой находится эта точка.

Console.WriteLine("Введите число координаты X:");
int X = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число координаты Y:");
int Y = Convert.ToInt32(Console.ReadLine());

if (X > 0 && Y > 0) {
    Console.WriteLine("Точка находится в 1 координатной четверти.");
}
if (X < 0 && Y > 0) {
    Console.WriteLine("Точка находится во 2 координатной четверти.");
}
if (X < 0 && Y < 0) {
    Console.WriteLine("Точка находится в 3 координатной четверти.");
}
if (X > 0 && Y < 0) {
    Console.WriteLine("Точка находится в 4 координатной четверти.");
}
if (X == 0 || Y == 0) {
    Console.WriteLine("X и Y не должны быть равны 0.");
}