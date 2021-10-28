using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace fdvs
{
    public static class XmlFormatter
    {
        public static XElement DeliveryFileToXElement(DeliveryFile file)
        {
            var fileRoot = new XElement("File");

            fileRoot.Add(new XText("\n"),
                    new XElement("file_Name", file.FileName),
                    new XText("\n"),
                    new XElement("file_Path", file.FilePath),
                    new XText("\n"));

            return fileRoot;
        }

        public static XElement FileNameToXElement(string fileName)
        {
            var fileRoot = new XElement("File");

            fileRoot.Add(new XText("\n"),
                new XElement("file_name", fileName),
                new XText("\n"));

            return fileRoot;
        }
    }
}
