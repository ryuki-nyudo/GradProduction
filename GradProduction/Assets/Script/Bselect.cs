using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Bselect : MonoBehaviour
{
    public GameObject BArcher, BDArcher;
    public GameObject BWizard, BDWizard;
    public GameObject BDelete;

    public Vector3 ObjPosition;
    // Start is called before the first frame update
    void Start()
    {
        //Archerボタンを非表示
        if (BArcher != null)
        {
            BArcher.SetActive(false);
        }
        //Wizardボタンを非表示
        if (BWizard != null)
        {
            BWizard.SetActive(false);
        }
        //ボタン削除を非表示
        if (BDelete != null)
        {
            BDelete.SetActive(false);
        }

        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {
    }

    private void OnButtonClick()
    {
        //Objの座標
        if (gameObject.CompareTag("Create1"))
        {
            ObjPosition = new Vector3(83.5f, 4.0f, 92.0f);
        }
        else if (gameObject.CompareTag("Create2"))
        {
            ObjPosition = new Vector3(135.0f, 4.0f, 50.0f);
        }
        else if (gameObject.CompareTag("Create3"))
        {
            ObjPosition = new Vector3(175.0f, 4.0f, 100.0f);
        }

        if (BArcher.GetComponent<BObj>().Archerflg == true)
        {
            BArcher.SetActive(true);
            BDArcher.SetActive(true);
        }
        else if (BWizard.GetComponent<BObj>().Wizardflg == true)
        {
            BWizard.SetActive(true);
            BDWizard.SetActive(true);
        }
        else if (BWizard.GetComponent<BObj>().Objflg == false)
        {
            BArcher.SetActive(true);
            BWizard.SetActive(true);
        }
        BDelete.SetActive(true);
        gameObject.SetActive(false);
    }

}
