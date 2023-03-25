/* Написать программу, которая из имеющегося массива строк формирует массив из строк,
длина которых меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
либо задать на старте выполнения алгоритма.
Например:
["hello", "2", "world", ":-)"] -> ["2", ":-)"] 
["1234", "1567", "-2", "computer science"] -> ["-2"]
["Russia", "Denmark", "Kazan"] -> []       */ 


// Ввод массива на старте выполнения.

//string[] input = new string[4] {"hello", "2", "world", ":)"};

//string[] input = new string[4] {"1234", "1567", "-2", "computer science"};

//string[] input = new string[3] {"Russia", "Denmark", "Kazan"};



// Запросить у пользователя ввод массива строк.

Console.WriteLine("Введите строки через пробел: ");       

string[] input = Console.ReadLine()!.Split(' ');

// Создать новый массив строк, содержащий только строки, длина которых меньше или равна 3-ем символам/

string[] output = new string[input.Length];

int count = 0;

for (int i = 0; i < input.Length; i++)
{
    if(input[i].Length <= 3)
    {
        output[count] = input[i];
        count++;
    }
}

Array.Resize(ref output, count);

// Вывести результат.

Console.WriteLine("Результат: ");

Console.WriteLine();

Console.WriteLine($"[{string.Join(", ", input)}] -> [{string.Join(", ", output)}]");

Console.WriteLine();

// Завершить программу/

Console.WriteLine("Нажмите любую клавишу для завершения программы.");

Console.ReadLine();

