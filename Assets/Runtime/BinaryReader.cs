namespace LazyBinary {

    public static class BinaryReader {




        public static sbyte ReadSbyte(byte[] buffer, ref int index) {
            sbyte value = 0;

            value = (sbyte)((int)value | (buffer[index] << 0));
            index++;

            return value;
        }
        public static byte ReadByte(byte[] buffer, ref int index) {
            byte value = 0;

            value = (byte)((int)value | (buffer[index] << 0));
            index++;

            return value;
        }

        public static ushort ReadUshort(byte[] buffer, ref int index) {

            ushort value = 0;

            value = (ushort)(value | (buffer[index] << 0));
            index++;

            value = (ushort)(value | (buffer[index] << 8));
            index++;

            return value;
        }
        public static short ReadShort(byte[] buffer, ref int index) {

            short value = 0;

            value = (short)((int)value | (buffer[index] << 0));
            index++;

            value = (short)((int)value | (buffer[index] << 8));
            index++;

            return value;
        }

        // public static bool ReadBool(byte[] buffer, ref int index) {
        //     bool value = (bool)(uint)0;
        //     value = (bool)(value | (buffer[index] << 0));
        //     return value;
        // }

        public static char ReadChar2(byte[] buffer, ref int index) {
            char value = (char)(uint)0;
            value = (char)((int)value | (buffer[index] << 0));
            index++;

            value = (char)((int)value | (buffer[index] << 8));
            index++;

            return value;
        }

        public static long ReadLong(byte[] buffer, ref int index) {

            long value = (long)(uint)0;
            value = (long)((int)value | (buffer[index] << 0));
            index++;
            value = (long)((int)value | (buffer[index] << 8));
            index++;
            value = (long)((int)value | (buffer[index] << 16));
            index++;
            value = (long)((int)value | (buffer[index] << 24));
            index++;
            value = (long)((int)value | (buffer[index] << 32));
            index++;
            value = (long)((int)value | (buffer[index] << 40));
            index++;
            value = (long)((int)value | (buffer[index] << 48));
            index++;
            value = (long)((int)value | (buffer[index] << 56));
            index++;
            return value;
        }
        public static ulong ReadUlong(byte[] buffer, ref int index) {

            ulong value = (ulong)0;
            value = (ulong)((int)value | (buffer[index] << 0));
            index++;
            value = (ulong)((int)value | (buffer[index] << 8));
            index++;
            value = (ulong)((int)value | (buffer[index] << 16));
            index++;
            value = (ulong)((int)value | (buffer[index] << 24));
            index++;
            value = (ulong)((int)value | (buffer[index] << 32));
            index++;
            value = (ulong)((int)value | (buffer[index] << 40));
            index++;
            value = (ulong)((int)value | (buffer[index] << 48));
            index++;
            value = (ulong)((int)value | (buffer[index] << 56));
            index++;
            return value;
        }
        public static int ReadInt(byte[] buffer, ref int index) {
            int value = 0;
            value = value | buffer[index] << 0;
            index++;
            value = value | (buffer[index] << 8);
            index++;
            value = value | (buffer[index] << 16);
            index++;
            value = value | (buffer[index] << 24);
            index++;

            return value;
        }
        public static uint ReadUint(byte[] buffer, ref int index) {
            uint value = 0;

            value = value | (uint)buffer[index] << 0;
            index++;
            value = value | (uint)(buffer[index] << 8);
            index++;
            value = value | (uint)(buffer[index] << 16);
            index++;
            value = value | (uint)(buffer[index] << 24);
            index++;

            return value;
        }

        public static bool ReadBool(byte[] buffer, ref int index) {
            if (buffer[index] == 1) {
                return true;
            } else {
                return false;
            }
        }
        //数组
        public static int[] ReadIntArr(byte[] buffer, ref int index) {

            ushort count = ReadUshort(buffer, ref index);
            int[] value = new int[count];
            for (int i = 0; i < count; i++) {
                int d = ReadInt(buffer, ref index);
                value[i] = d;
            }
            return value;
        }
        public static uint[] ReadUintArr(byte[] buffer, ref int index) {

            ushort count = ReadUshort(buffer, ref index);
            uint[] value = new uint[count];
            for (int i = 0; i < count; i++) {
                uint d = ReadUint(buffer, ref index);
                value[i] = d;
            }
            return value;
        }

        public static char[] ReadCharArr(byte[] buffer, ref int index) {
            ushort count = ReadUshort(buffer, ref index);

            char[] value = new char[count];
            for (int i = 0; i < count; i++) {
                char d = ReadChar2(buffer, ref index);
                value[i] = d;
            }
            return value;
        }

        public static bool[] readBoolArr(byte[] buffer, ref int index) {

            ushort count = ReadUshort(buffer, ref index);
            bool[] value = new bool[count];
            for (int i = 0; i < count; i++) {
                bool a = ReadBool(buffer, ref index);
                value[i] = a;
            }
            return value;
        }
        public static long[] ReadLongArr(byte[] buffer, ref int index) {
            ushort count = ReadUshort(buffer, ref index);

            long[] value = new long[count];
            for (int i = 0; i < count; i++) {
                long d = ReadLong(buffer, ref index);
                value[i] = d;
            }
            return value;
        }
        public static ulong[] ReadlUongArr(byte[] buffer, ref int index) {
            ushort count = ReadUshort(buffer, ref index);

            ulong[] value = new ulong[count];
            for (int i = 0; i < count; i++) {
                ulong d = ReadUlong(buffer, ref index);
                value[i] = d;
            }
            return value;
        }

        public static sbyte[] ReadSbyteArr(byte[] buffer, ref int index) {
            ushort count = ReadUshort(buffer, ref index);

            sbyte[] value = new sbyte[count];
            for (int i = 0; i < count; i++) {
                sbyte d = ReadSbyte(buffer, ref index);
                value[i] = d;
            }
            return value;
        }
        public static byte[] ReadByteArr(byte[] buffer, ref int index) {
            ushort count = ReadUshort(buffer, ref index);

            byte[] value = new byte[count];
            for (int i = 0; i < count; i++) {
                byte d = ReadByte(buffer, ref index);
                value[i] = d;
            }
            return value;
        }
        public static short[] ReadShortArr(byte[] buffer, ref int index) {
            ushort count = ReadUshort(buffer, ref index);

            short[] value = new short[count];
            for (int i = 0; i < count; i++) {
                short d = ReadShort(buffer, ref index);
                value[i] = d;
            }
            return value;
        }
        public static ushort[] ReadUshortArr(byte[] buffer, ref int index) {
            ushort count = ReadUshort(buffer, ref index);

            ushort[] value = new ushort[count];
            for (int i = 0; i < count; i++) {
                ushort d = ReadUshort(buffer, ref index);
                value[i] = d;
            }
            return value;
        }

        public static string ReadString(byte[] buffer, ref int index) {
            //读取字符串长度
            ushort count = ReadUshort(buffer, ref index);
            //读取字符串
            string value = System.Text.Encoding.UTF8.GetString(buffer, index, count);
            //因为没有用ref 所以要手动加+=
            index += count;
            return value;
        }




        //  public static int[] ReadInt32Arr(byte[] src, ref int offset) {
        //     ushort count = ReadUInt16(src, ref offset);
        //     int[] data = new int[count];
        //     for (int i = 0; i < count; i += 1) {
        //         int d = ReadInt32(src, ref offset);
        //         data[i] = d;
        //     }
        //     return data;
        // }
    }
}