using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;


namespace LazyBinary.Sample {

    public class RoleEntity {

        public int level;
        public int hp;
        public int def;


        public void Save() {
            byte[] buffer = new byte[1024];

            int index = 2;

            BinaryWrite.WriteInt(buffer, level, ref index);
            BinaryWrite.WriteInt(buffer, hp, ref index);
            BinaryWrite.WriteInt(buffer, def, ref index);

            index = 0;
            BinaryWrite.WriteUshort(buffer, (ushort)(index - 2), ref index);

            File.WriteAllBytes(System.Environment.CurrentDirectory + "/role.sav", buffer);


        }

        public void Load() {
            byte[] buffer = File.ReadAllBytes(System.Environment.CurrentDirectory + "/role.sav");

            // int index = 0;
            // ushort Length = BinaryReader.ReadrUshort(buffer, ref index);
            int index = 0;
            ushort length = BinaryReader.ReadUshort(buffer, ref index);

            level = BinaryReader.ReadrInt(buffer, ref index);
            hp = BinaryReader.ReadrInt(buffer, ref index);
            def = BinaryReader.ReadrInt(buffer, ref index);


        }
        public void Log() {
            Debug.Log("lev:" + level + ",hp:" + hp + ",def:" + def);
        }
    }



    public class Sample_BinaryWriter : MonoBehaviour {

        void Awak() {
            RoleEntity role = new RoleEntity();
            role.Load();
            role.Log();
            // role.level = 99;
            // role.hp = 75;
            // role.def = 55;
            // role.Save();
            // role.Log();
        }

        void Write() {
            byte[] buffer = new byte[1024];


            ushort Length = 0;


            int index = 2;
            int a = 2146994236;

            BinaryWrite.WriteInt(buffer, a, ref index);
            Length = (ushort)(index - 2);//6 index
            index = 0;
            BinaryWrite.WriteUshort(buffer, Length, ref index);
            for (int i = 0; i < index + 4; i++) {

                Debug.Log(buffer[i]);
            }

        }

        void Start() {
            // Write();
            Awak();
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
