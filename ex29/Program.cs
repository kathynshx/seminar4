//Задача 29: Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.
//1, 2, 5, 7, 19, 6, 1, 33 -> [1, 2, 5, 7, 19, 6, 1, 33]

int[] mas = {1,2,5,7,19,6,1,33};
PrintArray(mas);

void PrintArray(int[] array)
{
    for (int i= 0;i < array.Length; i++)
    {
        Console.Write(array[i]);
        if (i< array.Length -1)
        {
            Console.Write(",");
        }
    }
}
