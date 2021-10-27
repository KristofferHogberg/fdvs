using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fdvs
{
    public class DeliveryFile
    {
        public string FileName { get; }
        public string FilePath { get; }
        public long FileSize { get; }
        public bool InDeliverables { get; set; }
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
