﻿void InputArray(string[] array)
{
    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"Введите {j + 1} строку >>>");
        array[j] = Convert.ToString(Console.ReadLine());
    }

    Console.WriteLine($"[{string.Join(", ", array)}]");
}



void ChangeArray(string[] array, int n)
{
    int a = 0;
    int b = 0;
    string[] result = new string[n - a];


    for (int j = 0; j < array.Length; j++)
    {
        if(array[j].Length > 3)
            a++;
    }


    for (int i = 0; i < array.Length; i++)
    {   
        if(array[i].Length < 4)
        {
            result[b] = array[i];
            b++;
        }
    }
    Console.WriteLine($"[{string.Join(" ", result)}]");
}


Console.Clear();

Console.Write("Введите количество строк >>> ");
int n = Convert.ToInt32(Console.ReadLine());
string[] array = new string[n];

InputArray(array);
ChangeArray(array, n);