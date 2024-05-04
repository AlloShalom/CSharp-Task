// Задайте двумерный массив символов (тип char [,]). Создать строку из символов этого массива.

void CharOfString2(char[,] arr)
{
    string st = ""; // 
    foreach (var i in arr)
    {
        Console.WriteLine(i);
        st += i; // st = st + i
    }
    Console.WriteLine(st);
}

char[,] chars = new char[,]
{
    { 'a', '1' },
    { 'c', 'd' }
};
CharOfString2(chars);