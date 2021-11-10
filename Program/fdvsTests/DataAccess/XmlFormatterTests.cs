using fdvs.DataAccess;
using fdvs.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace fdvsTests.DataAccess
{
    [TestClass]
    public class XmlFormatterTests
    {
        [TestMethod]
        public void DeliveryFileToXElement_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            DeliveryFileModel file = null;

            // Act
            var result = XmlFormatter.DeliveryFileToXElement(
                file);

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void FileNameToXElement_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            string fileName = null;

            // Act
            var result = XmlFormatter.FileNameToXElement(
                fileName);

            // Assert
            Assert.Fail();
        }
    }
}
