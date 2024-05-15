using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AppleCollider : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnTriggerEnter(Collider collision) {
        Destroy(this); 
       
        Debug.Log("Destorying apple");
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
