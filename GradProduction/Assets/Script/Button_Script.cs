using UnityEngine;
using UnityEngine.UI;

public class Button_Script : MonoBehaviour
{
    public GameObject towerPrefab; // TowerTestのプレハブ
    public Button_Delete deleteScript; // Button_Deleteのスクリプトへの参照
    private bool towerSpawned = false;
    private GameObject spawnedTower; // 生成したタワーの参照

    //コイン処理
    GameObject CoinScript;
    Coin_Script BuyCoin;

    void Start()
    {
        if (gameObject.CompareTag("Archer"))
        {
            towerPrefab = (GameObject)Resources.Load("Lv1");
        }
        else if (gameObject.CompareTag("Magic"))
        {
            towerPrefab = (GameObject)Resources.Load("WzLv1");
        }
        // ボタンにクリック時の処理を追加
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(OnButtonClick);

        CoinScript = GameObject.Find("CoinNumSystem");
        BuyCoin = CoinScript.GetComponent<Coin_Script>();
    }

    private void Update()
    {

    }

    // ボタンがクリックされたときに呼び出される関数
    private void OnButtonClick()
    {
        if (!towerSpawned)
        {
            if (gameObject.CompareTag("Archer") && BuyCoin.Coin >= 60)
            {
                BuyCoin.Coin -= 60;
                Spawnflg();
            }
            else if (gameObject.CompareTag("Magic") && BuyCoin.Coin >= 90)
            {
                BuyCoin.Coin -= 90;
                Spawnflg();
            }
        }
        else
        {
            // タワーが削除されたので、フラグをリセット
            towerSpawned = false;
        }
    }

    // 指定された座標にタワーをスポーンする関数
    private void SpawnTowerAtPosition(Vector3 position)
    {
        spawnedTower = Instantiate(towerPrefab, position, Quaternion.identity);
    }

    private void Spawnflg()
    {
        SpawnTowerAtPosition(new Vector3(83.5f, 4.0f, 92.0f));
        deleteScript.towerToDelete = spawnedTower; // 生成したタワーの参照を Button_Delete スクリプトの towerToDelete 変数に設定
        Debug.Log("towerToDelete変数にタワー参照");
        towerSpawned = true; // スポーン済みフラグを設定
    }
}