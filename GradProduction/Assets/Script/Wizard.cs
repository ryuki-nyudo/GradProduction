using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    /*�z��̏����i���jLIST(��)*/
    private List<GameObject> enemyList = new List<GameObject>();
    private int ObjectCount;
    /**/

    private float timeElapsed;
    private int levelNumber;

    public double AS;  /*�A�^�b�N�X�s�[�h*/
    public int ATK;    /*�A�^�b�N�_���[�W*/
    public int Area;   /*�U���͈�*/

    HPScript hpScript;  //HPScript

    void Start()
    {
        timeElapsed = 0;
        levelNumber = 1;
    }

    // Update is called once per frame
    void Update()
    {
        Level();

        if (enemyList.Count > 0)
        {
            GameObject element = enemyList[0];
            timeElapsed += Time.deltaTime;
            if (timeElapsed >= AS)
            {

                /*���̒��ɓG���w�肵�čU�����鏈��������*/
                GameObject firstEnemy = enemyList[0];   //�z��ŏ��̓G

                hpScript = firstEnemy.GetComponent<HPScript>();

                hpScript.enemyHP -= ATK;

                Debug.Log("�U��");
                timeElapsed = 0;

                if (hpScript.enemyHP <= 0)
                {
                    enemyList.RemoveAt(0);
                }
            }
        }


        ///*�e�X�g�G���A*/
        //if (Input.GetMouseButtonDown(0))
        //{
        //    hpScript.enemyHP -= 1;
        //    Debug.Log("���N���b�N");
        //}



        /*�e�X�g�G���A*/
    }
    void OnTriggerEnter(Collider other)  /*�����G���͈͓��ɓ�������*/
    {

        if (other.gameObject.tag == "Enemy")    /*�^�O��Enemy��������*/
        {
            enemyList.Add(other.gameObject);
        }
    }



    void OnTriggerExit(Collider other)
    {
        enemyList.RemoveAt(0);
    }

    void Level()
    {
        switch (levelNumber)
        {
            case 1:
                ATK = 15;
                AS = 0.5;
                Area = 3;
                break;
            case 2:
                ATK = 15;
                AS = 0.3;
                Area = 4;
                break;
            case 3:
                ATK = 20;
                AS = 0.3;
                Area = 5;
                break;
        }
    }
}

