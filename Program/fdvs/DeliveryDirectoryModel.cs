using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace fdvs
{
    /// <summary>
    /// Contains information about all files in the directory tree.
    /// </summary>
    public class DeliveryDirectoryModel
    {
        public string DirectoryPath { get; set; }
        public string DirectoryName { get; set; }
        private List<FileInfo> AllFilesInDeliveryFolder { get; } = new List<FileInfo>();
        public List<DeliveryFile> DeliveryFiles { get; set; } = new List<DeliveryFile>();

        public DeliveryDirectoryModel(string directoryPath)
        {
            DirectoryPath = directoryPath;
            DirectoryName = new DirectoryInfo(directoryPath).Name;
            AllFilesInDeliveryFolder = GetAllFileInfoFromDirectoryTree(DirectoryPath);
            DeliveryFiles = GenerateDeliveryFilesObjects(AllFilesInDeliveryFolder);
        }

        private List<DeliveryFile> GenerateDeliveryFilesObjects(
            List<FileInfo> allFilesInDeliveryFolder)
        {
            var output = new List<DeliveryFile>();

            foreach (var file in allFilesInDeliveryFolder)
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
