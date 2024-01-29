using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BObj : MonoBehaviour
{
    public GameObject BSelect, BDelete, BSwitch;
    public bool Archerflg, Wizardflg, Objflg;
    public GameObject towerPrefab; // TowerTest�̃v���n�u
    private GameObject spawnedTower; // ���������^���[�̎Q��
    public Button deleteObj;
    public BObjDelete DelObj;
    Vector3 CPosition;

    //�R�C������
    GameObject CoinScript;
    Coin_Script BuyCoin;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(OnButtonClick);

        if (gameObject.CompareTag("Archer"))
        {
            towerPrefab = (GameObject)Resources.Load("Lv1");
        }
        else if (gameObject.CompareTag("Magic"))
        {
            towerPrefab = (GameObject)Resources.Load("WzLv1");
        }

        Archerflg = false;
        Wizardflg = false;
        Objflg = false;

        Bselect CreatePosition = BSelect.GetComponent<Bselect>();
        if (CreatePosition != null)
        {
            CPosition = CreatePosition.ObjPosition;
        }

        CoinScript = GameObject.Find("CoinNumSystem");
        BuyCoin = CoinScript.GetComponent<Coin_Script>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Wizardflg == true || Archerflg == true)
        {
            Objflg = true;
            //Debug.Log("���z�ł��܂���");
            Debug.Log("Wizard��" + Wizardflg);
        }
        else if (Wizardflg == false && Archerflg == false)
        {
            Objflg = false;
            //Debug.Log("���z�ł��܂�");
        }
    }

    private void OnButtonClick()
    {
        //if (Objflg == false)
        //{
        if (gameObject.CompareTag("Archer") && BuyCoin.Coin >= 60)
        {
            BuyCoin.Coin -= 60;
            Spawnflg();
            Archerflg = true;
        }
        if (gameObject.CompareTag("Magic") && BuyCoin.Coin >= 90)
        {
            BuyCoin.Coin -= 90;
            Spawnflg();
            Wizardflg = true;
        }

        BSelect.SetActive(true);
        BDelete.SetActive(false);
        BSwitch.SetActive(false);
        gameObject.SetActive(false);

    }


    private void SpawnTowerAtPosition(Vector3 position)
    {
        spawnedTower = Instantiate(towerPrefab, position, Quaternion.identity);
    }

    private void Spawnflg()
    {
        SpawnTowerAtPosition(CPosition);
        DelObj.towerToDelete = spawnedTower; // ���������^���[�̎Q�Ƃ� Button_Delete �X�N���v�g�� towerToDelete �ϐ��ɐݒ�
    }
}
