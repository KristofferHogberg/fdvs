using System;
using System.Collections.Generic;
using System.IO;

namespace fdvs
{
    /// <summary>
    /// Contains methods for parsing different types of datastreams, such as .csv, .xml, or .xlsx.
    /// </summary>
    static class FileParser
    {
        /// <summary>
        /// Reads a single column csv and returns a list of strings.
        /// </summary>
        /// <param name="filePath">Filepath to the .csv file.</param>
        /// <returns></returns>
        public static List<string> CsvParser(string filePath)
        {
            var output = new List<string>();
            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    output.Add(line.Trim());
                }
            }
            return output;
        }

        //TODO - Create a file parser for excel files
        //public static List<string> XlxsParser(string filePath)
        //{

        //}
    }
}
