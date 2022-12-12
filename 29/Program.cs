// апишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


int[] GetArray(int size, int min, int max)
{
    int[] res = new int[size];
    for(int i=0; i<size; i++)
    {
        res[i]= new Random().Next(min,max);
    }
    return res;
}

void PrintArray(int[] arr)
{
    for (int i=0; i<arr.Length; i++)
    {
        Console.Write($"{arr[i]}  ");
    }
}

PrintArray(GetArray(8,1,100));