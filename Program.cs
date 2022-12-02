void InputArray(string[] array)
{

    for (int j = 0; j < array.Length; j++)
    {
        Console.Write($"Введите {j + 1} строку >>>");
        array[j] = Console.ReadLine();
    }
    Console.WriteLine($"[{string.Join(", ", array)}]");

}



Console.Write("Введите количество кустов >>> ");
int n = Convert.ToInt32(Console.ReadLine());

string[] array = new string[n];




InputArray(array);