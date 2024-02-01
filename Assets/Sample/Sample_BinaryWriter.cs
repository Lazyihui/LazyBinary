using System.Collections;
using System.Collections.Generic;
using UnityEngine;



namespace LazyBinary.Sample {




    public class Sample_BinaryWriter : MonoBehaviour {

        void Write() {
            byte[] buffer = new byte[1024];


            ushort Length = 0;


            int index = 2;
            int a = 2146994236;

            BinaryWrite.WriteInt(buffer, a, ref index);
            Length = (ushort)(index - 2);//6 index
            index = 0;
            BinaryWrite.WriteUshort(buffer, Length, ref index);
            for (int i = 0; i < index; i++) {
                
                Debug.Log(buffer[i]);
            }

        }

        void Start() {
            Write();
            //写入
            // BinaryWrite.WriteInt(buffer, a, ref index);
            // for (int i = 0; i < index; i++) {
            //     Debug.Log(buffer[i]);
            // }

            //读
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
