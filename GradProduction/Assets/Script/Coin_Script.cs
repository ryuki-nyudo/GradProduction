using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin_Script : MonoBehaviour
{
    // Start is called before the first frame update
  
    //public GameObject objectPrefab; // �ݒu����I�u�W�F�N�g�̃v���n�u
                                    // Update is called once per frame

    //�`�掞��
    float maXtime, time;
    public Text CoinText;
    public int Coin;

    public float span = 1f;
    private float currentTime = 0f;


    private void Start()
    {
        Coin = 0;
        CoinText.text = Coin.ToString();
        maXtime = 0.5f;
        time = 0.0f;
    }

    //public void Add()
    //{
    //    Debug.Log("COINADD");
    //    Coin += 30;
    //}

    private void Update()
    {
        currentTime += Time.deltaTime;
        if(currentTime > span)
        {
            currentTime = 0f;
            Coin += 1;
        }


        //�����̕`��
        time += Time.deltaTime;
        if(time >= maXtime)
        {
            CoinText.text = Coin.ToString();
        }

        // �}�E�X�̍��N���b�N�������ꂽ��
        //if (Input.GetMouseButtonDown(0))
        //{
        //    // �}�E�X�̃X�N���[�����W��Ray�ɕϊ�
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hit;

        //    // Ray���I�u�W�F�N�g�ɓ����������`�F�b�N
        //    if (Physics.Raycast(ray, out hit))
        //    {
        //        // Ray�����������ʒu�ɃI�u�W�F�N�g�𐶐�
        //        Instantiate(objectPrefab, hit.point, Quaternion.identity);
        //    }
        //}
    }
}