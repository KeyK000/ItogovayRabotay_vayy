void FilterArray(string[] arr1, string[] arr2)
{
    int count = 0;
    for (int i = 0; i < arr1.Length; i++)
    {
    if(arr1[i].Length <= 3)
        {
        arr2[count] = arr1[i];
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


Console.WriteLine("Введите длинну массива: ");
int count = Convert.ToInt32(Console.ReadLine());

string[] defaultArray = new string[count];

Console.WriteLine("Заполни массив");
for (int i = 0; i < defaultArray.Length; i++)
{
    defaultArray[i] = Console.ReadLine();
}

string[] filteredArray = new string[defaultArray.Length];

FilterArray(defaultArray, filteredArray);

Console.WriteLine("\n===========================\n");
Console.WriteLine("Отфильтрованный массив:"); 

PrintArray(filteredArray);

