using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ACM.Library.Test
{
    [TestClass]
    public class BuilderTest
    {
        public TestContext TestContext { get; set; }

        [TestMethod]
        public void BuildIntegerSequenceTest()
        {
            //Arrange
            Builder listBuilder = new Builder();

            //Act
            var result = listBuilder.BuilIntegerSequence();

            //Analyze
            foreach(var item in result)
            {
                TestContext.WriteLine(item.ToString());
            }

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void BuildStringSequenceTest()
        {
            //Arrange
            Builder listBuilder = new Builder();

            //Act
            var result = listBuilder.BuildStringSequence();

            //Analyze
            foreach (var item in result)
            {
                TestContext.WriteLine(item.ToString());
            }

            //Assert
            Assert.IsNotNull(result);
        }
    }
}
