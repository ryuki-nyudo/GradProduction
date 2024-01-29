using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player_life : MonoBehaviour
{
    public Text LifeNum;
    public int count = 10; // ライフの数

   private void Start()
   {
        LifeNum.text = count.ToString(); //10が入ってる。
       
    }
    void OnTriggerEnter(Collider other)
    {
        // Enemyにぶつかったとき
        if (other.gameObject.tag == "Shitappa")
        {
          --count;//ライフを1減らす
            Debug.Log(count);
            LifeNum.text = count.ToString();
           
        }
        else if (other.gameObject.tag == "Shocky")
        {
            --count;//ライフを1減らす
            Debug.Log(count);
            LifeNum.text = count.ToString();
        }
        else if (other.gameObject.tag == "ChoD")
        {
            --count;//ライフを1減らす
            Debug.Log(count);
            LifeNum.text = count.ToString();
        }

        if(count <= 0)
        {
            SceneManager.LoadScene("End");
        }
    }
}