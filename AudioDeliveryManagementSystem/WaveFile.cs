using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NAudio.Wave;

namespace AudioDeliveryManagementSystem
{
    class WaveFile
    {
        public WaveFileStatus Status { get; set; }
        public string FilePath { get; set; }
        public string FileName { get; set; }
        public decimal FileSizeInBytes { get; set; }
        public decimal ExpectedFileSizeInBytes { get; set; }
        public decimal DurationInMillieSecs { get; set; }
        public bool PassedValidation { get; set; }
        public WaveFile(string filePath)
        {
            Status = WaveFileStatus.Unchecked;
            System.IO.FileInfo file = new System.IO.FileInfo(filePath);
            FilePath = filePath;
            FileName = file.Name;
            FileSizeInBytes = file.Length;
            WaveFileReader reader = new WaveFileReader(filePath);
            TimeSpan duration = reader.TotalTime;
            DurationInMillieSecs = duration.Milliseconds;
        }


    }
}
