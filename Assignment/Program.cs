using System;
using FiboApp;
using maincode;


public class Program
{
                public static void Main()
                {
                    int size;

                    Console.WriteLine("enter the size of the array");

                    size=int.Parse(Console.ReadLine());

                    MyArray M= new MyArray();

                    M.show(size); 

                    int n, i = 0, c;
                    Console.WriteLine("Enter the number of terms of the fibonacci series:");
                    n = int.Parse(Console.ReadLine()) ;

                    Console.WriteLine("Fibonacci series\n");

                    FiboSeries f1=new FiboSeries();
                    for (c = 1; c <= n; c++)
                    {
                        int result = f1.FiboFunction(i);
                        Console.Write(result + " " );
                        i++;
                    }
                    Console.WriteLine();

             
                }
}