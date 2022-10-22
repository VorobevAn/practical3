

// Задача 41: Пользователь вводит с клавиатуры M чисел. Посчитайте,
// сколько чисел больше 0 ввёл пользователь.
// 0, 7, 8, -2, -2 -> 2
// 1, -7, 567, 89, 223-> 3
Main();

void Main()
{
    Console.Write("Введите чила через запятую: ");
    string str = Console.ReadLine()!;

    int length = ArrayLength(str);
    
    int[] numbers = new int[length]; 

    int index = 0;
    for (int i = 0; i < str.Length; i++)         // исключаем из введеной строки запятые
    {
        string temp = "";

        while (str[i] != ',')
        {
            if (i != str.Length - 1)
            {
                temp += str[i]; i++;
            }
            else
            {
                temp += str[i]; break;
            }
        }
        numbers[index] = int.Parse(temp);
        index++;
    }
    Print(numbers);
    PositiveNumbers(numbers);
}
int ArrayLength(string s)   // Находим длинну массива
{
    int caunt = 1;
    for (int i = 0; i < s.Length; i++)
    {
       if (s[i] == ',')
      {
         caunt ++;
      }
    }
    return caunt;
}

void Print(int[] arr)
{
    for (int i = 0; i < arr.Length; i++)
    {
        Console.Write($"{arr[i]} ");
    }
}

void PositiveNumbers(int[] arr)
{
    int count = 0;
    foreach (int el in arr)
    {
        if (el > 0)
        {
            count++;

        }
    }
    Console.WriteLine($"Количество чисел больше нуля = {count}");
}


