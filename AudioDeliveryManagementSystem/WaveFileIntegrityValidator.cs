using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDeliveryManagementSystem
{
    class WaveFileIntegrityValidator
    {
        int ExpectedBitDepth { get; set; }
        int ExpectedSampleRate { get; set; }

        List<string> UncheckedWaveFiles { get; set; }
        List<string> ApprovedWaveFiles { get; set; }
        List<string> UnApprovedWaveFiles { get; set; }
        List<string> ErrorLogForUnapprovedWaveFiles { get; set; }

        WaveFileIntegrityValidator(List<string> waveFilePaths, int expectedBitDepth, int expectedSampleRate)
        {
            UncheckedWaveFiles = waveFilePaths;
            ExpectedBitDepth = expectedBitDepth;
            ExpectedSampleRate = expectedSampleRate;
        }

        public decimal CalculateExpectedFileSize(int bitDepth, int sampleRate, decimal durationInMillieSecs, int channels = 1)
        {
            return sampleRate * (bitDepth / 8) * (durationInMillieSecs / 1000) * channels;
        }

        public void ValidateWaveFileLength()
        {

        }
    }
}
