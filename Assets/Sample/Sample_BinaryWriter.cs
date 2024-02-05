using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


namespace LazyBinary.Sample {

    public class RoleEntity {



        public char[] char1;

        public bool[] bool1;


        public void Save() {
            byte[] buffer = new byte[1024];

            int index = 2;

            BinaryWrite.WriteChar2Arr(buffer, char1, ref index);//4
            BinaryWrite.WriteBoolArr(buffer, bool1, ref index);//4




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
            char1 = BinaryReader.ReadCharArr(buffer, ref index);
            bool1 = BinaryReader.readBoolArr(buffer, ref index);


            for (int i = 0; i < index; i++) {
                Debug.Log(buffer[i]);
            }

        }
        public void Log() {
            for (int i = 0; i < 2; i++) {
                Debug.Log(char1[i]);
            }
            for (int i = 0; i < 2; i++) {
                Debug.Log(bool1[i]);
            }
        }
    }



    public class Sample_BinaryWriter : MonoBehaviour {

        void Awak() {
            RoleEntity role = new RoleEntity();
            // role.Load();
            // role.Log();


            role.char1 = new char[2];
            for (int i = 0; i < 2; i++) {
                role.char1[i] = '哈';
            }
            role.bool1 = new bool[2];
            for (int i = 0; i < 2; i++) {
                role.bool1[i] = true;
            }


            role.Save();
            role.Log();
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
