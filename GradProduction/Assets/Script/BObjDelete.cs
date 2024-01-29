using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BObjDelete : MonoBehaviour
{
    public GameObject towerToDelete; // 削除するタワーの参照
    public GameObject BArcher, BWizard;
    public GameObject BSelect, BDelete;
    //コイン処理
    GameObject CoinScript;
    Coin_Script BuyCoin;

    void Start()
    {
        // ボタンにクリック時の処理を追加
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(OnButtonClick);

        CoinScript = GameObject.Find("CoinNumSystem");
        BuyCoin = CoinScript.GetComponent<Coin_Script>();
    }

    // ボタンがクリックされたときに呼び出される関数
    private void OnButtonClick()
    {
        if (towerToDelete != null)
        {
            if (gameObject.CompareTag("Archer"))
            {
                BuyCoin.Coin += 30;
                BArcher.GetComponent<BObj>().Archerflg = false;
                BArcher.SetActive(false);
            }
            else if (gameObject.CompareTag("Magic"))
            {
                BuyCoin.Coin += 45;
                BWizard.GetComponent<BObj>().Wizardflg = false;
                BWizard.GetComponent<BObj>().Objflg = false;
                Debug.Log("Wizardは" + BWizard.GetComponent<BObj>().Wizardflg);
                BWizard.SetActive(false);
            }
        }
        // タワーのインスタンスを即座に削除
        DestroyImmediate(towerToDelete, true);
        BSelect.SetActive(true);
        BDelete.SetActive(false);
        gameObject.SetActive(false);
    }
}
