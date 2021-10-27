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
            string columns1 = "File name,File path";
            string csvFormat1 = GenerateCsvStringOfRows(
                fileValidation.DeliveryDirectory.AllFileNamesInDirectory,
                fileValidation.DeliveryDirectory.AllFilePathsInDirectory,
                columns1);

            throw new NotImplementedException();
            //TODO finish this code
            string columns2 = "Extra files (not included in list of requested deliverables)";
            //string csvFormat2 = GenerateCsvStringOfRows(fileValidation.)
            //return csvFormat;
        }

        private static string GenerateCsvStringOfRows(List<string> filePaths, string columns)
        {
            List<string> rowsList = new List<string>() { };
            rowsList.Add(columns);
            for (int index = 0; index < filePaths.Count; index++)
            {
                rowsList.Add($"{filePaths[index]}");
            }
            return string.Join("\n", rowsList);
        }
        private static string GenerateCsvStringOfRows(List<string> fileNames, List<string> filePaths, string columns)
        {
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
            File.WriteAllText(filePath, csvString, Encoding.ASCII);
        }

        //TODO - Create .xlsx exporter

        //TODO - Create .xml exporter
    }
}
