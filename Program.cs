//Задача 50. Напишите программу, которая на вход принимает элемент в двумерном массиве, 
//и возвращает его индексы первого найденого числа или же указание, что такого элемента нет.
//Например, задан массив:
//1 4 7 2
//5 9 2 3
//8 4 2 4
//17 -> такого числа в массиве нет

int SetNumber(string text = "")
{
    Console.Write($"Введите число: {text}: ");
    int num = Convert.ToInt32(Console.ReadLine());
    return num;
}
int number = SetNumber();

void GetArray(int[,] array, int min,int max)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {
            array[i, j] = new Random().Next(min, max +1);
             Console.Write($"{array[i, j]} ");
             
        }
        Console.WriteLine(); 
    }
}

void FindNumber(int[,] array)
{
    for (int i = 0; i < array.GetLength(0); i++)
    {
        for (int j = 0; j < array.GetLength(1); j++)
        {         
           if (number == array[i,j])
           {
           Console.Write($" индекс данной цифра  в массиве = {i};{j} "); 
           break;
           }
           //else Console.Write ("");
           
        }


    }

}



Console.Clear();
int[,] array = new int[3, 4];
GetArray(array, 1, 4);
FindNumber(array);