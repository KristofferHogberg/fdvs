using fdvs.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace fdvsTests.DataAccess
{
    [TestClass]
    public class FileParserTests
    {
        [TestMethod]
        public void CsvParser_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            string filePath = null;

            // Act
            var result = FileParser.CsvParser(
                filePath);

            // Assert
            Assert.Fail();
        }
    }
}
