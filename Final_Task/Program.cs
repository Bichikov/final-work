// Написать программу которая из имеющегося массива строк формирует массив из строк, длина которых
// меньше либо равна 3 символа. Первоначальный массив можно ввести с клавиатуры,
// либо задать на старте выполения алгоритма. 
// При решении не рекомендуется пользоваться коллекциями, лучше обойтись исключительно массивами.

  string[] NewArray(string[] arr)
  {
    Random rnd = new Random();
    int size = new Random().Next(0,4); // 0, 1, 2, 3
    string[] arr2 = new string[size];

        for (int i = 0; i < size; i++)
            { 
                 arr2[i] = arr[rnd.Next(0,5)]; 
            }

return arr2;
  }


void PrintArray(string[] arr2)
{
    Console.Write("[");
    for (int i = 0; i < arr2.Length; i++)
    {
        if (i < arr2.Length - 1)
            Console.Write($"{arr2[i]}, ");
        else Console.Write($"{arr2[i]}");
    }
    Console.WriteLine("]");
}


 string[] array = {"hello", "2" , "world" , ":-)", "7"};
 string[] array2 = NewArray(array);
Console.Clear();
Console.Write("Изначальный массив --> ");
 PrintArray (array);
 Console.WriteLine(" ");
 Console.Write("Массив по заданию --> ");
 PrintArray (array2);

  

