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
        public List<FileInfo> AllFilesInDeliveryFolder { get; } = new List<FileInfo>();
        public List<string> AllFileNamesInDirectory { get; set; } = new List<string>();
        public List<string> AllFilePathsInDirectory { get; set; } = new List<string>();

        public DeliveryDirectoryModel(string directoryPath)
        {
            DirectoryPath = directoryPath;
            DirectoryName = new DirectoryInfo(directoryPath).Name;
            AllFilesInDeliveryFolder = GetAllFileInfoFromDirectoryTree(DirectoryPath);
            AllFileNamesInDirectory = GetAllFileNamesInDeliveryFolder(AllFilesInDeliveryFolder);
            AllFilePathsInDirectory = GetAllFilePathsInDeliveryFolder(
                AllFilesInDeliveryFolder, DirectoryName);
        }

        private List<FileInfo> GetAllFileInfoFromDirectoryTree(string directoryPath)
        {
            var filePaths = Directory.GetFiles(directoryPath, "*.*", SearchOption.AllDirectories).ToList();

            var output = new List<FileInfo>();
            foreach (var path in filePaths)
            {
                output.Add(new FileInfo(path));
            }
            return output;
        }

        public List<string> GetAllFileNamesInDeliveryFolder(
            List<FileInfo> allFilesInDeliveryFolder)
        {
            var output = new List<string>();
            foreach (var file in allFilesInDeliveryFolder)
            {
                output.Add(file.Name);
            }
            return output;
        }

        public List<string> GetAllFilePathsInDeliveryFolder(
            List<FileInfo> allFilesInDeliveryFolder, string directoryName)
        {
            var output = new List<string>();
            foreach (var file in allFilesInDeliveryFolder)
            {
                output.Add(file.FullName.Substring(
                    file.FullName.IndexOf(directoryName)));
            }
            return output;
        }

    }
}
