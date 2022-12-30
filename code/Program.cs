// Написать программу, которая из имеющегося массива строк формирует массив из строк, длина которых меньше либо равна 3.
// Первоначальный массив можно ввести с клавиатруы, либо задать на страте выполнения алгоритма. При решениие не рекомендуется
// пользоваться коллекциями.

void  FillSecondArray(string[] firstArray, string[] secondArray)
{
    int count = 0;
    for (int i = 0; i < firstArray.Length; i++)
    {
    if(firstArray[i].Length <= 3)
        {
        secondArray[count] = firstArray[i];
        count++;
        }
    }
}
void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}

string[] array1 = new string[5] {"7774", "2", "wor", ":-)", "Moscow"};
System.Console.WriteLine('[' + string.Join(", ", array1) + ']');
string[] array2 = new string[array1.Length];
FillSecondArray(array1, array2);
PrintArray(array2);
