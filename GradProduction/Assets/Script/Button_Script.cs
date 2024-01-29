using UnityEngine;
using UnityEngine.UI;

public class Button_Script : MonoBehaviour
{
    public GameObject towerPrefab; // TowerTestのプレハブ
    public Button_Delete deleteScript; // Button_Deleteのスクリプトへの参照
    private bool towerSpawned = false;
    private GameObject spawnedTower; // 生成したタワーの参照

    void Start()
    {
        towerPrefab = (GameObject)Resources.Load("Lv1");
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
        if (!towerSpawned)
        {
            SpawnTowerAtPosition(new Vector3(83.5f, 4.0f, 92.0f));
            deleteScript.towerToDelete = spawnedTower; // 生成したタワーの参照を Button_Delete スクリプトの towerToDelete 変数に設定
            Debug.Log("towerToDelete変数にタワー参照");
            towerSpawned = true; // スポーン済みフラグを設定
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
}