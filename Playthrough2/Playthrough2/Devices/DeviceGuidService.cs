using System;

namespace Playthrough2.Devices
{
    public static class DeviceGuidService
    {
        public static Guid CreateGuid(WaveApi api, int index) =>
            new Guid(0, 0, 0, 0, 0, 0, 0, 0, (byte) api, (byte) (index >> 8), (byte) (index & 0xFF));
    }
}