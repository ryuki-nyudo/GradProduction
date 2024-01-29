using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Position : MonoBehaviour
{
    public Vector3 Position;
    // Start is called before the first frame update
    void Start()
    {
        if (gameObject.CompareTag("Create1"))
        {
            Position = new Vector3(83.5f, 4.0f, 92.0f);
        }
        else if (gameObject.CompareTag("Create2"))
        {
            Position = new Vector3(135.0f, 4.0f, 50.0f);
        }
        else if (gameObject.CompareTag("Create3"))
        {
            Position = new Vector3(175.0f, 4.0f, 100.0f);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    //private void OnButtonClick()
    //{
    //    if (gameObject.CompareTag("Create1"))
    //    {
    //        Position = new Vector3(83.5f, 4.0f, 92.0f);
    //    }
    //    else if(gameObject.CompareTag("Create2"))
    //    {
    //        Position = new Vector3(135.0f, 4.0f, 50.0f);
    //    }
    //    else if (gameObject.CompareTag("Create3"))
    //    {
    //        Position = new Vector3(175.0f, 4.0f, 100.0f);
    //    }
    //}
}
