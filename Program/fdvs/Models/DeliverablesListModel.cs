using fdvs.DataAccess;
using System;
using System.Collections.Generic;
using System.IO;

namespace fdvs.Models
{
    /// <summary>
    /// Model containing the list of all requested filenames, incl file extension,
    /// that are to be part of the delivery.
    /// At this point in time, .csv is the only
    /// supported format for import.
    /// </summary>
    public class DeliverablesListModel
    {
        public List<string> FileNameList { get; set; } = new List<string>();

        //TODO - Should refactor so that the constructor takes a
        //stringlist with the filenames, and create parsers for
        //csv, xml, and xlsx.

        /// <summary>
        /// The constructor currently accepts a filepath to a .csv, 
        /// which it then reads and parse to a list of string literals.
        /// </summary>
        /// <param name="filePath">Filepath to .csv file.</param>
        public DeliverablesListModel(string filePathToCsvFile)
        {
            FileNameList = FileParser.CsvParser(filePathToCsvFile);
        }
    }
}
