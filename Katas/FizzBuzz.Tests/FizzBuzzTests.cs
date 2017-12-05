using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FizzBuzz.Tests
{
    [TestClass]
    public class FizzBuzzTests
    {
        [TestMethod]
        public void RunPogram_Prints_Numbers()
        {
            var program = new Fizz();
            program.RunProgram();
        }
    }
}
