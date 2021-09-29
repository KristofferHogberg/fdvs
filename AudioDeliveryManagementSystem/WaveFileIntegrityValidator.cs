using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDeliveryManagementSystem
{
    class WaveFileIntegrityValidator
    {
        public BitDepth ExpectedBitDepth { get; private set; }
        public SampleRate ExpectedSampleRate { get; private set; }
        public List<WaveFile> WaveFiles { get; private set; }

        public WaveFileIntegrityValidator(List<string> waveFilePaths, int expectedBitDepth, int expectedSampleRate)
        {
            ExpectedBitDepth = (BitDepth)expectedBitDepth;
            ExpectedSampleRate = (SampleRate)expectedSampleRate;
            WaveFiles = new List<WaveFile>();
            foreach (var filePath in waveFilePaths)
            {
                try
                {
                    WaveFiles.Add(new WaveFile(filePath));
                }
                catch (NullReferenceException)
                {
                }
                
            }

            AssignExpectedFileSizesToWaveFiles();
            ValidateFiles();
        }



        private void AssignExpectedFileSizesToWaveFiles()
        {
            foreach (var waveFile in WaveFiles)
            {
                waveFile.ExpectedFileSizeInBytes = (long)CalcExpectedUncompressedWaveFileSize((int)ExpectedBitDepth, (int)ExpectedSampleRate, waveFile.DurationInMillieSecs);
            }
        }
        private void ValidateFiles()
        {
            foreach (var waveFile in WaveFiles)
            {

                waveFile.PassedValidation = CheckIfLengthAndExpectedLengthMatch(waveFile);
            }
        }
        //Enbart kompatibel med mono-filer.
        private long CalcExpectedUncompressedWaveFileSize(int bitDepth, int sampleRate, long durationInMillieSecs, int channels = 1)
        {
            return sampleRate * (bitDepth / 8) * (durationInMillieSecs / 1000) * channels;
        }
        private bool CheckIfLengthAndExpectedLengthMatch(WaveFile waveFile)
        {
            if (waveFile.FileSizeInBytes == waveFile.ExpectedFileSizeInBytes)
                return true;
            else
                return false;
        }
    }
}
