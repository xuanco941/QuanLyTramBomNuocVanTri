using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementSoftware.PLCConvertTypeData.Types
{
    public static class Int
    {
        // publics
        #region FromByteArray
        public static short FromByteArray(byte[] bytes)
        {
            // bytes[0] -> HighByte
            // bytes[1] -> LowByte
            return FromBytes(bytes[1], bytes[0]);
        }
        #endregion
        #region FromBytes
        public static short FromBytes(byte LoVal, byte HiVal)
        {
            return (short)(HiVal * 256 + LoVal);
        }
        #endregion

        #region ToByteArray
        public static byte[] ToByteArray(short value)
        {
            byte[] bytes = new byte[2];
            int x = 2;
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

        public static byte[] ToByteArray(short[] value)
        {
            ByteArray arr = new ByteArray();
            foreach (short val in value)
                arr.Add(ToByteArray(val));
            return arr.array;
        }
        #endregion
        #region ToArray
        public static short[] ToArray(byte[] bytes)
        {
            short[] values = new short[bytes.Length / 2];

            int counter = 0;
            for (int cnt = 0; cnt < bytes.Length / 2; cnt++)
                values[cnt] = FromByteArray(new byte[] { bytes[counter++], bytes[counter++] });

            return values;
        }
        #endregion

        // conversion
        public static short CWord(int value)
        {
            if (value > 32767)
            {
                value -= 32768;
                value = 32768 - value;
                value *= -1;
            }
            return (short)value;
        }

    }
}
