using UnityEngine;
using UnityEngine.UI;

public class Button_Script : MonoBehaviour
{
    public GameObject towerPrefab; // TowerTestのプレハブ
    public Button_Delete deleteScript; // Button_Deleteのスクリプトへの参照
    private bool towerSpawned = false;

    void Start()
    {
        towerPrefab = (GameObject)Resources.Load("TowerTest");
        // ボタンにクリック時の処理を追加
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(OnButtonClick);
    }
    private void Update()
    {

    }
    // ボタンがクリックされたときに呼び出される関数
    private void OnButtonClick()
    {
        {
            // まだタワーがスポーンされていない場合
            if (!towerSpawned)
            {
                SpawnTowerAtPosition(new Vector3(-8.25f, 4f, 61.3f));
                deleteScript.towerToDelete = towerPrefab;// Button_DeleteスクリプトのtowerToDelete変数にタワーの参照を設定
                Debug.Log("towerToDelete変数にタワー参照");
                towerSpawned = true; // スポーン済みフラグを設定
            }
        }
    }

    // 指定された座標にタワーをスポーンする関数
    private void SpawnTowerAtPosition(Vector3 position)
    {
        Instantiate(towerPrefab, position, Quaternion.identity);
    }
}