using System;
using Console;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace Demos.Console.Tests
{
    [TestClass]
    public class ConsoleTests
    {
        [TestMethod]
        public void Can_Get_Program()
        {
            // Testig that the Nuget lib (MOQ) is atually referenced.
            var mock = new Mock<Program>();

            var program = new Program();
            
            Assert.IsNotNull(program);
        }
    }
}
