using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        // Destroying the object when start a game
        Destroy(gameObject);
        print("[+] Object is destroyd!");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
