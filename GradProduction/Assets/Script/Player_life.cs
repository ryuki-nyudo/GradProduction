using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class Player_life : MonoBehaviour
{
    public Text LifeNum;
    public int count = 10; // ���C�t�̐�

   private void Start()
   {
        LifeNum.text = count.ToString(); //10�������Ă�B
       
    }
    void OnTriggerEnter(Collider other)
    {
        // Enemy�ɂԂ������Ƃ�
        if (other.gameObject.tag == "Shitappa")
        {
          --count;//���C�t��1���炷
            Debug.Log(count);
            LifeNum.text = count.ToString();
           
        }
        else if (other.gameObject.tag == "Shocky")
        {
            --count;//���C�t��1���炷
            Debug.Log(count);
            LifeNum.text = count.ToString();
        }
        else if (other.gameObject.tag == "ChoD")
        {
            --count;//���C�t��1���炷
            Debug.Log(count);
            LifeNum.text = count.ToString();
        }

        if(count <= 0)
        {
            SceneManager.LoadScene("End");
        }
    }
}