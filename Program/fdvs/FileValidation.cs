using System;
using System.Collections.Generic;
using System.Linq;

namespace fdvs
{
    /// <summary>
    /// Contains methods for validating and comparing files.
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

        private void UpdateIfFilesInDeliveryFolderIsInDeliverables(
            List<string> deliverables, List<DeliveryFile> deliveryFiles)
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
