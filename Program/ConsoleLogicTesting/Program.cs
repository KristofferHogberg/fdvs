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
            string projectDirectoryPath = 
                Directory.GetCurrentDirectory().Substring(0, Directory.GetCurrentDirectory().Length - 44);
            string testCsvFilePath = projectDirectoryPath + @"Assets\TestInputData\TestCsvItemListInput.csv";
            string testDeliveryDirectoryPath = projectDirectoryPath + @"Assets\TestInputData\TestDeliveryFolder";

            //Initializing values:
            FileValidation filevalidation = new FileValidation(testCsvFilePath, testDeliveryDirectoryPath);

            List<string> csvImport = filevalidation.Deliverables.FileNameList;

            List<string> allFilenames = filevalidation.DeliveryDirectory.GetAllFileNames();

            List<string> allFilePaths = filevalidation.DeliveryDirectory.GetAllFilePaths();

            List<string> extraFilenames = filevalidation.GetAllFilesNotInDeliverables();

            List<string> missingFileNames = filevalidation.GetAllMissingFileNames();

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

            //Console.WriteLine("\nTesting edit of csv:");
            //DeliveryDocExporter.ExportCsv(filevalidation, $@"{projectDirectoryPath}Exports\TestCsvExport.csv");
            //Console.WriteLine("Csv edited.");

            //Console.WriteLine("\nTesting XML export:");
            //DeliveryDocExporter.ExportXML(filevalidation, $@"{projectDirectoryPath}Exports\TestXmlExport.xml");
        }
    }
}
