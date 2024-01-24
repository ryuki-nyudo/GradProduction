using UnityEngine;
using UnityEngine.UI;

public class Button_Script : MonoBehaviour
{
    public GameObject towerPrefab; // TowerTest�̃v���n�u
    public Button_Delete deleteScript; // Button_Delete�̃X�N���v�g�ւ̎Q��
    private bool towerSpawned = false;
    private GameObject spawnedTower; // ���������^���[�̎Q��

    void Start()
    {
        towerPrefab = (GameObject)Resources.Load("TowerTest");
        // �{�^���ɃN���b�N���̏�����ǉ�
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(OnButtonClick);
    }

    private void Update()
    {

    }

    // �{�^�����N���b�N���ꂽ�Ƃ��ɌĂяo�����֐�
    private void OnButtonClick()
    {
        if (!towerSpawned)
        {
            SpawnTowerAtPosition(new Vector3(-8.25f, 4f, 61.3f));
            deleteScript.towerToDelete = spawnedTower; // ���������^���[�̎Q�Ƃ� Button_Delete �X�N���v�g�� towerToDelete �ϐ��ɐݒ�
            Debug.Log("towerToDelete�ϐ��Ƀ^���[�Q��");
            towerSpawned = true; // �X�|�[���ς݃t���O��ݒ�
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
}