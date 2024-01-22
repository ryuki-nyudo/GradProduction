
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMove : MonoBehaviour{
    //移動ターゲット
    [SerializeField]
    private Transform m_Target;
    [SerializeField]
    private Transform m_Goal;

    //ターゲットからゴールに移動変更
    private bool change = false;

    //移動速度
    private float SPD = 5.0f;

    //防衛キャラ接敵
    public bool WallArea;
    public bool WallPlayer;
    private float Areatime;
    private bool EnemyHit;

    HPScript hpScript;  //壁兵士HPScript

    //敵攻撃
    private double AS = 0.5f;  //攻撃速度
    private int ATK = 1;      //攻撃力
    private float ATKtime;

    void Start(){
        change = false;

        //Player接触処理
        WallArea = false;
        WallPlayer = false;
        EnemyHit = false;
        Areatime = 0.0f;

        ATKtime = 0.0f;
    }

    void Update() {
        //進行
        if (WallArea == false) {
            //target移動
            if (change == false) {
                transform.position = Vector3.MoveTowards(
                    transform.position,
                    m_Target.transform.position,
                    SPD * Time.deltaTime
                    );

                transform.LookAt(m_Target.transform);
            }
            //goal移動
            else {
                transform.position = Vector3.MoveTowards(
                    transform.position,
                    m_Goal.transform.position,
                    SPD * Time.deltaTime
                    );

                transform.LookAt(m_Goal.transform);
            }
        }

        //接触処理
        else {
            //Playerと戦闘状態
            if (WallPlayer == true) {
                ATKtime += Time.deltaTime;
                if (ATKtime >= AS) {
                    hpScript.HP -= ATK;
                    ATKtime = 0.0f;
                }

                if (hpScript.HP <= 0) {
                    WallPlayer = false;
                }
            }
        }

        //Enemy衝突
        if (EnemyHit == true){
            Areatime += Time.deltaTime;
            if(Areatime >= 2.5f){
                EnemyHit = false;
            }
        }
    }

    void OnTriggerEnter(Collider other){
        //進行ターゲットに触れたらゴールに移動する
        if (other.gameObject.tag == "Target"){
            change = true;
        }
        //ゴールに触れたら消す
        else if (other.gameObject.tag == "Goal"){
            Destroy(gameObject);
        }

        ////Enemy同士でぶつかってPlayerと接触状態だったら進行する
        //if (other.gameObject.tag == "Enemy" && other.GetComponent<EnemyMove>().WallArea == true){
        //    EnemyHit = true;
        //    WallPlayer = false;
        //    WallArea = false;
        //    Debug.Log("Enemy衝突");
        //}

        //if (EnemyHit == false){
        //    //Playerエリアに接触したら
        //    if (other.gameObject.tag == "Player" && other.GetComponent<SphereCollider>() != null){
        //        WallArea = true;
        //    }
        //    //Playerに接触したら
        //    else if (other.gameObject.tag == "Player" && other.GetComponent<BoxCollider>() != null){
        //        WallPlayer = true;
        //        hpScript = other.gameObject.GetComponent<HPScript>();
        //    }
        //}
    }
}
