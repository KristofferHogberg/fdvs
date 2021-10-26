using System;
using System.Collections.Generic;
using System.IO;

namespace fdvsClassLibrary.Models
{
    /// <summary>
    /// Contains the list with all requested.
    /// At this point in time, .csv is the only
    /// supported format for import.
    /// </summary>
    class ItemListModel
    {
        public List<string> ItemList { get; set; } = new List<string>();

        //TODO - Should refactor so that the constructor takes a
        //stringlist with the filenames, and create parsers for
        //csv, xml, and xlsx.

        /// <summary>
        /// The constructor currently accepts a filepath to a .csv, 
        /// which it then reads and parse to a list of string literals.
        /// </summary>
        /// <param name="filePath"></param>
        ItemListModel(string filePath)
        {
            using (var reader = new StreamReader(filePath))
            {
                while (!reader.EndOfStream)
                {
                    var line = reader.ReadLine();
                    ItemList.Add(line.Trim());
                }
            }
        }
    }
}
