using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace fdvs
{
    /// <summary>
    /// Instantiates a new collection of all files in the delivery directory tree.
    /// </summary>
    public class DeliveryDirectoryModel
    {
        private string DirectoryPath { get; set; }
        private string DirectoryName { get; set; }
        public List<DeliveryFile> DeliveryFiles { get; set; } = new List<DeliveryFile>();

        public DeliveryDirectoryModel(string directoryPath)
        {
            DirectoryPath = directoryPath;
            DirectoryName = new DirectoryInfo(directoryPath).Name;
            DeliveryFiles = GenerateDeliveryFilesObjects();
        }

        /// <summary>
        /// Returns a list of DeliveryFile objects of all files in the delivery directory.
        /// </summary>
        /// <param name="allFilesInDeliveryFolder"></param>
        /// <returns></returns>
        private List<DeliveryFile> GenerateDeliveryFilesObjects()
        {
            var output = new List<DeliveryFile>();
            var fileInfoOfAllFilesInDirectory = GetAllFileInfoFromDirectoryTree(DirectoryPath);

            foreach (var file in fileInfoOfAllFilesInDirectory)
            {
                output.Add(new DeliveryFile(file, DirectoryName));
            }
            return output;
        }

        private List<FileInfo> GetAllFileInfoFromDirectoryTree(string directoryPath)
        {
            var filePaths = Directory.GetFiles(
                directoryPath, "*.*", SearchOption.AllDirectories).ToList();

            var output = new List<FileInfo>();
            foreach (var path in filePaths)
            {
                output.Add(new FileInfo(path));
            }
            return output;
        }

        public List<string> GetAllFileNames()
        {
            return DeliveryFiles.Select(x => x.FileName).ToList();
        }

        public List<string> GetAllFilePaths()
        {
            return DeliveryFiles.Select(x => x.FilePath).ToList();
        }

        public List<string> GetAllFilesNotInDeliverables()
        {
            return DeliveryFiles.Where(x => x.InDeliverables == false).Select(x=>x.FileName).ToList();
        }

        public List<long> GetAllFileSizes()
        {
            return DeliveryFiles.Select(x => x.FileSize).ToList();
        }
    }
}
