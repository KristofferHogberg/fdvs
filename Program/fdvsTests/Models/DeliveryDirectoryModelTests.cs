using Microsoft.VisualStudio.TestTools.UnitTesting;
using fdvs.Models;

namespace fdvsTests.Models
{
    [TestClass]
    public class DeliveryDirectoryModelTests
    {
        [TestMethod]
        public void GetAllFileNames_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var deliveryDirectoryModel = new DeliveryDirectoryModel(TODO);

            // Act
            var result = deliveryDirectoryModel.GetAllFileNames();

            // Assert
            Assert.Fail();
        }

        [TestMethod]
        public void GetAllFilePaths_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var deliveryDirectoryModel = new DeliveryDirectoryModel(TODO);

            // Act
            var result = deliveryDirectoryModel.GetAllFilePaths();

            // Assert
            Assert.Fail();
        }
    }
}
