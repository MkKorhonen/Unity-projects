using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class floorcolor : MonoBehaviour
{
    SpriteRenderer srfl;

    // Start is called before the first frame update
    void Start()
    {
        srfl = transform.GetComponent<SpriteRenderer>();
        srfl.color = new Color(255, 255, 255, 255);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space) && srfl.color == new Color(255, 255, 255, 255))
        {
            srfl.color = new Color(0, 0, 0, 255);
        }
        
        else if(Input.GetKeyDown(KeyCode.Space) && srfl.color == new Color(0, 0, 0, 255))
        {
            srfl.color = new Color(255, 255, 255, 255);
        }
    }
}
