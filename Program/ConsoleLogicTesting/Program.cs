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
            Console.WriteLine("Parsing csv and adding to a new DeliverablesListModel");

            //Get test directory for test values
            var baseDirectoryPath = Directory.GetCurrentDirectory();
            var projectDirectoryPath = baseDirectoryPath.Substring(0, baseDirectoryPath.Length - 44);
            var testCsvFilePath = projectDirectoryPath + @"Assets\TestInputData\TestCsvItemListInput.csv";

            var testDeliverablesList = new DeliverablesListModel(testCsvFilePath);
            foreach (var fileName in testDeliverablesList.FileNameList)
            {
                Console.WriteLine(fileName);
            }

            Console.WriteLine("\nAdding fileinfos from delivery directory:");

            //Testing import of filedirectory of delivery.
            var deliveryFolder = new DeliveryDirectoryModel(projectDirectoryPath + @"Assets\TestInputData\TestDeliveryFolder");
            foreach (var fileInfo in deliveryFolder.AllFilesInDeliveryFolder)
            {
                Console.WriteLine(fileInfo.Name); 
            }

            Console.WriteLine("\nTesting to compare values:");
            List<string> filesNotInDeliverables = FileValidation.GetFilesNotInDeliverables(deliveryFolder);

        }
    }
}
