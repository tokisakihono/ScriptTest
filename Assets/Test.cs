using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Test : MonoBehaviour
{
    //問１、要素の個数が5の、int型の配列arrayを宣言して好きな値で初期化
    void Start()
    {
        int[] array = new int[5];

        array [0] = 10;
        array [1] = 20;
        array [2] = 30;
        array [3] = 40;
        array [4] = 50;

        //問２、for文を使い、配列の各要素の値を順番に表示
        for (int i = 0; i < 5; i++)
        {
            Debug.Log(array[i]);
        }
        //問３、for文を使い、配列の各要素の値を逆順に表示
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
