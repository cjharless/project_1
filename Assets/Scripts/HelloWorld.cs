using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HelloWorld : MonoBehaviour
{
    int m1_frame = 0;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Hello World!");
    }

    // Update is called once per frame
    void Update()
    {
        m1_frame++;
    }
}
