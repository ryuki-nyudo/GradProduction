using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Archer : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerStay(Collider other)  /*もし敵が範囲内に入ったら*/
    {
        if (other.gameObject.tag == "Enemy")    /*タグがEnemyだったら*/
        {
            /*memo 最終地点のオブジェクトに一番近い敵を攻撃というスクリプトを組めばうまくいきそう*/




            //Debug.Log("敵だ！殺せ！");       
        }
    }
}
