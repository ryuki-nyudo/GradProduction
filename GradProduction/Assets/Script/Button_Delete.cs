using UnityEngine;
using UnityEngine.UI;

public class Button_Delete : MonoBehaviour
{
    public GameObject towerToDelete; // �폜����^���[�̎Q��

    //�R�C������
    GameObject CoinScript;
    Coin_Script BuyCoin;

    void Start()
    {
        // �{�^���ɃN���b�N���̏�����ǉ�
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(OnButtonClick);

        CoinScript = GameObject.Find("CoinNumSystem");
        BuyCoin = CoinScript.GetComponent<Coin_Script>();
    }

    // �{�^�����N���b�N���ꂽ�Ƃ��ɌĂяo�����֐�
    private void OnButtonClick()
    {
        if (towerToDelete != null)
        {
            Debug.Log("��������-");
            if (gameObject.CompareTag("Archer"))
            {
                BuyCoin.Coin += 30;
            }
            else if (gameObject.CompareTag("Magic"))
            {
                BuyCoin.Coin += 45;
            }
            // �^���[�̃C���X�^���X�𑦍��ɍ폜
            DestroyImmediate(towerToDelete, true);
        }
    }
}