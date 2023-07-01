
//Bubble sort

int[] array = new int[7] {10,5,7,2,5,4,1};


for(int i=0; i<array.Length; i++)
{
    for (int j = i + 1; j < array.Length; j++)
    {
        if (array[i] > array[j])
        {
            int temp = array[i];
            array[i] = array[j];
            array[j] = temp;
        }
    }
    Console.Write($"{array[i]}, ");
}