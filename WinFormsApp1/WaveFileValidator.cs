using NAudio.Wave;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace adms
{
    class WaveFileValidator
    {
        AcceptedFileTypes ExpecteFileType { get; set; }
        List<WaveFileInfo> ListWithAudioFiles { get; set; }
        List<string> ValidationLog { get; set; }

        WaveFileValidator(AcceptedFileTypes expectedFileType, List<WaveFileInfo> listOfAudioFiles)
        {
            ExpecteFileType = expectedFileType;
            ListWithAudioFiles = listOfAudioFiles;
            ValidationLogs(ListWithAudioFiles, ExpecteFileType);
        }

        //This method should in a future implementation return a 
        //List<WaveFileInfo>, with updated Error logs as properties
        List<string> ValidationLogs(List<WaveFileInfo> listOfAudioFiles, AcceptedFileTypes ExpecteFileType)
        {
            var fileLogs = new List<string>();

            foreach (var waveFileInfo in listOfAudioFiles)
            {
                if (CheckBitrate(waveFileInfo) && CheckSampleRate(waveFileInfo) && CheckExpectedFileSize(waveFileInfo))
                    fileLogs.Add($"File {waveFileInfo.FileName} passed all tests.");
                else
                    fileLogs.Add($"Error. File {waveFileInfo.FileName} failed the tests.");
            }

            return fileLogs;
        }

        bool CheckBitrate(WaveFileInfo waveFileInfo)
        {
            string filename = waveFileInfo.FileName;
            using var reader = new WaveFileReader(filename);
            double bitrate = reader.WaveFormat.AverageBytesPerSecond * 8;
            Console.WriteLine("CheckBitrate shows a ");
        }
        bool CheckSampleRate(WaveFileInfo file)
        {
            throw new NotImplementedException();
        }
        bool CheckExpectedFileSize(WaveFileInfo file)
        {
            throw new NotImplementedException();
        }
    }
}
