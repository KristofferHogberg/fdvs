using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdvs
{
    public static class DeliveryDocExporter
    {
        private static string GenerateCsvString(FileValidation fileValidation)
        {
            //Needs to manually add columns below. NOT SCALEABLE.
            string columns = "File name,File path";
            string csvFormat = GenerateCsvStringOfRows(
                fileValidation.DeliveryDirectory.AllFileNamesInDirectory,
                fileValidation.DeliveryDirectory.AllFilePathsInDirectory,
                columns);
            return csvFormat;
        }

        private static string GenerateCsvStringOfRows(List<string> fileNames, List<string> filePaths, string columns)
        {
            //TODO - Generate Rows() should be a private method?
            //Looping through all files and filepaths and adding them together.
            List<string> rowsList = new List<string>() {};
            rowsList.Add(columns);
            for (int index = 0; index < fileNames.Count; index++)
            {
                rowsList.Add($"{fileNames[index]},{filePaths[index]}");
            }
            return string.Join("\n",rowsList);
        }

        //TODO - Create .csv exporter

        public static void ExportCsv(FileValidation fileValidation, string filePath)
        {
            var csvString = GenerateCsvString(fileValidation);
            Console.WriteLine($"\n\ncsvString contains:");
            Console.WriteLine(csvString);
        }

        //TODO - Create .xlsx exporter

        //TODO - Create .xml exporter
    }
}
