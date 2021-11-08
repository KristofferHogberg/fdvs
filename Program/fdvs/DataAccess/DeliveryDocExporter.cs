using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Xml.Linq;
using System.Xml;
using fdvs.DataAccess;
using fdvs.Models;

namespace fdvs.DataAccess
{
    /// <summary>
    /// Contains methods for exporting information regarding the files which exists within the delivery folder.
    /// </summary>
    public static class DeliveryDocExporter
    {
        //TODO - Create support for column "Files not mentioned in provided list of deliverables:"
        //Needs to alter methods for GenerateCsvStringOfRows() (currently takes one overload)
        private static string GenerateCsvString(FileValidationProgram fileValidation)
        {
            //Needs to manually add columns below. NOT SCALEABLE.
            string columns = "All files:,File paths:,Files not mentioned in provided list of deliverables:";
            string csvFormat = GenerateCsvStringOfRows(
                fileValidation.DeliveryDirectory.DeliveryFiles,
                columns);

            return csvFormat;
        }

        private static string GenerateCsvStringOfRows(List<DeliveryFileModel> files, string columns)
        {
            //TODO - Generate Rows() should be a private method?
            //Looping through all files and filepaths and adding them together.
            List<string> rowsList = new List<string>() {};
            rowsList.Add(columns);
            for (int index = 0; index < files.Count; index++)
            {
                rowsList.Add($"{files[index].FileName},{files[index].FilePath}");
            }
            return string.Join("\n",rowsList);
        }


        //TODO - Create .csv exporter that actually creates a csv, instead of altering an existing one.

        public static void ExportCsv(FileValidationProgram fileValidation, string filePath)
        {
            var csvString = GenerateCsvString(fileValidation);
            File.WriteAllText(filePath, csvString, Encoding.UTF8);
        }

        /// <summary>
        /// Generates a formatted/indented XDocument from a list of files provided by a FileValidation object.
        /// </summary>
        /// <param name="fileValidation"></param>
        /// <returns></returns>
        private static XDocument GenerateXML(FileValidationProgram fileValidation)
        {
            var files = fileValidation.DeliveryDirectory.DeliveryFiles;

            var missingFiles = new XElement("MissingFiles", fileValidation
                .GetAllMissingFileNames()
                .Select(fileName => XmlFormatter.FileNameToXElement(fileName)));

            var extraFiles = new XElement("ExtraFiles", fileValidation
                .AllExtraFileNamesInDirectory
                .Select(fileName => XmlFormatter.FileNameToXElement(fileName)));

            var matchingFiles = new XElement("MatchingFiles", files
                .Where(file => !fileValidation
                    .GetAllMissingFileNames()
                        .Contains(file.FileName))
                .Select(file => XmlFormatter.DeliveryFileToXElement(file)));

            var doc = new XDocument(new XElement("Root"));
            doc.Root.Add(new XComment("Expected files that were missing."));
            doc.Root.Add(missingFiles);
            doc.Root.Add(new XComment("Extra files that were not expected."));
            doc.Root.Add(extraFiles);
            doc.Root.Add(new XComment("Matching files."));
            doc.Root.Add(matchingFiles);

            return doc;
        }

        public static void ExportXML(FileValidationProgram fileValidation, string filePath)
        {
            var xml = GenerateXML(fileValidation);

            // Debug code that prints the XML string to the console.
            Console.WriteLine("\n\nXDocument contains:");
            Console.WriteLine(xml.ToString());

            using XmlWriter xw = XmlWriter.Create(filePath, 
                new XmlWriterSettings
                {
                    OmitXmlDeclaration = false,
                    ConformanceLevel = ConformanceLevel.Document,
                    Encoding = Encoding.UTF8,
                    Indent = true
                });

                xml.Save(xw);
        }
    }
}
