using fdvs;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.IO;

namespace fdvsTests
{
    [TestClass]
    public class FileValidationProgramTests
    {
        static string projectDirectoryPath =
            Directory.GetCurrentDirectory()
            .Substring(0, Directory.GetCurrentDirectory().Length - 34);
        static string testCsvFilePath =
                projectDirectoryPath + @"Assets\TestInputData\TestCsvItemListInput.csv";
        static string testDeliveryDirectoryPath =
            projectDirectoryPath + @"Assets\TestInputData\TestDeliveryFolder";

        [TestMethod]
        public void GetAllMissingFileNames_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var fileValidationProgram = new FileValidationProgram(testCsvFilePath, testDeliveryDirectoryPath);

            // Act
            var result = fileValidationProgram.GetAllMissingFileNames();
            var expected = new List<string>() { "file6.txt" };

            // Assert
            CollectionAssert.AreEqual(expected, result);
        }

        [TestMethod]
        public void GetAllUnexpectedFiles_StateUnderTest_ExpectedBehavior()
        {
            // Arrange
            var fileValidationProgram = new FileValidationProgram(testCsvFilePath, testDeliveryDirectoryPath);

            // Act
            var result = fileValidationProgram.GetAllUnexpectedFiles();
            var expected = new List<string>() { "file6_incorrectlyNamed.txt" };

            // Assert
            Assert.Fail();
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
