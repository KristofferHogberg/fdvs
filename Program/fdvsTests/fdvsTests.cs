using Microsoft.VisualStudio.TestTools.UnitTesting;
using fdvs;
using System.IO;
using System.Collections.Generic;
using fdvs.Models;

namespace fdvsTests
{
    [TestClass]
    public class fdvsTests
    {
        //Getting project directory path to access test data
        string projectDirectoryPath =
            Directory.GetCurrentDirectory()
            .Substring(0, Directory.GetCurrentDirectory().Length - 34);

        [TestMethod]
        public void GetMissingFilesTest()
        {
            string testCsvFilePath =
                projectDirectoryPath + @"Assets\TestInputData\TestCsvItemListInput.csv";
            string testDeliveryDirectoryPath =
                projectDirectoryPath + @"Assets\TestInputData\TestDeliveryFolder";

            var filevalidation = new FileValidationProgram(testCsvFilePath, testDeliveryDirectoryPath);
            var actual = filevalidation.GetAllMissingFileNames();
            var expected = new List<string>() { "file6.txt" };
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void GetAllUnexpectedFilesTest()
        {
            string testCsvFilePath =
                projectDirectoryPath + @"Assets\TestInputData\TestCsvItemListInput.csv";
            string testDeliveryDirectoryPath =
                projectDirectoryPath + @"Assets\TestInputData\TestDeliveryFolder";

            var filevalidation = new FileValidationProgram(testCsvFilePath, testDeliveryDirectoryPath);
            var actual = filevalidation.GetAllUnexpectedFiles();
            var expected = new List<string>() { "file6_incorrectlyNamed.txt" };
            CollectionAssert.AreEqual(expected, actual);
        }

    }
}
