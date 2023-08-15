using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HPScript : MonoBehaviour
{
     // 敵のヒットポイントを設定
    public int enemyHP = 100;
    private int wkHP;

    public Slider hpSlider;

    // Start is called before the first frame update
    void Start()
    {
        hpSlider.value = (float)enemyHP;
        wkHP = enemyHP;
    }

    // Update is called once per frame
    void Update()
    {
        // スライダーの向きをカメラ方向に固定
        hpSlider.transform.rotation = Camera.main.transform.rotation;
    }
}
