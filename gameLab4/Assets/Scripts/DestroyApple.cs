using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyApple : MonoBehaviour
{
    public AudioClip clip;
    public AudioSource audiosource;
    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position.y <= 0) {
            audiosource.PlayOneShot(clip, .1f);
            Destroy(this.gameObject,5);
        }
    }
}
