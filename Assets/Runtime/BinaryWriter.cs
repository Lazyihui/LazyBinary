using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace LazyBinary {

    public class BinaryWrite {
        public static void WriteCharBool1(byte[] buffer, int value, ref int index) {
            buffer[index] = (byte)(value >> 0);
            index++;
        }
        public static void WriteUshort2(byte[] buffer, int value, ref int index) {
            buffer[index] = (byte)(value >> 0);
            index++;
            buffer[index] = (byte)(value >> 8);
            index++;
        }

        public static void WriteInt(byte[] buffer, int value, ref int index) {
            buffer[index] = (byte)(value >> 0);
            index++;
            buffer[index] = (byte)(value >> 8);
            index++;
            buffer[index] = (byte)(value >> 16);
            index++;
            buffer[index] = (byte)(value >> 24);
            index++;
        }



        public static void Writelong8(byte[] buffer, int value, ref int index) {
            buffer[index] = (byte)(value >> 0);
            index++;
            buffer[index] = (byte)(value >> 8);
            index++;
            buffer[index] = (byte)(value >> 16);
            index++;
            buffer[index] = (byte)(value >> 32);
            index++;
            buffer[index] = (byte)(value >> 40);
            index++;
            buffer[index] = (byte)(value >> 48);
            index++;
            buffer[index] = (byte)(value >> 56);
            index++;
            buffer[index] = (byte)(value >> 64);
            index++;
        }

    }

}
