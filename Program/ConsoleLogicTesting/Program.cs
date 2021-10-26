using System;
using System.Collections.Generic;
using System.IO;
using fdvs;

namespace ConsoleLogicTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            //Getting project directory path to access test data
            //string baseDirectoryPathOfAssembly = Directory.GetCurrentDirectory();
            string projectDirectoryPath = 
                Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 44);
            string testCsvFilePath = projectDirectoryPath + @"Assets\TestInputData\TestCsvItemListInput.csv";
            string testDeliveryDirectoryPath = projectDirectoryPath + @"Assets\TestInputData\TestDeliveryFolder";

            //Initializing values:
            FileValidation filevalidation = new FileValidation(testCsvFilePath, testDeliveryDirectoryPath);

            List<string> csvImport = filevalidation.Deliverables.FileNameList;

            List<string> allFilenames = filevalidation.GetAllFileNamesInDeliveryFolder(
                filevalidation.DeliveryDirectory);

            List<string> allFilePaths = filevalidation.GetAllFilePathsInDeliveryFolder(
                filevalidation.DeliveryDirectory);

            List<string> extraFilenames = filevalidation.GetAllExtraFileNamesNotIncludedInDelivery(
                filevalidation.Deliverables.FileNameList, filevalidation.DeliveryDirectory);

            List<string> missingFileNames = filevalidation.GetAllMissingFileNames(
                filevalidation.Deliverables.FileNameList, filevalidation.DeliveryDirectory);

            //Listing all values:

            Console.WriteLine(".csv import:");
            foreach (var fileName in csvImport)
            {
                Console.WriteLine("    -" + fileName);
            }

            Console.WriteLine("\nAll files in delivery directory:");
            foreach (var fileName in allFilenames)
            {
                Console.WriteLine("    -" + fileName);
            }

            Console.WriteLine("\nFile paths in delivery directory:");
            foreach (var filePath in allFilePaths)
            {
                Console.WriteLine("    -" + filePath);
            }

            Console.WriteLine("\nExtra files in delivery directory (not mentioned in .csv):");
            foreach (var fileName in extraFilenames)
            {
                Console.WriteLine("    -" + fileName);
            }

            Console.WriteLine("\nMissing files in delivery directory:");
            foreach (var fileName in missingFileNames)
            {
                Console.WriteLine("    -" + fileName);
            }
        }
    }
}
