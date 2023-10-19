using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    private bool spawn;
    GameObject Enemy;    //Enemyオブジェクト情報
    private int EnemyMaxNum;    //出現Enemy
    private int EnemyNum;
    Vector3 EInitPosition; //Enemy初期座標

    public float testtime;

    private float time;

    // Start is called before the first frame update
    void Start()
    {
        Enemy = (GameObject)Resources.Load ("EnemyTestCube");
        EnemyNum = 0;
        EnemyMaxNum = 3;  

        EInitPosition = GameObject.Find("EnemySpawn").transform.position;

        //時間処理
        time = 0.0f;

        spawn = true;
    }

    // Update is called once per frame
    void Update()
    {

        if(spawn){
            //タイマー開始
            time += Time.deltaTime;

            //3体出すを2秒経ったら実行
            for(; EnemyNum < EnemyMaxNum && time >= 2.0f; ){
                Instantiate (Enemy, EInitPosition, Quaternion.identity);
                EnemyNum++;
                if(EnemyNum == EnemyMaxNum){
                    spawn = false;
                    Debug.Log(EnemyNum);
                }
                //タイマーリセット
                time = 0.0f;
            }
        }
    }
}
