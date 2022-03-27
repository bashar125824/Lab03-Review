using System;
using Xunit;
using ConsoleApp2;

namespace TestProject1
{
    public class Program
    {
        [Fact]
        public void Test1_Less_than_3_inputs()
        {

            // If user Entered less than 3 inputs
            string[] arr = { "1", "3" };
            // it should return 0
            Assert.Equal(0, ConsoleApp2.Program.GetProduct(arr));



        }

        [Fact]
        public void Test1_More_than_3_inputs()
        {
            // If user Entered more than 3 inputs
            string[] arr2 = { "1", "2", "3", "4" };
            // it should return product of first 3 numbers (6)
            Assert.Equal(6, ConsoleApp2.Program.GetProduct(arr2));
        }

        [Fact]
        public void Test1__3_inputs()
        {
            // If user Entered  3 inputs
            string[] arr3 = { "4", "4", "1"};
            // it should return product  3 numbers (16)
            Assert.Equal(16, ConsoleApp2.Program.GetProduct(arr3));
        }

        [Fact]
        public void Test2__0_inputs()
        {
            
            int[] arr = { 0 , 0 , 0 };
           
            Assert.Equal(0, ConsoleApp2.Program.Average(arr));
        }
    }
}

