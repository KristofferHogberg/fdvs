using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDeliveryManagementSystem
{
    class WaveFileIntegrityValidator
    {
        string[] WaveFilePaths { get; set; }
        int ExpectedBitDepth { get; set; }
        int ExpectedSampleRate { get; set; }

        List<string> ApprovedWaveFiles { get; set; }
        List<string> UnApprovedWaveFiles { get; set; }
        List<string> ErrorLogForUnApprovedWaveFiles { get; set; }

        WaveFileIntegrityValidator(string[] waveFilePaths, int expectedBitDepth, int expectedSampleRate)
        {
            WaveFilePaths = waveFilePaths;
            ExpectedBitDepth = expectedBitDepth;
            ExpectedSampleRate = expectedSampleRate;
        }

        public long CalculateExpectedFileSize(int bitDepth, int sampleRate, long durationInMillieSecs, int channels = 1)
        {
            return sampleRate * (bitDepth / 8) * (durationInMillieSecs * 1000 * channels);
        }
    }
}
