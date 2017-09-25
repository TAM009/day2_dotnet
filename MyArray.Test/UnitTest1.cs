using System;
using FiboApp;
using Xunit;

namespace fibonacciTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            //Arrange
             FiboSeries fibo = new FiboSeries();

             //Act
            var result=fibo.FiboFunction(0);  

            
            //Assert
            Assert.IsType<int>(result);
            Assert.Equal(0,result);
            Assert.NotEqual(7,result);

            

        }

        [Fact]
        public void Test2()
        {
            //Arrange
             FiboSeries fibo = new FiboSeries();

             //Act
            var result=fibo.FiboFunction(3);  

            
            //Assert
            Assert.IsType<int>(result);
            Assert.Equal(1,result);
            Assert.NotEqual(5,result);

            

        }
    }
}
