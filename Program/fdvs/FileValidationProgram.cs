using fdvs.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace fdvs
{
    /// <summary>
    /// The main entry for the program logic and filehandling.
    /// Encapsulates information regarding files which exist within a root folder. 
    /// Contains methods for and comparing files, exporting of files and other.
    /// </summary>
    public class FileValidationProgram
    {
        public DeliverablesListModel Deliverables { get; set; }
        public DeliveryDirectoryModel DeliveryDirectory { get; set; }

        //TODO - tests för att kolla om Deliverables är null.

        /// <summary>
        /// Constructor for when there is no itemized .csv file of the deliverables which are to 
        /// be included with the delivery.
        /// </summary>
        /// <param name="filePathToCsv"></param>
        /// <param name="filePathToDeliveryDirectory"></param>
        public FileValidationProgram(string filePathToDeliveryDirectory)
        {
            DeliveryDirectory = new DeliveryDirectoryModel(filePathToDeliveryDirectory);
            UpdateIfFilesInDeliveryFolderIsInDeliverables(
                Deliverables.FileNameList, DeliveryDirectory.DeliveryFiles);
        }

        /// <summary>
        /// Constructor for when a csv-file exists of the deliverables for a delivery.
        /// </summary>
        /// <param name="filePathToDeliverablesCsvFile"></param>
        /// <param name="filePathToDeliveryDirectory"></param>
        public FileValidationProgram(string filePathToDeliverablesCsvFile, string filePathToDeliveryDirectory)
        {
            Deliverables = new DeliverablesListModel(filePathToDeliverablesCsvFile);
            DeliveryDirectory = new DeliveryDirectoryModel(filePathToDeliveryDirectory);
            UpdateIfFilesInDeliveryFolderIsInDeliverables(
                Deliverables.FileNameList, DeliveryDirectory.DeliveryFiles);
        }

        /// <summary>
        /// Gets a list of strings of all filenames which are listed to be part of the delivery
        /// (deliverables), yet are not found in the directory containing the delivery files.
        /// </summary>
        /// <returns>A list of filenames as string literals.</returns>
        public List<string> GetAllMissingFileNames()
        {
            var filesInDeliveryDirectories = DeliveryDirectory.DeliveryFiles
                .Select(x => x.FileName)
                .ToList();
            var missingFiles = Deliverables.FileNameList
                .Where(x => !filesInDeliveryDirectories.Contains(x))
                .Select(x => x)
                .ToList();
            return missingFiles;
        }

        /// <summary>
        /// Gets a list of the filepaths of each file which exist within the root directory that 
        /// are not mentioned in any deliverables documentation. 
        /// </summary>
        /// <returns>A list of string literals in the following example format: 
        /// "rootfolder\subfolder\textfile.txt"</returns>
        public List<string> GetAllUnexpectedFiles()
        {
            return DeliveryDirectory.DeliveryFiles
                .Where(x => x.InDeliverables == false)
                .Select(x => x.FileName)
                .ToList();
        }

        /// <summary>
        /// Goes through each DeliveryFileModel in a collection and checks whether or not 
        /// the filename is present in the collection of deliverables.
        /// </summary>
        /// <param name="filenamesThatAreToBeDelivered"></param>
        /// <param name="deliveryFiles"></param>
        private void UpdateIfFilesInDeliveryFolderIsInDeliverables(
            List<string> filenamesThatAreToBeDelivered, List<DeliveryFileModel> deliveryFiles)
        {
            foreach (var file in deliveryFiles)
            {
                if (filenamesThatAreToBeDelivered.Contains(file.FileName))
                {
                    file.InDeliverables = true;
                }
                else
                {
                    file.InDeliverables = false;
                }
            }
        }
    }
}
