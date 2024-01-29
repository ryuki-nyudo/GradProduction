using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPScript : MonoBehaviour
{
    // 敵のヒットポイントを設定
    public int HP;
    private int wkHP;

    public Slider hpSlider;

    Transform InitiaRotation;

    private bool Cameraflg;

    //GameObject CoinScript;
    //Coin_Script EnemyCoin;
    // Start is called before the first frame update
    void Start()
    {
        //tagによってHPを変える
        if (gameObject.CompareTag("Player"))
        {
            HP = 100;
        }
        else if (gameObject.CompareTag("Shitappa"))
        {
            HP = 50;
        }
        else if (gameObject.CompareTag("Shocky"))
        {
            HP = 100;
        }
        else if (gameObject.CompareTag("ChoD"))
        {
            HP = 200;
        }

        Cameraflg = false;


        //CoinScript = GameObject.Find("CoinImage");
        //EnemyCoin = CoinScript.GetComponent<Coin_Script>();

        hpSlider.value = (float)HP;
        wkHP = HP;

    }

    // Update is called once per frame
    void Update()
    {
        if (Cameraflg == false)
        {
            // スライダーの向きをカメラ方向に固定
            hpSlider.transform.rotation = Camera.main.transform.rotation;
            Cameraflg = true;
        }

        //HP処理
        hpSlider.value = (float)HP / (float)wkHP;
        if (HP <= 0)
        {
            Coin();
            Destroy(gameObject);
        }
    }

    void Coin()
    {
        if (gameObject.CompareTag("Enemy"))
        {
            //EnemyCoin.Coin += 10;
        }
    }
}
