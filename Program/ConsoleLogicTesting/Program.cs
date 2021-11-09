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
                Directory.GetCurrentDirectory()
                .Substring(0, Directory.GetCurrentDirectory().Length - 44);
            string testCsvFilePath = 
                projectDirectoryPath + @"Assets\TestInputData\TestCsvItemListInput.csv";
            string testDeliveryDirectoryPath = 
                projectDirectoryPath + @"Assets\TestInputData\TestDeliveryFolder";

            //Initializing values:
            FileValidationProgram filevalidation = 
                new FileValidationProgram(testCsvFilePath, testDeliveryDirectoryPath);

            //Listing all values:

            WriteLineEachString("Deliverables from .csv import:", 
                filevalidation.Deliverables.FileNameList);

            WriteLineEachString("All files in delivery directory:", 
                filevalidation.DeliveryDirectory.GetAllFileNames());

            WriteLineEachString("File paths in delivery directory:", 
                filevalidation.DeliveryDirectory.GetAllFilePaths());

            WriteLineEachString("Extra files in delivery directory (not mentioned in .csv):", 
                filevalidation.GetAllUnexpectedFiles());

            WriteLineEachString("Missing files in delivery directory:", 
                filevalidation.GetAllMissingFileNames());

            //Console.WriteLine("\nTesting edit of csv:");
            //DeliveryDocExporter.ExportCsv(filevalidation, $@"{projectDirectoryPath}Exports\TestCsvExport.csv");
            //Console.WriteLine("Csv edited.");

            //Console.WriteLine("\nTesting XML export:");
            //DeliveryDocExporter.ExportXML(filevalidation, $@"{projectDirectoryPath}Exports\TestXmlExport.xml");
        }

        private static void WriteLineEachString(string message, List<string> collection)
        {
            Console.WriteLine(message);
            foreach (var item in collection)
            {
                Console.WriteLine("    -" + item);
            }
            Console.WriteLine();
        }
    }
}
