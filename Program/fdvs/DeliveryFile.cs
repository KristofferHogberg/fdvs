using System.IO;

namespace fdvs
{
    /// <summary>
    /// Class which contains only the essential information necessary of the delivery file.
    /// </summary>
    public class DeliveryFile
    {
        public string FileName { get; }
        public string FilePath { get; }
        public long FileSize { get; }
        public bool InDeliverables { get; set; }
        /// <summary>
        /// Constructor.
        /// </summary>
        /// <param name="fileInfo"></param>
        /// <param name="deliveryDirectoryName"></param>
        public DeliveryFile(FileInfo fileInfo, string deliveryDirectoryName)
        {
            FileName = fileInfo.Name;
            FilePath = GetFilePath(fileInfo, deliveryDirectoryName);
            FileSize = fileInfo.Length;
        }

        private string GetFilePath(
            FileInfo fileInfo, string deliveryDirectoryName)
        {
            
            return fileInfo.FullName.Substring(
                fileInfo.FullName.IndexOf(deliveryDirectoryName));
        }
    }
}
