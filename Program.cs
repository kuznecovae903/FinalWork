// Задача:
//Написать программу, которая из имеющегося массива строк формирует массив из строк,
//длина которых меньше либо равна 3 символа. 
//Первоначльный массив можно ввести с клавиатуры, 
//либо задать на старте выполнения алгоритма. 
//При решении рекомендуется пользоваться коллекциями, лучше обойтись массивами.



string[] array1 = new string[5] {"result", "23", "hello", "world", "res"};
string[] array2 = new string[array1.Length];

void SecondArrayWithIF(string[] array1, string[] array2)
{
    int count = 0;
    for (int i = 0; i < array1.Length; i++)
    {
    if(array1[i].Length <= 3)
        {
        array2[count] = array1[i];
        count++;
        }
    }
}

void PrintArray(string[] array)
{
    Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
                Console.Write($"{array[i]} ");
    }
    Console.WriteLine("]");
}
SecondArrayWithIF(array1, array2);
PrintArray(array2);


/*
Console.Write("Сколько элементов Вы хотите ввести? ");
int size  =  Convert.ToInt32(Console.ReadLine());

string [] arrayStrings = new string [size];
for (int  i = 0; i < size; i++) 
{
    Console.WriteLine($"Введите {i+1}-й элемент: ");
    string element = Convert.ToString(Console.ReadLine());
    element = default;
    arrayStrings[i] = element;
}

string[] arrayFinal = new string[size];
int lengh = 3;
int k = 0;

for (int  j = 0; j < size; j ++)
{
    if (arrayStrings[j].Length <= lengh)
    {
        arrayFinal[k] = arrayStrings[j];
        ++k;
    }
}

Console.WriteLine();
printArray(arrayFinal);

void printArray (string[] arr)
{
    for (int  i = 0; i < arr.Length; i++)
    {
        Console.Write(arr [i] + " ");
    }
    Console.WriteLine();
}
*/