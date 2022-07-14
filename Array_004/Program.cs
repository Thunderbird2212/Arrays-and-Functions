int[] array = { 34, 12, 3, 34, 5, 16, 7, 88, 91 };
int n = array.Length;
int find = 34;
int index = 0;
while (index < n)
{
    if (array[index] == find)
    {
        Console.WriteLine(index);
        break; //find first similar element 
    }
    //index = index + 1;
    index++;
}