using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour
{
    //��P�A�v�f�̌���5�́Aint�^�̔z��array��錾���čD���Ȓl�ŏ�����
    void Start()
    {
        int[] array = new int[5];

        array [0] = 10;
        array [1] = 20;
        array [2] = 30;
        array [3] = 40;
        array [4] = 50;

        //��Q�Afor�����g���A�z��̊e�v�f�̒l�����Ԃɕ\��
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        //��R�Afor�����g���A�z��̊e�v�f�̒l���t���ɕ\��
        for (int i =array.Length - 1; 0 <= i; i--)
        {
            Debug.Log(array[i]);
        }
    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
