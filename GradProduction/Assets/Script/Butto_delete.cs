using UnityEngine;
using UnityEngine.UI;

public class Butto_delete : MonoBehaviour
{
    // kabe_delete�{�^�����N���b�N���ꂽ�Ƃ��ɌĂяo�����֐�
    public void OnDeleteButtonClick()
    {
        // �^���[�����݂��邩�`�F�b�N
        GameObject tower = GameObject.FindWithTag("Tower");
        if (tower != null)
        {
            // �^���[�����݂���΍폜
            Destroy(tower);
        }
    }
}