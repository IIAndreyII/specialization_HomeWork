// Задача: Написать программу, которая из имеющегося массива строк 
// формирует новый массив из строк, длина которых меньше, либо равна 3 символам. 
// Первоначальный массив можно ввести с клавиатуры, 
// либо задать на старте выполнения алгоритма. При решении не рекомендуется пользоваться коллекциями, 
// лучше обойтись исключительно массивами.

// Примеры:
// [“Hello”, “2”, “world”, “:-)”] → [“2”, “:-)”]
// [“1234”, “1567”, “-2”, “computer science”] → [“-2”]
// [“Russia”, “Denmark”, “Kazan”] → []

string[] inputArray = {"Hello", "2", "world", ":-)"};

int a = 0;
int count = 0;

Console.WriteLine();


while(a < inputArray.Length)
{   
    if (inputArray[a].Length - 1 < 3)
    {
        count++;
    }
    Console.Write(inputArray[a] + ", ");
    a++;    
}
Console.WriteLine();


string[] endArray = new string[count];

int b = 0;
int c = 0;

while (b < inputArray.Length)
{
    if (inputArray[b].Length - 1 < 3)
    {
        endArray[c] = inputArray[b];
        Console.Write(endArray[c] + ", ");
        c++;
    }
    b++;
}

Console.WriteLine();


