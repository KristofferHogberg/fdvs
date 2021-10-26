using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdvs
{
    /// <summary>
    /// Contains methods for validating and comparing files.
    /// </summary>
    public class FileValidation
    {
        public DeliverablesListModel Deliverables { get; set; }
        public DeliveryDirectoryModel DeliveryDirectory { get; set; }

        public FileValidation(string filePathToCsv, 
            string filePathToDeliveryDirectory)
        {
            Deliverables = new DeliverablesListModel(filePathToCsv);
            DeliveryDirectory = new DeliveryDirectoryModel(filePathToDeliveryDirectory);
        }

        public List<string> GetAllFileNamesInDeliveryFolder(
            DeliveryDirectoryModel deliveryDirectory)
        {
            var output = new List<string>();
            foreach (var file in deliveryDirectory.AllFilesInDeliveryFolder)
            {
                output.Add(file.Name);
            }
            return output;
        }
        public List<string> GetAllFilePathsInDeliveryFolder(
            DeliveryDirectoryModel deliveryDirectory)
        {
            //TODO - Fix so that the filepaths stop at the main folder,
            //so that C: is not incl.
            var output = new List<string>();
            foreach (var file in deliveryDirectory.AllFilesInDeliveryFolder)
            {
                output.Add(file.FullName);
            }
            return output;
        }
        public List<string> GetAllMissingFileNames(List<string> deliverables, 
            DeliveryDirectoryModel deliveryDirectory)
        {
            var output = new List<string>();

            foreach (var filename in deliverables)
            {
                if (!GetAllFileNamesInDeliveryFolder(deliveryDirectory).Contains(filename))
                {
                    output.Add(filename);
                }
            }
            return output;
        }
        public List<string> GetAllExtraFileNamesNotIncludedInDelivery(
            List<string> deliverables, DeliveryDirectoryModel deliveryDirectory)
        {
            //TODO - Kan nog bygga in att den ska visa filepath
            //här i också, genom fileInfo.FullName
            //Nog smartare att inte omvandla till string utan behålla
            //fileinfo.
            var allFilesInDeliveryDirectory = new List<string>();
            foreach (var fileInfo in deliveryDirectory.AllFilesInDeliveryFolder)
            {
                allFilesInDeliveryDirectory.Add(fileInfo.Name);
            }

            var filesNotInDeliverables = new List<string>();
            foreach (var filename in allFilesInDeliveryDirectory)
            {
                if (!deliverables.Contains(filename))
                {
                    filesNotInDeliverables.Add(filename);
                }
            }

            return filesNotInDeliverables;
        }
    }
}
