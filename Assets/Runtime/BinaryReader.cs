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
    }
}