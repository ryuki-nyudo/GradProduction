using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : MonoBehaviour
{
    /*配列の処理（仮）LIST(仮)*/
    private List<GameObject> enemyList = new List<GameObject>();
    private int ObjectCount;
    /**/

    private float timeElapsed;
    private int levelNumber;

    private double AS;  /*アタックスピード*/
    private int ATK;    /*アタックダメージ*/
    private int Area;   /*攻撃範囲*/

    void Start()
    {
        timeElapsed = 0;
        levelNumber = 1;
    }

    // Update is called once per frame
    void Update()
    {

    }
    void OnTriggerStay(Collider other)  /*もし敵が範囲内に入ったら*/
    {

        if (other.gameObject.tag == "Enemy")    /*タグがEnemyだったら*/
        {

            timeElapsed += Time.deltaTime;

            if (timeElapsed >= AS)
            {

                /*この中に敵を指定して攻撃する処理を書く*/
                Debug.Log("攻撃");

                timeElapsed = 0;
            }
            //Debug.Log("敵だ！殺せ！");       
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

範囲に入った順番に攻撃を仕掛ける
OnCollisionStayの中に敵を検知したらEnemyに入れる処理を書いてその中で一番ゴールに近い敵を優先的に配列に組み込んで攻撃をしていく処理の想定

 
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
//        /*ターゲットポジションを取得*/
//        Vector3 GoalPos = Goal.transform.position;

//        /*Enemyのポジションを取得*/
//        Vector3 EnemyPos = Enemy.transform.position;

//        /*ゴールとエネミーの距離を取得*/
//        float dis = Vector3.Distance(GoalPos, EnemyPos);
//    }
//    void OnTriggerStay(Collider other)  /*もし敵が範囲内に入ったら*/
//    {
//        if (other.gameObject.tag == "Enemy")    /*タグがEnemyだったら*/
//        {

//            //Debug.Log("敵だ！殺せ！");       
//        }
//    }
//}


///*MEMO

//範囲に入った順番に攻撃を仕掛ける
//OnCollisionStayの中に敵を検知したらEnemyに入れる処理を書いてその中で一番ゴールに近い敵を優先的に配列に組み込んで攻撃をしていく処理の想定


//*/