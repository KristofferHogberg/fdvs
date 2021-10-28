using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

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

        public static XElement GenerateXml(FileValidation fileValidation)
        {
            //TODO: Refactor method to take DeliveryFile objects rather than strings
            var fileNames = fileValidation.DeliveryDirectory.AllFileNamesInDirectory;
            var filePaths = fileValidation.DeliveryDirectory.AllFilePathsInDirectory;

            var deliveryFiles = fileNames.Zip(filePaths, (file, path) => Tuple.Create(file, path))
            .ToList();

            var unparsedXml = new XElement("DeliveryFiles",
                deliveryFiles
                    .Select(item => new XElement("File",
                        new XElement("FileName", item.Item1),
                        new XElement("FilePath", item.Item2))))
                .ToString();

            return XElement.Parse(unparsedXml);
        }

        public static void ExportXml(FileValidation fileValidation, string filePath)
        {
            var xml = GenerateXml(fileValidation);
            Console.WriteLine("\n\nxmlString contains:");
            Console.WriteLine(xml.ToString());

            // TODO: Actual export to XML file.
        }

        ///// <summary>
        ///// Placeholder test class
        ///// </summary>
        //[Serializable]
        //private class DeliveryFile
        //{
        //    public string FileName { get; }
        //    public string FilePath { get; }
        //    public bool InDeliverables { get; set; }

        //    public DeliveryFile(string fileName, string filePath)
        //    {
        //        FileName = fileName;
        //        FilePath = filePath;
        //    }
        //}
        //public static void ExportXml(FileValidation fileValidation, string filePath)
        //{
        //    using (XmlWriter writer = XmlWriter.Create())
        //}
        //TODO - Create .xlsx exporter

        //TODO - Create .xml exporter
    }
}
