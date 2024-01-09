int max = 3; 

string[] array1 = { "Hello", "2", "world", ":-)" };
string[] array2 = { "1234", "1567", "-2", "computer science" };
string[] array3 = { "Russia", "Denmark", "Kazan" };


int CountItems(string[] arr, int max)
{
    int count = 0;                                      
    for (int i = 0; i < arr.Length; i++)                
    {
        if (arr[i].Length <= max) count++;              
    }
    return count;                                      
}


string[] NewArray(string[] arr, int max)
{
    int newArrayLenght = CountItems(arr, max);          
    string[] newArray = new string[newArrayLenght];     
    int newArrayIndex = 0;                              
    for (int i = 0; i < arr.Length; i++)                
    {
        if (arr[i].Length <= max)                       
        {
            newArray[newArrayIndex] = arr[i];           
            newArrayIndex++;                            
        }
    }
    return newArray;                                    
}


void PrintArray(string[] array)
{
    System.Console.Write("[");
    for (int i = 0; i < array.Length; i++)
    {
        System.Console.Write('"');
        System.Console.Write(array[i]);
        System.Console.Write('"');
        if (i < array.Length - 1) System.Console.Write(", ");
    }
    System.Console.Write("]");
}


string[] newArray1 = NewArray(array1, max);
PrintArray(newArray1);
System.Console.WriteLine();
string[] newArray2 = NewArray(array2, max);
PrintArray(newArray2);
System.Console.WriteLine();
string[] newArray3 = NewArray(array3, max);
PrintArray(newArray3);