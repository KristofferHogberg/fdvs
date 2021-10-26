using System;
using System.IO;
using fdvs;

namespace ConsoleLogicTesting
{
    class Program
    {
        static void Main(string[] args)
        {
            var baseDirectoryPath = Directory.GetCurrentDirectory();
            var projectDirectoryPath = baseDirectoryPath.Substring(0, baseDirectoryPath.Length - 44);
            var testCsvFilePath = projectDirectoryPath + @"Assets\TestInputData\TestCsvItemListInput.csv";
            var testDeliverablesList = new DeliverablesListModel(testCsvFilePath);

            foreach (var fileName in testDeliverablesList.FileNameList)
            {
                Console.WriteLine(fileName);
            }
        }
    }
}
