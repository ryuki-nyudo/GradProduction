using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Position : MonoBehaviour
{
    public Vector3 Position;
    public int CreatePosition;
    // Start is called before the first frame update
    void Start()
    {
        Position = new Vector3(0.0f, 0.0f, 0.0f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnButtonClick()
    {
        if (CreatePosition == 1)
        {
            Position = new Vector3(83.5f, 4.0f, 92.0f);
        }
        else if(CreatePosition == 2)
        {
            Position = new Vector3(100.0f, 4.0f, 50.0f);
        }
    }
}
