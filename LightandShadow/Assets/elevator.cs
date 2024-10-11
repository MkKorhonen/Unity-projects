using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class elevator : MonoBehaviour
{
    float dirX;
    bool moveRight = true;
    public float moveSpeed;
    public float rm;
    public float lm;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        
        
    }
    
    void OnCollisionStay2D(Collision2D col)
    {
        if(col.gameObject.tag.Equals ("Player"))
        {
            if(transform.position.x > rm)
            {
                moveRight = false;
            }
            if(transform.position.x < lm)
            {
                moveRight = true;
            }
            if(moveRight)
            {
                transform.position = new Vector2(transform.position.x + moveSpeed * Time.deltaTime, transform.position.y);
            }
            else
            {
                transform.position = new Vector2(transform.position.x - moveSpeed * Time.deltaTime, transform.position.y);
            }
        }
    }
}
