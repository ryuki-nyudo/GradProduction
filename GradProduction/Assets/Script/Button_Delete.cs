using UnityEngine;
using UnityEngine.UI;

public class Button_Delete : MonoBehaviour
{
    public GameObject towerToDelete; // 削除するタワーの参照

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
            Debug.Log("押したよ-");
            if (gameObject.CompareTag("Archer"))
            {
                BuyCoin.Coin += 30;
            }
            else if (gameObject.CompareTag("Magic"))
            {
                BuyCoin.Coin += 45;
            }
            // タワーのインスタンスを即座に削除
            DestroyImmediate(towerToDelete, true);
        }
    }
}