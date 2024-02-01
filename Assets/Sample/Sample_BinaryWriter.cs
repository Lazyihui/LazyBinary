using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace LazyBinary.Sample {

    public class Sample_BinaryWriter : MonoBehaviour {



        void Start() {


            byte[] buffer = new byte[1024];

            int index = 0;

            int a = 2146994236;
            //写入
            BinaryWrite.WriteInt(buffer, a, ref index);
            for (int i = 0; i < index; i++) {
                Debug.Log(buffer[i]);
            }

            //读
            index = 0;
            int ra = BinaryReader.ReadrInt(buffer, ref index);
            for (int i = 0; i < index; i++) {
                Debug.Log(buffer[i]);
            }

            Debug.Log("ra" + ra);
        }

    }
}
