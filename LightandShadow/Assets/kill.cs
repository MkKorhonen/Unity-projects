using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class kill : MonoBehaviour
{
    /*public AudioClip MusicClip;
    public AudioSource MusicSource;*/
    // Start is called before the first frame update
    void Start()
    {
        //MusicSource.clip = MusicClip;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Player"){
            Destroy(other.gameObject);
            //MusicSource.Play();
            SceneManager.LoadSceneAsync(SceneManager.GetActiveScene().buildIndex);
        }
        
    }
}
