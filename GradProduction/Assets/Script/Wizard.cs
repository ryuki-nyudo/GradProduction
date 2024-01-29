using System.Collections;
using System.Collections.Generic;
using UnityEngine;

// ... (previous using statements)

public class Wizard : MonoBehaviour
{
    private List<GameObject> enemyList = new List<GameObject>();
    private SphereCollider sphereCollider;
    private float timeElapsed;
    private int levelNumber;

    private double attackSpeed; /*攻撃速度*/
    private int attackDamage;   /*攻撃力*/
    private float attackArea;  /*攻撃範囲*/
    private float targetCount; /*狙う敵の数*/

    private HPScript hpScript;

    void Start()
    {
        sphereCollider = GetComponent<SphereCollider>();
        timeElapsed = 0;
        levelNumber = 1;
        Level();//初期レベルを設定
        attackArea = 1;
    }

    void Update()
    {
        sphereCollider.radius = attackArea;
        timeElapsed += Time.deltaTime;

        if (enemyList.Count > 0 && timeElapsed >= attackSpeed)
        {
            int numberOfEnemiesToAttack = Mathf.FloorToInt(targetCount);

            for (int i = 0; i < numberOfEnemiesToAttack && i < enemyList.Count; i++)
            {
                GameObject currentEnemy = enemyList[i];//リストの先頭の敵を取得
                Debug.Log("敵を攻撃中: " + currentEnemy.name);

                hpScript = currentEnemy.GetComponent<HPScript>();
                hpScript.HP -= attackDamage;

                if (hpScript.HP <= 0)
                {
                    enemyList.RemoveAt(i);
                    i--; // 削除された要素を考慮してインデックスを調整
                    Debug.Log("要素を削除");
                }
            }

            timeElapsed = 0;
        }
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Enemy" || other.gameObject.tag == "Shitappa" || other.gameObject.tag == "Shocky" || other.gameObject.tag == "ChoD")
        {
            enemyList.Add(other.gameObject);
        }
    }

    void OnTriggerExit(Collider other)
    {
        enemyList.Remove(other.gameObject);
    }

    void Level()
    {
        switch (levelNumber)
        {
            case 1:
                attackDamage = 15;
                attackSpeed = 0.7f;
                attackArea = 4f;
                targetCount = 3;
                break;
            case 2:
                attackDamage = 15;
                attackSpeed = 0.7f;
                attackArea = 4f;
                targetCount = 4;
                break;
            case 3:
                attackDamage = 20;
                attackSpeed = 0.7f;
                attackArea = 5f;
                targetCount = 5;
                break;
        }
    }
}
