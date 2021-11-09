using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using fdvs.DataAccess;

namespace fdvsTests.DataAccess
{
    [TestClass]
    public class FileParserTests
    {
        [TestMethod]
        public void CsvParser_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var fileParser = new FileParser();
            string filePath = null;

            // Act
            var result = fileParser.CsvParser(
                filePath);

            // Assert
            Assert.Fail();
        }
    }
}
