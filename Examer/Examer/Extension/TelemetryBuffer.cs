namespace Examer.Extension
{
    public static class TelemetryBuffer
    {
        public static byte[] ToBuffer(long reading)
        {
            byte[] buffer = new byte[9];
            byte[] valueBytes = [];

            // 正數部分
            if (reading >= 0 && reading <= 65_535)  // ushort
            {
                buffer[0] = 2;
                valueBytes = BitConverter.GetBytes((ushort)reading);
            }
            else if (reading >= 65_536 && reading <= 2_147_483_647)  // int
            {
                buffer[0] = 252;
                valueBytes = BitConverter.GetBytes((int)reading);
            }
            else if (reading >= 2_147_483_648 && reading <= 4_294_967_295)  // uint
            {
                buffer[0] = 4;
                valueBytes = BitConverter.GetBytes((uint)reading);
            }
            else if (reading >= 4_294_967_296)  // long (大正數)
            {
                buffer[0] = 248;
                valueBytes = BitConverter.GetBytes(reading);
            }
            // 負數部分
            else if (reading >= -32_768 && reading <= -1)  // short
            {
                buffer[0] = 254;
                valueBytes = BitConverter.GetBytes((short)reading);
            }
            else if (reading >= -2_147_483_648 && reading <= -32_769)  // int
            {
                buffer[0] = 252;
                valueBytes = BitConverter.GetBytes((int)reading);
            }
            else if (reading < -2_147_483_648)  // long (大負數)
            {
                buffer[0] = 248;
                valueBytes = BitConverter.GetBytes(reading);
            }

            Array.Copy(valueBytes, 0, buffer, 1, valueBytes.Length);

            return buffer;
        }

        public static long FromBuffer(byte[] buffer)
        {
            byte typeMarker = buffer[0];

            return typeMarker switch
            {
                2 => BitConverter.ToUInt16(buffer, 1),
                4 => BitConverter.ToUInt32(buffer, 1),
                22 => 0L,
                248 => BitConverter.ToInt64(buffer, 1),
                252 => BitConverter.ToInt32(buffer, 1),
                254 => BitConverter.ToInt16(buffer, 1),
                _ => throw new ArgumentException("Invalid type marker in buffer"),
            };
        }
    }
}
