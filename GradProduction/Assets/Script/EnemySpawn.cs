using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    private bool spawn;
    GameObject Shitappa;
    GameObject Shocky;
    GameObject ChoD;
    private int EnemyMaxNum;    //出現Enemy
    private int EnemyNum;
    private int SpawnNum;
    private int MaxSpawn = 10;

    Vector3 EInitPosition1; //Enemy初期座標
    Vector3 EInitPosition2; //Enemy初期座標

    private float time;
    private float MaxTime = 9.0f;
    public bool SpawnMaxflg;

    // Start is called before the first frame update
    void Start()
    {
        //Object情報
        Shitappa = (GameObject)Resources.Load("SlimePBR");
        Shocky = (GameObject)Resources.Load("GruntPBR");
        ChoD = (GameObject)Resources.Load("HP_Golem");

        EnemyNum = 0;
        EnemyMaxNum = 3;

        EInitPosition1 = GameObject.Find("EnemySpawn1").transform.position;
        EInitPosition2 = GameObject.Find("EnemySpawn2").transform.position;


        //時間処理
        time = 0.0f;

        spawn = true;
        SpawnNum = 0;

        SpawnMaxflg = false;
    }

    // Update is called once per frame
    void Update()
    {
        //タイマー開始
        time += Time.deltaTime;

        if (spawn == true)
        {
            //3体出すを2秒経ったら実行
            for (; EnemyNum < EnemyMaxNum && time >= 2.0f;)
            {
                //Spawn1
                switch (SpawnNum)
                {
                    case 0:
                    case 1:
                    case 4:
                    case 7:
                        Instantiate(Shitappa, EInitPosition1, Quaternion.identity);
                        break;
                    case 3:
                    case 6:
                        Instantiate(Shocky, EInitPosition1, Quaternion.identity);
                        break;
                    case 5:
                    case 8:
                    case 9:
                        Instantiate(ChoD, EInitPosition1, Quaternion.identity);
                        break;
                }

                //Spawn2
                switch (SpawnNum)
                {
                    case 1:
                    case 3:
                        Instantiate(Shitappa, EInitPosition2, Quaternion.identity);
                        break;
                    case 2:
                    case 4:
                    case 6:
                    case 8:
                        Instantiate(Shocky, EInitPosition2, Quaternion.identity);
                        break;
                    case 7:
                    case 9:
                        Instantiate(ChoD, EInitPosition2, Quaternion.identity);
                        break;

                }
                EnemyNum++;
                if (EnemyNum == EnemyMaxNum)
                {
                    spawn = false;
                    SpawnNum++;
                }
                //タイマーリセット
                time = 0.0f;
            }
        }
        //10回出すを9.0秒間隔でやる
        else if (SpawnNum < MaxSpawn)
        {
            if (time >= MaxTime)
            {
                spawn = true;
                time = 0.0f;
                EnemyNum = 0;
            }
        }
        else
        {
            SpawnMaxflg = true;
        }
    }
}
