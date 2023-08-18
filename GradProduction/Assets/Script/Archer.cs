using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : MonoBehaviour
{
    /*�z��̏����i���jLIST(��)*/
    private List<GameObject> enemyList = new List<GameObject>();
    private int ObjectCount;
    /**/

    private float timeElapsed;
    private int levelNumber;

    private double AS;  /*�A�^�b�N�X�s�[�h*/
    private int ATK;    /*�A�^�b�N�_���[�W*/
    private int Area;   /*�U���͈�*/

    void Start()
    {
        timeElapsed = 0;
        levelNumber = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay(Collider other)  /*�����G���͈͓��ɓ�������*/
    {

        if (other.gameObject.tag == "Enemy")    /*�^�O��Enemy��������*/
        {

            timeElapsed += Time.deltaTime;

            if (timeElapsed >= AS)
            {

                /*���̒��ɓG���w�肵�čU�����鏈��������*/
                Debug.Log("�U��");

                timeElapsed = 0;
            }
            //Debug.Log("�G���I�E���I");       
        }
    }

    void Level()
    {
        switch (levelNumber)
        {
            case 1:
                ATK = 20;
                AS = 0.5;
                Area = 3;
                break;
            case 2:
                ATK = 20;
                AS = 0.3;
                Area = 4;
                break;
            case 3:
                ATK = 25;
                AS = 0.3;
                Area = 5;
                break;
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