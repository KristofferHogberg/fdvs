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
        public List<FileInfo> AllFilesInDeliveryFolder { get; } = new List<FileInfo>();

        public DeliveryDirectoryModel(string directoryPath)
        {
            DirectoryPath = directoryPath;
            AllFilesInDeliveryFolder = GetAllFileInfoFromDirectoryTree(DirectoryPath);
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
    }
}
