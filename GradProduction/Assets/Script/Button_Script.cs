using UnityEngine;
using UnityEngine.UI;

public class Button_Script : MonoBehaviour
{
    public GameObject towerPrefab; // TowerTest�̃v���n�u
    public Button_Delete deleteScript; // Button_Delete�̃X�N���v�g�ւ̎Q��
    private bool towerSpawned = false;

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
        {
            // �܂��^���[���X�|�[������Ă��Ȃ��ꍇ
            if (!towerSpawned)
            {
                SpawnTowerAtPosition(new Vector3(-8.25f, 4f, 61.3f));
                deleteScript.towerToDelete = towerPrefab;// Button_Delete�X�N���v�g��towerToDelete�ϐ��Ƀ^���[�̎Q�Ƃ�ݒ�
                Debug.Log("towerToDelete�ϐ��Ƀ^���[�Q��");
                towerSpawned = true; // �X�|�[���ς݃t���O��ݒ�
            }
        }
    }

    // �w�肳�ꂽ���W�Ƀ^���[���X�|�[������֐�
    private void SpawnTowerAtPosition(Vector3 position)
    {
        Instantiate(towerPrefab, position, Quaternion.identity);
    }
}