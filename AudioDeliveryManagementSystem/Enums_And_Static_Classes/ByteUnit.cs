using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioDeliveryManagementSystem
{
    static class FileUnit
    {
        public static decimal ToKiloByte(decimal bytes)
        {
            return bytes / 1000;
        }
        public static decimal ToMegaByte(decimal bytes)
        {
            return bytes / 1000000;
        }

        public static decimal ToGigaByte(decimal bytes)
        {
            return bytes / 1000000000;
        }
    }
}
