using System;
using Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Demos.Console.Tests
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void Can_Get_Program()
        {
            var mock = new Mock<Program>();

            var program = new Program();
            
            Assert.IsNotNull(program);
        }
    }
}
