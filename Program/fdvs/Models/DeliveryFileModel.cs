using System.IO;

namespace fdvs.Models
{
    /// <summary>
    /// Model containing the essential information of a delivery file.
    /// </summary>
    public class DeliveryFileModel
    {
        public string FileName { get; }
        public string FilePath { get; }
        public long FileSize { get; }
        public bool InDeliverables { get; set; }
        /// <summary>
        /// Constructor for the DeliveryFile object.
        /// </summary>
        /// <param name="fileInfo">A file info object of the file.</param>
        /// <param name="nameOfRootDirectory">Name of the root directory.</param>
        public DeliveryFileModel(FileInfo fileInfo, string nameOfRootDirectory)
        {
            FileName = fileInfo.Name;
            FilePath = GetFilePath(fileInfo, nameOfRootDirectory);
            FileSize = fileInfo.Length;
        }

        /// <summary>
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <param name="nameOfRootDirectory"></param>
        /// <returns>The filepath of the file, up to a specified root folder.</returns>
        private string GetFilePath(
            FileInfo fileInfo, string nameOfRootDirectory)
        {
            
            return fileInfo.FullName.Substring(
                fileInfo.FullName.IndexOf(nameOfRootDirectory));
        }

    }
}
