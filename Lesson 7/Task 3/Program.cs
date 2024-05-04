// Задайте произвольный массив. Выведете его элементы, начиная с конца. 
// Использовать рекурсию, не использовать циклы.

void Reverse (int[] array, int i)
{
    if(i < 0) return;
    Console.Write(array[i] + " ");
    Reverse(array, i - 1);
}

int[] array = {17, 6, 54, 81, 4};
Reverse(array, array.Length - 1);