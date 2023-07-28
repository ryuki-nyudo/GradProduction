

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_life : MonoBehaviour
{
    private int count = 10; // ライフの数

    void OnCollisionEnter(Collision other)
    {
        // ボールにぶつかったとき
        if (other.gameObject.tag == "Enemy")
        {
            --count; // ライフを1減らす
            Debug.Log(count);
        }
        else
        {

        }
    }
}