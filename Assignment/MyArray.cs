using System;

namespace maincode
{
    public class MyArray
    {
        public void show(int s)
        {
            try
            {
                int[] arr= new int[s];

                for(int i=1;i<s;i++)
                {
                    arr[i]=i;

                    if(arr[i]==11)
                    Console.WriteLine("Array Crosses 10!");

                    Console.WriteLine("Element {0} : {1}",i,arr[i]);
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }

    }
}