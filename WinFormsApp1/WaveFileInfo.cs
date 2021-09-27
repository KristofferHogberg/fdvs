using System;

namespace adms
{
    class WaveFileInfo
    {
        public string FileName;
        public int Bitrate;
        public int SampleRate;
        public int Size;
        public DateTime Duration;
          
        WaveFileInfo(string fileName, DateTime duration)
        {
            FileName = fileName;
            Duration = duration;
        }
    }
}
