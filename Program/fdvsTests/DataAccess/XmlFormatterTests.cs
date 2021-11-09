using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using fdvs.DataAccess;

namespace fdvsTests.DataAccess
{
    [TestClass]
    public class XmlFormatterTests
    {
        [TestMethod]
        public void DeliveryFileToXElement_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var xmlFormatter = new XmlFormatter();
            DeliveryFileModel file = null;

            // Act
            var result = xmlFormatter.DeliveryFileToXElement(
                file);

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void FileNameToXElement_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var xmlFormatter = new XmlFormatter();
            string fileName = null;

            // Act
            var result = xmlFormatter.FileNameToXElement(
                fileName);

            // Assert
            Assert.Fail();
        }
    }
}
