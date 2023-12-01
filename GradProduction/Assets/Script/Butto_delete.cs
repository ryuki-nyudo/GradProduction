using UnityEngine;
using UnityEngine.UI;

public class Butto_delete : MonoBehaviour
{
    // kabe_deleteボタンがクリックされたときに呼び出される関数
    public void OnDeleteButtonClick()
    {
        // タワーが存在するかチェック
        GameObject tower = GameObject.FindWithTag("Tower");
        if (tower != null)
        {
            // タワーが存在すれば削除
            Destroy(tower);
        }
    }
}