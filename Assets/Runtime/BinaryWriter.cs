using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace LazyBinary {

    public class BinaryWrite {

        public static void WriteInt(byte[] buffer, int value,ref int index) {
            buffer[index] = (byte)(value >> 0);
            index++;
            buffer[index] = (byte)(value >> 8);
            index++;
            buffer[index] = (byte)(value >> 16);
            index++;
            buffer[index] = (byte)(value >> 24);
            index++;
        }
    }

}
