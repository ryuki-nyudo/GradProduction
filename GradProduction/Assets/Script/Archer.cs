using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : MonoBehaviour
{
    private double interval;
    private float timeElapsed;

    // Start is called before the first frame update
    void Start()
    {
        interval = 0.5;  /*  AS 1/0.5s */
        timeElapsed = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //timeElapsed += Time.deltaTime;

        //if(timeElapsed >= interval)
        //{
        //    Debug.Log("�U��");
        //    timeElapsed = 0;
        //}

    }
    void OnTriggerStay(Collider other)  /*�����G���͈͓��ɓ�������*/
    {
        if (other.gameObject.tag == "Enemy")    /*�^�O��Enemy��������*/
        {
            timeElapsed += Time.deltaTime;

            if (timeElapsed >= interval)
            {
                Debug.Log("�U��");
                timeElapsed = 0;
            }
            //Debug.Log("�G���I�E���I");       
        }
    }
}


/*MEMO

�͈͂ɓ��������ԂɍU�����d�|����
OnCollisionStay�̒��ɓG�����m������Enemy�ɓ���鏈���������Ă��̒��ň�ԃS�[���ɋ߂��G��D��I�ɔz��ɑg�ݍ���ōU�������Ă��������̑z��

 
*/



//using System.Collections;
//using System.Collections.Generic;
//using UnityEngine;

//public class Archer : MonoBehaviour
//{
//    [SerializeField] private GameObject Goal;
//    [SerializeField] private GameObject Enemy;
//    private float dis;
//    // Start is called before the first frame update
//    void Start()
//    {

//    }

//    // Update is called once per frame
//    void Update()
//    {
//        /*�^�[�Q�b�g�|�W�V�������擾*/
//        Vector3 GoalPos = Goal.transform.position;

//        /*Enemy�̃|�W�V�������擾*/
//        Vector3 EnemyPos = Enemy.transform.position;

//        /*�S�[���ƃG�l�~�[�̋������擾*/
//        float dis = Vector3.Distance(GoalPos, EnemyPos);
//    }
//    void OnTriggerStay(Collider other)  /*�����G���͈͓��ɓ�������*/
//    {
//        if (other.gameObject.tag == "Enemy")    /*�^�O��Enemy��������*/
//        {

//            //Debug.Log("�G���I�E���I");       
//        }
//    }
//}


///*MEMO

//�͈͂ɓ��������ԂɍU�����d�|����
//OnCollisionStay�̒��ɓG�����m������Enemy�ɓ���鏈���������Ă��̒��ň�ԃS�[���ɋ߂��G��D��I�ɔz��ɑg�ݍ���ōU�������Ă��������̑z��


//*/