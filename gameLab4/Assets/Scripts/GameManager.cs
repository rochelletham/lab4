using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public GameObject apple;
    int NUM_APPLES;  // number of apples to spawn
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("MakeApple", 3.0f, 3.0f);
    }

    /// <summary>
    /// spawns the apple in random places
    /// </summary>
    void MakeApple() {
        // Instantiate(apple, new Vector3(0,3f,0), Quaternion.identity);
        float x_pos = Random.Range(-1.0f, 1.0f);
        float z_pos = Random.Range(-1.0f, 1.0f);
        Instantiate(apple, new Vector3(x_pos, 3f, 3f+z_pos), Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
