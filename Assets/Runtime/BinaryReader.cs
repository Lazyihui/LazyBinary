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

        public static int ReadrUshort(byte[] buffer, ref int index) {
            int value = 0;
            value = value | buffer[index] << 0;
            index++;

            value = value | (buffer[index] << 8);
            index++;

            return value;
        }
    }
}