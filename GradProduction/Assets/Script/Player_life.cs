
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_life : MonoBehaviour
{
    private int count = 10;     //ライフの数

    void OnCollisionEnter(Collision collision)　//オブジェクトにヒットしたら
    {

        {
            for (int i = count; i >= 1; --i)  //10から1づつ引いていきたい
            {
                Debug.Log(i);

            }
        }
    }
}