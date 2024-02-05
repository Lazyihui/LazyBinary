namespace LazyBinary {

    public static class BinaryReader {




        public static sbyte ReadSbyte(byte[] buffer, ref int index) {
            sbyte value = 0;

            value = (sbyte)((int)value | (buffer[index] << 0));
            index++;
            value = (sbyte)((int)value | (buffer[index] << 8));
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