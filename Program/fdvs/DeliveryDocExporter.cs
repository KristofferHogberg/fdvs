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
        //TODO - Create support for column "Files not mentioned in provided list of deliverables:"
        //Needs to alter methods for GenerateCsvStringOfRows() (currently takes one overload)
        private static string GenerateCsvString(FileValidation fileValidation)
        {
            //Needs to manually add columns below. NOT SCALEABLE.
            string columns = "All files:,File paths:,Files not mentioned in provided list of deliverables:";
            string csvFormat = GenerateCsvStringOfRows(
                fileValidation.DeliveryDirectory.DeliveryFiles,
                columns);

            return csvFormat;
        }

        private static string GenerateCsvStringOfRows(List<DeliveryFile> files, string columns)
        {
            List<string> rowsList = new List<string>() {};
            rowsList.Add(columns);
            for (int index = 0; index < files.Count; index++)
            {
                rowsList.Add($"{files[index].FileName},{files[index].FilePath}");
            }
            return string.Join("\n",rowsList);
        }


        //TODO - Create .csv exporter that actually creates a csv, instead of altering an existing one.

        public static void ExportCsv(FileValidation fileValidation, string filePath)
        {
            var csvString = GenerateCsvString(fileValidation);
            File.WriteAllText(filePath, csvString, Encoding.UTF8);
        }

        //TODO - Create .xlsx exporter

        //TODO - Create .xml exporter
    }
}
