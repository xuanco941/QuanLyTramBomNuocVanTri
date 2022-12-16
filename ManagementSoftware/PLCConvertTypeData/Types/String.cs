using System;
using System.Collections.Generic;
using System.Text;

namespace ManagementSoftware.PLCConvertTypeData.Types
{
    public static class String
    {
        // publics
        #region ToByteArray
        public static byte[] ToByteArray(string value)
        {
            string txt = value;
            char[] ca = txt.ToCharArray();
            byte[] bytes = new byte[txt.Length];
            for (int cnt = 0; cnt <= ca.Length - 1; cnt++)
                bytes[cnt] = (byte)Asc(ca[cnt].ToString());
            return bytes;
        }
        #endregion

        #region FromByteArray
        public static string FromByteArray(byte[] bytes)
        {
            return Encoding.ASCII.GetString(bytes);
        }
        #endregion

        // privates
        private static int Asc(string s)
        {
            byte[] b = Encoding.ASCII.GetBytes(s);
            if (b.Length > 0)
                return b[0];
            return 0;
        }
    }
}
