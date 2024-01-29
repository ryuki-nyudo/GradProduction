using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BDelete : MonoBehaviour
{
    //ƒ{ƒ^ƒ“
    public GameObject BSelect;
    public GameObject BArcher, BArcherDelete;
    public GameObject BWizard, BWizardDelete;

    // Start is called before the first frame update
    void Start()
    {
        Button btn = GetComponent<Button>();
        btn.onClick.AddListener(OnButtonClick);
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnButtonClick()
    {
        BSelect.SetActive(true);
        BArcher.SetActive(false);
        BArcherDelete.SetActive(false);
        BWizard.SetActive(false);
        BWizardDelete.SetActive(false);
        gameObject.SetActive(false);
    }
}
