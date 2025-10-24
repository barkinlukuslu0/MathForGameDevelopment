using System;
using UnityEngine;

public class SetBits : MonoBehaviour
{
    int bSequences = 16;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Debug.Log(Convert.ToString(bSequences, 2));
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
