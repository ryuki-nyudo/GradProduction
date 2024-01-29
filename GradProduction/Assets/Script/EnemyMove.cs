
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyMove : MonoBehaviour{
    //移動ターゲット
    public Transform m_CenterTarget;
    public Transform m_Target;
    public Transform m_Goal;

    public GameObject PlayerLife;

    //ターゲットからゴールに移動変更
    private int change = 0;

    //移動速度
    private float SPD;

    //防衛キャラ接敵
    public bool WallArea;
    public bool WallPlayer;
    private float Areatime;
    private bool EnemyHit;

    HPScript hpScript;  //壁兵士HPScript
    Player_life HPScript;

    //敵攻撃
    private double AS = 0.5f;  //攻撃速度
    private int ATK = 1;      //攻撃力
    private float ATKtime;

    void Start(){
        change = 0;
        SPD = 0.0f;

        //Player接触処理
        WallArea = false;
        WallPlayer = false;
        EnemyHit = false;
        Areatime = 0.0f;

        ATKtime = 0.0f;

        PlayerLife = GameObject.Find("GOAL");
        HPScript = PlayerLife.GetComponent<Player_life>();
    }

    void Update() {
        MoveSpeed();
        //進行
        if (WallArea == false)
        {
            switch (change)
            {
                case 0: //真ん中に移動させる
                    transform.position = Vector3.MoveTowards(
                transform.position,
                m_CenterTarget.transform.position,
                SPD * Time.deltaTime
                );
                    //進行方向に向きを変える    
                    transform.LookAt(m_CenterTarget.transform);
                    break;
                case 1: //進行させる
                    transform.position = Vector3.MoveTowards(
                transform.position,
                m_Target.transform.position,
                SPD * Time.deltaTime
                );
                    //進行方向に向きを変える    
                    transform.LookAt(m_Target.transform);
                    break;
                case 2: //ゴールに向かせる
                    transform.position = Vector3.MoveTowards(
                transform.position,
                m_Goal.transform.position,
                SPD * Time.deltaTime
                );
                    //進行方向に向きを変える    
                    transform.LookAt(m_Goal.transform);
                    break;
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
        if (other.gameObject.tag == "Center")
        {
            change = 1;
        }
        else if (other.gameObject.tag == "Target")
        {
            change = 2;
        }
        //ゴールに触れたら消す
        else if (other.gameObject.tag == "Goal")
        {
            --HPScript.count;
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

    private void MoveSpeed()
    {
        if (gameObject.CompareTag("Shitappa"))
        {
            SPD = 10.0f;
        }
        else if (gameObject.CompareTag("Shocky"))
        {
            SPD = 4.0f;
        }
        else if (gameObject.CompareTag("ChoD"))
        {
            SPD = 3.0f;
        }
    }
}
