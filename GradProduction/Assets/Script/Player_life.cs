using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player_life : MonoBehaviour
{
    public Text HPText;
    private int count = 10   ; // ライフの数

   private void Start()
   {
       
        HPText.text = count.ToString(); //10が入ってる。
       
    }
    void OnCollisionEnter(Collision other)
    {
        // Enemyにぶつかったとき
        if (other.gameObject.tag == "Enemy")
        {
          --count;//ライフを1減らす
            Debug.Log(count);
            HPText.text = count.ToString();
           
        }
        else
        {

        }
        if(count <= 0)
        {
            SceneManager.LoadScene("End");
        }
    }
}