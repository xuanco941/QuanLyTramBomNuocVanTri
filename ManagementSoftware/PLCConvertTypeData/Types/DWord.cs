using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementSoftware.PLCConvertTypeData.Types
{
    public static class DWord
    {
        // publics
        #region FromByteArray
        public static uint FromByteArray(byte[] bytes)
        {
            return FromBytes(bytes[3], bytes[2], bytes[1], bytes[0]);
        }
        #endregion
        #region FromBytes
        public static uint FromBytes(byte v1, byte v2, byte v3, byte v4)
        {
            return (uint)(v1 + v2 * Math.Pow(2, 8) + v3 * Math.Pow(2, 16) + v4 * Math.Pow(2, 24));
        }
        #endregion

        #region ToByteArray
        public static byte[] ToByteArray(uint value)
        {
            byte[] bytes = new byte[4];
            int x = 4;
            long valLong = value;
            for (int cnt = 0; cnt < x; cnt++)
            {
                long x1 = (long)Math.Pow(256, cnt);

                long x3 = valLong / x1;
                bytes[x - cnt - 1] = (byte)(x3 & 255);
                valLong -= bytes[x - cnt - 1] * x1;
            }
            return bytes;
        }

        public static byte[] ToByteArray(uint[] value)
        {
            ByteArray arr = new ByteArray();
            foreach (uint val in value)
                arr.Add(ToByteArray(val));
            return arr.array;
        }
        #endregion
        #region ToArray
        public static uint[] ToArray(byte[] bytes)
        {
            uint[] values = new uint[bytes.Length / 4];

            int counter = 0;
            for (int cnt = 0; cnt < bytes.Length / 4; cnt++)
                values[cnt] = FromByteArray(new byte[] { bytes[counter++], bytes[counter++], bytes[counter++], bytes[counter++] });

            return values;
        }
        #endregion
    }
}
