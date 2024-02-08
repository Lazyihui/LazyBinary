using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.InteropServices;


namespace LazyBinary.Sample {

    [StructLayout(LayoutKind.Explicit)]
    public struct Bit32 {
        // 二进制重叠
        [FieldOffset(0)] public float f; // 4byte
        [FieldOffset(0)] public uint uf; // 4byte
    }

    public class RoleEntity {


        public bool[] bool1;
        public sbyte q;


        public void Save() {
            byte[] buffer = new byte[1024];

            int index = 2;

            BinaryWrite.WriteBoolArr(buffer, bool1, ref index);//4
            BinaryWrite.WriteSbyte1(buffer, q, ref index);




            index = 0;
            BinaryWrite.WriteUshort2(buffer, (ushort)(index - 2), ref index);



            File.WriteAllBytes(System.Environment.CurrentDirectory + "/role.sav", buffer);

            for (int i = 0; i < index + 10; i++) {
                Debug.Log(buffer[i]);
            }

        }

        public void Load() {
            byte[] buffer = File.ReadAllBytes(System.Environment.CurrentDirectory + "/role.sav");

            int index = 0;
            ushort length = BinaryReader.ReadUshort(buffer, ref index);
            bool1 = BinaryReader.readBoolArr(buffer, ref index);
            q = BinaryReader.ReadSbyte(buffer, ref index);


            for (int i = 0; i < index + 10; i++) {
                Debug.Log(buffer[i]);
            }

        }
        public void Log() {
        }
    }



    public class Sample_BinaryWriter : MonoBehaviour {

        void Awak() {
            RoleEntity role = new RoleEntity();
            role.Load();
            role.Log();


            byte[] buffer = new byte[1024];
            int offset = 0;

            Bit32 b32 = new Bit32();
            float f = 1.1f;
            b32.f = f;

            BinaryWrite.WriteUint(buffer, b32.uf, ref offset);

            // Read
            offset = 0;
            uint fr = BinaryReader.ReadUint(buffer, ref offset);
            Bit32 r32 = new Bit32();
            r32.uf = fr;
            Debug.Log($"f: {f}, f2: {r32.f}");

            Debug.Log($"Hello \0 World  \" ");
            // role.bool1 = new bool[2];
            // for (int i = 0; i < 2; i++) {
            //     role.bool1[i] = true;
            // }
            // role.q = 10;


            // role.Save();
            // role.Log();
        }

        void Write() {
            byte[] buffer = new byte[1024];


            ushort Length = 0;


            int index = 2;
            int a = 2146994236;

            BinaryWrite.WriteInt(buffer, a, ref index);
            Length = (ushort)(index - 2);//6 indsex
            index = 0;
            BinaryWrite.WriteUshort2(buffer, Length, ref index);
            for (int i = 0; i < index + 4; i++) {

                Debug.Log(buffer[i]);
            }

        }

        void Start() {
            // Write();
            Awak();
            // int hh;
            // hh = 5;
            // Debug.Log(hh);

            // long bb = (long)(uint)hh;
            // Debug.Log(bb);
            // Debug.Log(hh);

        }


        void Reader() {


            //     int index = 0;
            //     int ra = BinaryReader.ReadrInt(buffer, ref index);
            //     for (int i = 0; i < index; i++) {
            //         Debug.Log(buffer[i]);
            //     }

            //     Debug.Log("ra" + ra);
        }

    }
}
