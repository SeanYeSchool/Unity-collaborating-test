using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Print0to100 : MonoBehaviour
{
    //successful programe that was written on the desktop computer
    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < 101; i++)
        {
            Debug.Log("i =" + i);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
