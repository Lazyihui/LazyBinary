namespace LazyBinary {

    public static class BinaryReader {


        public static int ReadrInt(byte[] buffer, ref int index) {
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

        public static ushort ReadUshort(byte[] buffer, ref int index) {

            ushort value = 0;

            value = (ushort)(value | (buffer[index] << 0));
            index++;

            value = (ushort)(value | (buffer[index] << 8));
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

            value = (long)((int)value | (buffer[index] << 64));
            index++;


            return value;


        }
    }
}