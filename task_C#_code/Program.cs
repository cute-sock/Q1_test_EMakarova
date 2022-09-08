// написать программу, которая из имеющегося массива строк формирует массив, длина строк которого меньше или равна трем

string[] array1 = new string[] {"=)", "geek", "brains", "321", "SPb", "St Pete", "gk", "brn"};
string[] array2 = new string[array1.Length];

void SampleArray(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
        if(array1[i].Length <= 3)
        {
             array2[count] = array1[i];
             count++;
        }
    }
}

void PrintArray(string[] array)
{
    for (int i = 0; i < array1.Length; i++)
    {
        Console.Write($"{array[i]} ");
    }
    Console.WriteLine();
}
SampleArray(array1, array2);
PrintArray(array2);