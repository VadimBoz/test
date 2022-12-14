string[] stringArray = new string[] { "hellow", "2", "world", "123", "1234", "21" };
Console.WriteLine("Исходный массив:");

PrintArray(stringArray);
string[] res = ResizeArray(stringArray);
Console.WriteLine("Результирующий массив:");
PrintArray(res);

string[] ResizeArray(string[] array) //  новый массив с эл-ми до 3 символов ------------------------
{
    int length = array.Length;
    string[] tempArray = new string[length];
    int j = 0;
    for (int i = 0; i < array.Length; i++)
    {
        if (array[i].Length <= 3)
        {
            tempArray[j] = array[i];
            j++;
        }
    }
    string[] resArray = new string[j];

    for (int i = 0; i < j; i++)
    {
        resArray[i] = tempArray[i];
    }
    return resArray;
}


void PrintArray(string[] array) //  вывод массива на консоль ----------------------------
{
    int len = array.Length;
    if (len == 0) Console.WriteLine("в массиве нет элементов");
    else
    {
        Console.Write("[ ");
        for (int i = 0; i < len - 1; i++)
        {
            Console.Write($"{array[i]} ");
        }
        Console.WriteLine($"{array[len - 1]} ]");
    }

}