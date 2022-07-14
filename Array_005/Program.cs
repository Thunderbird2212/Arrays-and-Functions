void FillArray(int[] collection) //void "not returning value" 
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col) // void - пустота
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }

}

int[] array = new int[10]; //make new array with 10 elements.

FillArray(array);
PrintArray(array);