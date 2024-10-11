using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class colorchange : MonoBehaviour
{
    Camera cm;

    // Start is called before the first frame update
    void Start()
    {
        cm = GetComponent<Camera>();
        cm.clearFlags = CameraClearFlags.SolidColor;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && cm.backgroundColor == new Color(0, 0, 0, 0))
        {
            cm.backgroundColor = new Color(255, 255, 255, 0);
            
        }
        else if(Input.GetKeyDown(KeyCode.Space) && cm.backgroundColor == new Color(255, 255, 255, 0))
        {
            cm.backgroundColor = new Color(0, 0, 0, 0);
        }
    }
}
