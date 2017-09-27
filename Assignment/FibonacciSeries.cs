using System;

namespace FiboApp
{
    public class FiboSeries{

    public  int FiboFunction(int n)
        {
            try
            {
                if (n == 0)
                {
                    return 0;
                }
                else if (n == 1)
                {
                    return 1;
                }
                else
                {
                    return (FiboFunction(n - 1) + FiboFunction(n - 2));
                }
            }

            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
          
        }
  }
}