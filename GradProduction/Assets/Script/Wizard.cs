using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    /*配列の処理（仮）LIST(仮)*/
    private List<GameObject> enemyList = new List<GameObject>();
    private int ObjectCount;
    /**/

    private float timeElapsed;
    private int levelNumber;

    public double AS;  /*アタックスピード*/
    public int ATK;    /*アタックダメージ*/
    public int Area;   /*攻撃範囲*/

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

                /*この中に敵を指定して攻撃する処理を書く*/
                GameObject firstEnemy = enemyList[0];   //配列最初の敵

                hpScript = firstEnemy.GetComponent<HPScript>();

                hpScript.enemyHP -= ATK;

                Debug.Log("攻撃");
                timeElapsed = 0;

                if (hpScript.enemyHP <= 0)
                {
                    enemyList.RemoveAt(0);
                }
            }
        }


        ///*テストエリア*/
        //if (Input.GetMouseButtonDown(0))
        //{
        //    hpScript.enemyHP -= 1;
        //    Debug.Log("左クリック");
        //}



        /*テストエリア*/
    }
    void OnTriggerEnter(Collider other)  /*もし敵が範囲内に入ったら*/
    {

        if (other.gameObject.tag == "Enemy")    /*タグがEnemyだったら*/
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

