using System.Runtime.InteropServices;

namespace NvApi
{
    public partial class NvApiWrapper
    {
        private const uint NVAPI_UNICODE_STRING_MAX = 2048;
        private const uint NVAPI_BINARY_DATA_MAX = 4100;

        private static uint MAKE_NVAPI_VERSION<T>(int version)
        {
            return (uint)(Marshal.SizeOf(typeof(T)) | version << 16);
        }
    }
}