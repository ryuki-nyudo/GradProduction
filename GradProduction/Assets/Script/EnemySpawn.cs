using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    private bool spawn;                 // 敵を生成するかどうかのフラグ
    GameObject Enemy;                   // 敵オブジェクトの情報
    private int EnemyMaxNum;            // 出現する敵の最大数
    private int EnemyNum;               // 現在の敵の数
    private int SpawnNum;               // 敵の生成回数
    private int MaxSpawn = 10;          // 最大生成回数
    Vector3 EInitPosition;              // 敵の初期座標

    private float time;                 // 経過時間

    // Start is called before the first frame update
    void Start()
    {
        Enemy = (GameObject)Resources.Load("GruntPBR");  // 敵のプレハブをリソースからロード
        EnemyNum = 0;
        EnemyMaxNum = 10;

        EInitPosition = GameObject.Find("EnemySpawn").transform.position;  // 敵の初期位置を設定

        time = 0.0f;  // 経過時間の初期化

        spawn = true;  // 敵の生成を開始する
        SpawnNum = 0;
    }

    // Update is called once per frame
    void Update()
    {
        time += Time.deltaTime;  // 経過時間の更新

        if (spawn == true)
        {
            // 敵の生成条件を満たした場合に敵を生成
            for (; EnemyNum < EnemyMaxNum && time >= 2.0f;)
            {
                Instantiate(Enemy, EInitPosition, Quaternion.identity);  // 敵を生成
                EnemyNum++;

                if (EnemyNum == EnemyMaxNum)
                {
                    spawn = false;  // 敵の生成を停止
                    SpawnNum++;
                }

                time = 0.0f;  // 経過時間をリセット
            }
        }
        else if (SpawnNum < MaxSpawn)
        {
            // 一定時間経過したら敵の生成を再開
            if (time >= 9.0f)
            {
                spawn = true;  // 敵の生成を再開
                time = 0.0f;
                EnemyNum = 0;  // 現在の敵の数をリセット
            }
        }
    }
}