using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class opendoor : MonoBehaviour
{
    private GameObject Door;
    public string KeyT;
    public string GateT;
    public AudioClip MusicClip;
    public AudioSource MusicSource;
    // Start is called before the first frame update
    void Start()
    {
        MusicSource.clip = MusicClip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
            MusicSource.Play();
            Door = GameObject.FindGameObjectWithTag(GateT);
            Destroy(Door);
            Door = GameObject.FindGameObjectWithTag(KeyT);
            Destroy(Door);
            
        }
        
    }
}
