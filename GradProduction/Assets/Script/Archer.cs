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
        //    Debug.Log("攻撃");
        //    timeElapsed = 0;
        //}

    }
    void OnTriggerStay(Collider other)  /*もし敵が範囲内に入ったら*/
    {
        if (other.gameObject.tag == "Enemy")    /*タグがEnemyだったら*/
        {
            timeElapsed += Time.deltaTime;

            if (timeElapsed >= interval)
            {
                Debug.Log("攻撃");
                timeElapsed = 0;
            }
            //Debug.Log("敵だ！殺せ！");       
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