using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wizard : MonoBehaviour
{
    private List<GameObject> enemyList = new List<GameObject>();
    private int ObjectCount;
    private SphereCollider sphereCollider;
    private float timeElapsed;
    private int levelNumber;

    private double AS;  /*攻撃速度*/
    private int ATK;    /*攻撃力*/
    private float Area;   /*攻撃範囲*/
    private float Target; //狙う敵の数
    private int i;

    private HPScript hpScript;

    void Start()
    {
        sphereCollider = GetComponent<SphereCollider>();
        timeElapsed = 0;
        levelNumber = 1;
    }

    void Update()
    {
        sphereCollider.radius = Area;
        Level();

        if (enemyList.Count > 0)
        {
            GameObject element = enemyList[0];  //リストの先頭の敵を取得
            timeElapsed += Time.deltaTime;
            if (timeElapsed >= AS)  //ASに達したとき
            {
                for (i = 0; i < Target; i++)
                {
                    GameObject firstEnemy = enemyList[i];       //リストの先頭を取得
                    hpScript = firstEnemy.GetComponent<HPScript>();     //戦闘の敵のHPスクリプトを取得
                }
                hpScript.HP -= ATK;     //ダメージを与える

                Debug.Log("攻撃");
                timeElapsed = 0;

                if (hpScript.HP <= 0)
                {
                    enemyList.RemoveAt(0);
                }
            }
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy")
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
                AS = 0.7;
                Area = 4f;
                Target = 3;
                break;
            case 2:
                ATK = 15;
                AS = 0.7;
                Area = 4f;
                Target = 4;
                break;
            case 3:
                ATK = 20;
                AS = 0.7;
                Area = 5f;
                Target = 5;
                break;
        }
    }
}