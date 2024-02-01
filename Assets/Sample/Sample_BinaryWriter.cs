using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace LazyBinary.Sample {

    public class Sample_BinaryWriter : MonoBehaviour {



        void Start() {


            byte[] buffer = new byte[1024];

            int index = 0;

            int a = 100;
            //写入
            BinaryWrite.WriteInt(buffer, a, ref index);
            for (int i = 0; i < index; i++) {
                Debug.Log(buffer[i]);
            }

            //读
            int ra = 0;
            ra = buffer[0];
            ra = ra | (buffer[1] << 8);
            ra = ra | (buffer[2] << 16);
            ra = ra | (buffer[3] << 24);

            Debug.Log("ra" + ra);
        }

    }
}
