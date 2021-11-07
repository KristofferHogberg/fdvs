using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace fdvs.Models
{
    /// <summary>
    /// Model containing information about all of the files which exist within a root directory and its subdirectories.
    /// Each files information is stored in a DeliveryFile object which is encapsulated by a list property
    /// named DeliveryFiles.
    /// </summary>
    public class DeliveryDirectoryModel
    {
        private string DirectoryPath { get; set; }
        private string DirectoryName { get; set; }
        public List<DeliveryFileModel> DeliveryFiles { get; private set; } = new List<DeliveryFileModel>();

        public DeliveryDirectoryModel(string rootDirectoryPath)
        {
            DirectoryPath = rootDirectoryPath;
            DirectoryName = new DirectoryInfo(rootDirectoryPath).Name;
            DeliveryFiles = GenerateDeliveryFilesObjects();
        }

        /// <summary>
        /// Imports a collection of FileInfo objects and then converts the FileInfo objects to DeliveryFile objects.
        /// </summary>
        /// <param name="allFilesInDeliveryFolder"></param>
        /// <returns>A list of DeliveryFile objects of all files in the root directory.</returns>
        private List<DeliveryFileModel> GenerateDeliveryFilesObjects()
        {
            var output = new List<DeliveryFileModel>();
            var fileInfoOfAllFilesInDirectory = GetFileInfoFromAllFilesInDirectoryTree(DirectoryPath);

            foreach (var file in fileInfoOfAllFilesInDirectory)
            {
                output.Add(new DeliveryFileModel(file, DirectoryName));
            }
            return output;
        }

        /// <summary>
        /// Imports a collection of FileInfo objects containing information of all files which exists within a specified root 
        /// directory.
        /// </summary>
        /// <param name="allFilesInDeliveryFolder"></param>
        /// <returns>A list of FileInfo objects of all files in the root directory.</returns>
        private List<FileInfo> GetFileInfoFromAllFilesInDirectoryTree(string directoryPath)
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

        /// <summary>
        /// Gets filenames of all files in the root directory and its subdirectories.
        /// </summary>
        /// <returns>A list of all filenames which exist within the root directory. Example: "textfile.txt"</returns>
        public List<string> GetAllFileNames()
        {
            return DeliveryFiles.Select(x => x.FileName).ToList();
        }

        /// <summary>
        /// Returns a list of the filepaths of each file which exist within the root directory. 
        /// </summary>
        /// <returns>Example: "rootfolder\subdirectory\textfile.txt"</returns>
        public List<string> GetAllFilePaths()
        {
            return DeliveryFiles.Select(x => x.FilePath).ToList();
        }
    }
}
