using System;  
namespace CSharpProgram  
{  
    class Program  
    {  
        static void Main(string[] args)  
        {  
            // Creating an array  
            int[] arr = new int[6] { 5, 8, 9, 25, 0, 7 };  
            // Creating an empty array  
            int[] arr2 = new int[6];  
            // Displaying length of array  
            Console.WriteLine("lenght :" + arr.Length);
            Array.Sort(arr);
            PrintArray(arr);
           
        }  
        static void PrintArray(int[] arr)
        {
            foreach(Object elem in arr)
            {
                Console.Write(elem+" ");
            }
        }
        
    }  
}  