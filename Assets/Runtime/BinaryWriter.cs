using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace LazyBinary {

    public class BinaryWrite {

        public static void WriteBool1(byte[] buffer, bool value, ref int index) {
            if (value) {
                buffer[index] = (byte)(1);

            } else {
                buffer[index] = (byte)(0);

            }
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
        public static void WriteShort2(byte[] buffer, short value, ref int index) {
            buffer[index] = (byte)(value >> 0);
            index++;
            buffer[index] = (byte)(value >> 8);
            index++;
        }



        public static void WriteFloat(byte[] buffer, float value, ref int index) {


        }
        public static void Writelong8(byte[] buffer, long value, ref int index) {


            buffer[index] = (byte)(value >> 0);
            index++;

            buffer[index] = (byte)(value >> 8);
            index++;

            buffer[index] = (byte)(value >> 16);
            index++;

            buffer[index] = (byte)(value >> 24);
            index++;

            buffer[index] = (byte)(value >> 32);
            index++;

            buffer[index] = (byte)(value >> 40);
            index++;

            buffer[index] = (byte)(value >> 48);
            index++;

            buffer[index] = (byte)(value >> 56);
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
        //数组
        public static void WriteInt4Arr(byte[] buffer, int[] value, ref int index) {
            if (value != null) {
                ushort count = (ushort)value.Length;
                WriteUshort2(buffer, count, ref index);
                for (int i = 0; i < count; i++) {
                    WriteInt(buffer, value[i], ref index);
                }
            } else {
                WriteUshort2(buffer, 0, ref index);
            }
        }


        public static void WriteChar2Arr(byte[] buffer, char[] value, ref int index) {
            if (value != null) {
                ushort count = (ushort)value.Length;
                WriteUshort2(buffer, count, ref index);
                for (int i = 0; i < count; i++) {
                    WriteChar2(buffer, value[i], ref index);
                }
            } else {
                WriteChar2(buffer, (char)(uint)48, ref index);
            }
        }

        public static void WriteBoolArr(byte[] buffer, bool[] value, ref int index) {
            if (value != null) {
                ushort count = (ushort)value.Length;
                WriteUshort2(buffer, count, ref index);
                for (int i = 0; i < count; i++) {
                    WriteBool1(buffer, value[i], ref index);
                }
            } else {
                WriteBool1(buffer, false, ref index);
            }
        }
    }

}
