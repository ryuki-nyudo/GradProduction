using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other)  /*�����G���͈͓��ɓ�������*/
    {
        if (other.gameObject.tag == "Enemy")    /*�^�O��Enemy��������*/
        {
            /*memo �ŏI�n�_�̃I�u�W�F�N�g�Ɉ�ԋ߂��G���U���Ƃ����X�N���v�g��g�߂΂��܂���������*/




            //Debug.Log("�G���I�E���I");       
        }
    }
}
