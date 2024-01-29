using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BObjDelete : MonoBehaviour
{
    public GameObject towerToDelete; // �폜����^���[�̎Q��
    public GameObject BArcher, BWizard;
    public GameObject BSelect, BDelete;
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
                Debug.Log("Wizard��" + BWizard.GetComponent<BObj>().Wizardflg);
                BWizard.SetActive(false);
            }
        }
        // �^���[�̃C���X�^���X�𑦍��ɍ폜
        DestroyImmediate(towerToDelete, true);
        BSelect.SetActive(true);
        BDelete.SetActive(false);
        gameObject.SetActive(false);
    }
}
