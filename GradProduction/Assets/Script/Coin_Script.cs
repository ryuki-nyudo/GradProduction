using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Coin_Script : MonoBehaviour
{
    // Start is called before the first frame update
  
    //public GameObject objectPrefab; // 設置するオブジェクトのプレハブ
                                    // Update is called once per frame

    //描画時間
    float maXtime, time;
    public Text CoinText;
    public int Coin;

    private void Start()
    {
        Coin = 0;
        CoinText.text = Coin.ToString();
        maXtime = 0.5f;
        time = 0.0f;
    }

    private void Update()
    {
        //枚数の描画
        time += Time.deltaTime;
        if(time >= maXtime)
        {
            CoinText.text = Coin.ToString();
        }

        // マウスの左クリックが押されたら
        //if (Input.GetMouseButtonDown(0))
        //{
        //    // マウスのスクリーン座標をRayに変換
        //    Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        //    RaycastHit hit;

        //    // Rayがオブジェクトに当たったかチェック
        //    if (Physics.Raycast(ray, out hit))
        //    {
        //        // Rayが当たった位置にオブジェクトを生成
        //        Instantiate(objectPrefab, hit.point, Quaternion.identity);
        //    }
        //}
    }
}