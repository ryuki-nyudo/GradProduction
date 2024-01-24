using UnityEngine;
using UnityEngine.UI;

public class Button_Delete : MonoBehaviour
{
    public GameObject towerToDelete; // �폜����^���[�̎Q��

    void Start()
    {
        // �{�^���ɃN���b�N���̏�����ǉ�
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(OnButtonClick);
    }

    // �{�^�����N���b�N���ꂽ�Ƃ��ɌĂяo�����֐�
    private void OnButtonClick()
    {
        if (towerToDelete != null)
        {
            Debug.Log("��������-");

            // �^���[�̃C���X�^���X�𑦍��ɍ폜
            DestroyImmediate(towerToDelete, true);
        }
    }
}