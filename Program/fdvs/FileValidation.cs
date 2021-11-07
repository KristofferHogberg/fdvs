using fdvs.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace fdvs
{
    /// <summary>
    /// The main entry for the program logic and filehandling.
    /// Encapsulates information regarding files that exist within a root folder Contains methods for validating and comparing files.
    /// </summary>
    public class FileValidation
    {
        public DeliverablesListModel Deliverables { get; set; }
        public DeliveryDirectoryModel DeliveryDirectory { get; set; }
        public List<string> AllExtraFileNamesInDirectory { get; set; } = new List<string>();
        public List<string> AllMissingFileNames { get; set; } = new List<string>();

        public FileValidation(string filePathToCsv, 
            string filePathToDeliveryDirectory)
        {
            Deliverables = new DeliverablesListModel(filePathToCsv);
            DeliveryDirectory = new DeliveryDirectoryModel(filePathToDeliveryDirectory);
            UpdateIfFilesInDeliveryFolderIsInDeliverables(
                Deliverables.FileNameList, DeliveryDirectory.DeliveryFiles);
        }

        public List<string> GetAllMissingFileNames()
        {
            var filesInDeliveryDirectories = DeliveryDirectory.DeliveryFiles.Select(x => x.FileName).ToList();
            var missingFiles = Deliverables.FileNameList.Where(x => !filesInDeliveryDirectories.Contains(x)).Select(x => x).ToList();
            return missingFiles;
        }

        /// <summary>
        /// Returns a list of the filepaths of each file which exist within the root directory that are . 
        /// </summary>
        /// <returns>Example: "rootfolder\subfolder\textfile.txt"</returns>
        public List<string> GetAllFilesNotInDeliverables()
        {
            return DeliveryDirectory.DeliveryFiles.Where(x => x.InDeliverables == false).Select(x => x.FileName).ToList();
        }

        private void UpdateIfFilesInDeliveryFolderIsInDeliverables(
            List<string> deliverables, List<DeliveryFileModel> deliveryFiles)
        {
            foreach (var file in deliveryFiles)
            {
                if (deliverables.Contains(file.FileName))
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
