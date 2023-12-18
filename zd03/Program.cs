//Задайте произвольный массив. Выведете его элементы, начиная с конца. Использовать рекурсию, не использовать циклы.
// [1, 2, 5, 0, 10, 34] => 34 10 0 5 2 1 

int [] myArray = new int [5] {23,0,56,12,3}; //произвольный массив
int start = 0;
PrintArray(myArray,start);

void PrintArray (int [] array, int i)
{
    if(i < array.Length)
    {
        Console.Write(array[(array.Length - 1) - i] + " ");
        i++;
        PrintArray(array,i);
    }

}