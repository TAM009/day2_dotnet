using System;

class MyArray
{

    public void show()
    {

            int[] array=new int[100];

            Console.WriteLine("Enter the size of the array:");

            int a=int.Parse(Console.ReadLine());

            array[0]=0;

            for(int i=0;i<a;i++)
            {
                array[i]=i+1;
                Console.WriteLine("Element{0} : {1}", i+1, array[i]);
                if(array[i]==11)
                {
                    Console.WriteLine("Array crosses 10!!");
                    break;
                }
                
            }

            

    }
}

class Program
{
        public static void Main()
        {
            MyArray M= new MyArray(); 

            M.show(); // To print array of class MyArray

            // Logic to execute fibonacci series begins//

            int[] array1=new int[1000];

            Console.WriteLine("Enter the number of terms upto which you want fibonacci series:");

            int size1=int.Parse(Console.ReadLine());

            array1[0]=0;

            array1[1]=1;

            for(int j=2;j<size1;j++)
            {
                array1[j]=array1[j-1]+array1[j-2];
            }

            Console.Write("The Required Fibonacci Series is: ");

            for(int j=0;j<size1;j++)
            {
                Console.Write("{0}, ",array1[j]);
            }

            //Logic ends//

        }
}

    