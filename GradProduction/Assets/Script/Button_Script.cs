using UnityEngine;
using UnityEngine.UI;

public class Button_Script : MonoBehaviour
{
    public GameObject towerPrefab; // TowerTest�̃v���n�u
    public Button_Delete deleteScript; // Button_Delete�̃X�N���v�g�ւ̎Q��
    private bool towerSpawned = false;
    private GameObject spawnedTower; // ���������^���[�̎Q��

    //�R�C������
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
        // �{�^���ɃN���b�N���̏�����ǉ�
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(OnButtonClick);

        CoinScript = GameObject.Find("CoinNumSystem");
        BuyCoin = CoinScript.GetComponent<Coin_Script>();
    }

    private void Update()
    {

    }

    // �{�^�����N���b�N���ꂽ�Ƃ��ɌĂяo�����֐�
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
            // �^���[���폜���ꂽ�̂ŁA�t���O�����Z�b�g
            towerSpawned = false;
        }
    }

    // �w�肳�ꂽ���W�Ƀ^���[���X�|�[������֐�
    private void SpawnTowerAtPosition(Vector3 position)
    {
        spawnedTower = Instantiate(towerPrefab, position, Quaternion.identity);
    }

    private void Spawnflg()
    {
        SpawnTowerAtPosition(new Vector3(83.5f, 4.0f, 92.0f));
        deleteScript.towerToDelete = spawnedTower; // ���������^���[�̎Q�Ƃ� Button_Delete �X�N���v�g�� towerToDelete �ϐ��ɐݒ�
        Debug.Log("towerToDelete�ϐ��Ƀ^���[�Q��");
        towerSpawned = true; // �X�|�[���ς݃t���O��ݒ�
    }
}