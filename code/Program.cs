Console.WriteLine("Введите длинну массива: ");
int count = Convert.ToInt32(Console.ReadLine());

string[] defaultArray = new string[count];

Console.WriteLine("Заполни массив");
for (int i = 0; i < defaultArray.Length; i++)
{
    defaultArray[i] = Console.ReadLine();
}

