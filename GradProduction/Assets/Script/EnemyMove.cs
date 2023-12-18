
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class EnemyMove : MonoBehaviour{
    //移動ターゲット
    [SerializeField]
    private Transform m_Target;
    [SerializeField]
    private Transform m_Goal;

    //ターゲットからゴールに移動変更
    private bool change = false;

    //移動速度
    private float SPD = 10.0f;

    //防衛キャラ接敵
    public bool BlockObj;
    public bool BlockPlayer;
    HPScript hpScript;  //壁兵士HPScript

    //敵攻撃
    private double AS = 0.5f;  //攻撃速度
    private int ATK = 1;      //攻撃力
    private float ATKtime;

    //enemyとの接触処理
    private bool E_Hit;
    private float E_Count;
    private bool enemyHit;
    private BoxCollider boxCollider;

    void Start(){
        change = false;
        BlockObj = false;
        BlockPlayer = false;

        E_Hit = false;
        E_Count = 0.0f;

        ATKtime = 0.0f;

        enemyHit = false;
        boxCollider = null;
    }

    void Update(){
        //衝突無視判定
        BoxCollider myCollider = gameObject.GetComponent<BoxCollider>();
        if (enemyHit == true){
            // IgnoreCollisionを呼び出す
            //Physics.IgnoreCollision(myCollider, boxCollider, true);
            // IgnoreCollisionの後で、Collisionの状態を再び確認するためのデバッグログ
            //bool afterCollision = Physics.GetIgnoreCollision(myCollider, boxCollider);
            //Debug.Log("After IgnoreCollision: " + afterCollision);
        }


        if (boxCollider != null){
            Debug.Log(boxCollider.name);
        }
        else{
            Debug.Log("eroor");
        }

        if (BlockObj == false && BlockPlayer == false){
            //target移動
            if (change == false){
                transform.position = Vector3.MoveTowards(
                    transform.position,
                    m_Target.transform.position,
                    SPD * Time.deltaTime
                    );
            }
            //goal移動
            else{
                transform.position = Vector3.MoveTowards(
                    transform.position,
                    m_Goal.transform.position,
                    SPD * Time.deltaTime
                    );
            }
        }

        //敵と戦闘状態
        else if (BlockPlayer == true){
            ATKtime += Time.deltaTime;
            if (ATKtime >= AS){
                hpScript.HP -= ATK;
                ATKtime = 0.0f;
            }

            if (hpScript.HP <= 0){
                BlockPlayer = false;
                BlockObj = false;
            }
        }
    }

    void OnTriggerEnter(Collider other){
        //ターゲットに触れたらゴールに移動する
        if (other.gameObject.tag == "Target"){
            change = true;
            //Destroy(other.gameObject);
        }

        //敵同士がぶつかったら
        if (other.gameObject.tag == "Enemy" && other.GetComponent<EnemyMove>() != null){
            //衝突を無視する
            boxCollider = other.GetComponent<BoxCollider>();
            enemyHit = true;
        }

        //壁Playerにぶつかったら
        if (other.gameObject.tag == "Block"){
            BlockObj = true;
        }
        else if (other.gameObject.tag == "Player"){
            BlockObj = true;
            BlockPlayer = true;
            hpScript = other.gameObject.GetComponent<HPScript>();
        }

        //ゴールに触れたら消す
        if (other.gameObject.tag == "Goal"){
            Destroy(gameObject);
        }
    }

    void OnTriggerExit(Collider other){
        if (other.gameObject.tag == "Enemy"){
            // 衝突から離れたら再び衝突を検知するように設定する
            //Physics.IgnoreCollision(GetComponenat<Collider>(), other.GetComponent<Collider>(), false);
        }
    }
}
