string[] arrayOne = new string[] { "007", "xy", "2517", "qwerty", "7" };
string[] arrayTwo = new string[arrayOne.Length];

void PrintArray(string[] array)
{
    for (int i = 0; i < array.Length; i++)
    {
        Console.Write(array[i] + " ");
    }
}

void ConvertArray(string[] array1, string[] array2)
{
    for (int i = 0; i < array1.Length; i++)
    {
        if (array1[i].Length <= 3)
        {
            array2[i] = array1[i];
        }
    }
}

Console.WriteLine("Заданный массив:");
PrintArray(arrayOne);
Console.WriteLine();
Console.WriteLine("Сформированный массив с эллементами менее 4-х знаков:");
ConvertArray(arrayOne, arrayTwo);
PrintArray(arrayTwo);
