using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using fdvs.DataAccess;

namespace fdvsTests.DataAccess
{
    [TestClass]
    public class DeliveryDocExporterTests
    {
        [TestMethod]
        public void ExportCsv_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var deliveryDocExporter = new DeliveryDocExporter();
            FileValidationProgram fileValidation = null;
            string filePath = null;

            // Act
            deliveryDocExporter.ExportCsv(
                fileValidation,
                filePath);

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void ExportXML_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var deliveryDocExporter = new DeliveryDocExporter();
            FileValidationProgram fileValidation = null;
            string filePath = null;

            // Act
            deliveryDocExporter.ExportXML(
                fileValidation,
                filePath);

            // Assert
            Assert.Fail();
        }
    }
}
