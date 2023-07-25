
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_life : MonoBehaviour
{
    private int count = 10;

    void OnCollisionEnter(Collision collision)
    {
        for (int i = count; i >= 1; --i)
        {
          
        }
        //Debug.Log("Hit"); // ƒƒO‚ğ•\¦‚·‚é
        Debug.Log(count);
    }
}