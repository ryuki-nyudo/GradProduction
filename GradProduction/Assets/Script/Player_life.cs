

using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_life : MonoBehaviour
{
    private int count = 10; // ���C�t�̐�

    void OnCollisionEnter(Collision other)
    {
        // �{�[���ɂԂ������Ƃ�
        if (other.gameObject.tag == "Enemy")
        {
            --count; // ���C�t��1���炷
            Debug.Log(count);
        }
        else
        {

        }
    }
}