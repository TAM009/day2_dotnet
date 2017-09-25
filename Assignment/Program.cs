using System;
using FiboApp;

public class MyArray
{
     
    public int show()
    {

            int[] array=new int[100];

            Console.WriteLine("Enter the size of the array:");

            int a=int.Parse(Console.ReadLine());

            array[0]=0;

            for(int i=0;i<a;i++)
            {
                array[i]=i+1;
                if(array[i]==11)
                {
                    Console.WriteLine("Array crosses 10!!");
                }
                
            }

            return 0;

    }
}




public class Program
{
                public static void Main()
                {
                    MyArray M= new MyArray();

                    M.show(); 

                    int n, i = 0, c;
                    Console.WriteLine("Enter the number of terms:");
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