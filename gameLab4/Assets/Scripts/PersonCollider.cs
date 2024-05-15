using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonCollider : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource audiosource;
    int numApplesDestroyed = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }


    // when apple collides with person
    void OnTriggerEnter(Collider collision) {
        Destroy(collision.gameObject); 
        numApplesDestroyed += 1;
        Debug.Log("Destorying apple: " + numApplesDestroyed);
        audiosource.PlayOneShot(clip, .5f);
    }

    // Update is called once per frame
    void Update()
    {
       
    }
}
