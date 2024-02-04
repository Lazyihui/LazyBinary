using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace LazyBinary {

    public class BinaryWrite {

        public static void WriteBool1(byte[] buffer, sbyte value, ref int index) {

            buffer[index] = (byte)(value >> 0);
            index++;

        }
        public static void WriteSbyte1(byte[] buffer, sbyte value, ref int index) {

            buffer[index] = (byte)(value >> 0);
            index++;

        }
        public static void WriteChar2(byte[] buffer, char value, ref int index) {
            buffer[index] = (byte)(value >> 0);
            index++;

            buffer[index] = (byte)(value >> 8);
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



        public static void Writelong8(byte[] buffer, long value, ref int index) {


            buffer[index] = (byte)(value >> 0);
            // Debug.Log(buffer[index]);
            index++;

            buffer[index] = (byte)(value >> 8);
            // Debug.Log(buffer[index]);
            index++;

            buffer[index] = (byte)(value >> 16);
            // Debug.Log(buffer[index]);
            index++;

            buffer[index] = (byte)(value >> 24);
            // Debug.Log(buffer[index]);
            index++;

            buffer[index] = (byte)(value >> 32);
            // Debug.Log(buffer[index]);
            index++;

            buffer[index] = (byte)(value >> 40);
            // Debug.Log(buffer[index]);
            index++;

            buffer[index] = (byte)(value >> 48);
            // Debug.Log(buffer[index]);
            index++;

            buffer[index] = (byte)(value >> 56);
            // Debug.Log(buffer[index]);
            index++;

        }

    }

}
