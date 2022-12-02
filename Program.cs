void InputArray(string[] array)
{

    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"Введите {j + 1} строку >>>");
        array[j] = Console.ReadLine();
    }
    Console.WriteLine($"[{string.Join(", ", array)}]");

}

void ChangeArray(string[] array, int n)
{
    int a = 0;
    for (int j = 0; j < array.Length; j++)
    {
        if(array[j].Length > 3)
            a++;
    }
    string[] result = new string[n - a];

    for (int i = 0; i < array.Length; i++)
    {
        int b = 0;
        if(array[i].Length <= 3)
            result[b] = array[i];
            b++;

    }


    Console.WriteLine($"[{string.Join(", ", array)}]");

}



Console.Write("Введите количество строк >>> ");
int n = Convert.ToInt32(Console.ReadLine());

string[] array = new string[n];





InputArray(array);
ChangeArray(array, n);