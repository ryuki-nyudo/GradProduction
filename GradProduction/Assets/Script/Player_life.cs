
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_life : MonoBehaviour
{
    private int count = 10;     //���C�t�̐�

    void OnCollisionEnter(Collision collision)�@//�I�u�W�F�N�g�Ƀq�b�g������
    {

        {
            for (int i = count; i >= 1; --i)  //10����1�Â����Ă�������
            {
                Debug.Log(i);

            }
        }
    }
}