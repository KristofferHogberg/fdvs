using fdvs;
using fdvs.DataAccess;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace fdvsTests.DataAccess
{
    [TestClass]
    public class DeliveryDocExporterTests
    {
        [TestMethod]
        public void ExportCsv_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            FileValidationProgram fileValidation = null;
            string filePath = null;

            // Act
            DeliveryDocExporter.ExportCsv(
                fileValidation,
                filePath);

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void ExportXML_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            FileValidationProgram fileValidation = null;
            string filePath = null;

            // Act
            DeliveryDocExporter.ExportXML(
                fileValidation,
                filePath);

            // Assert
            Assert.Fail();
        }
    }
}
