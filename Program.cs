string[] array = { "Hello", "2", "world", ":-)" };

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        if (i > 0 && i < array.Length)
        {
            Console.Write(", ");
        }
        Console.Write($"{array[i]}");
    }
    Console.Write("]");
    Console.WriteLine();
}

PrintArray(array);

int GetNewArrayLength(string[] array)
{
    int length = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            length = length + 1;
        }
    }
    return length;
}

int length = GetNewArrayLength(array);

string[] FillNewArray(string[] array, int length)
{
    string[] newArray = new string[length];
    int i = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if (array[j].Length <= 3)
        {
            newArray[i] = array[j];
            i++;
        }
    }
    return newArray;
}

string[] newArray = FillNewArray(array, length);
if (length == 0)
{
    Console.WriteLine("Пусто");
}
else
{
    PrintArray(newArray);
}
