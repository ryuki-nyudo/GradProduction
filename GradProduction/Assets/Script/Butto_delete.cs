using UnityEngine;
using UnityEngine.UI;

public class Button_Delete : MonoBehaviour
{
    public GameObject towerToDelete; // 削除するタワーの参照

    void Start()
    {
        // ボタンにクリック時の処理を追加
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(OnButtonClick);
    }

    // ボタンがクリックされたときに呼び出される関数
    private void OnButtonClick()
    {
        // タワーが存在し、まだ削除されていない場合
        if (towerToDelete != null)
        {
            Destroy(towerToDelete); // タワーを削除
        }
    }
}