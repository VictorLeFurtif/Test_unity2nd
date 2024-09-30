using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color : MonoBehaviour
{
    [SerializeField]
    private GameObject cube;
    [SerializeField]
    private KeyCode key;
    void Update()
    {
        if (Input.GetKey(key))
        {
            cube.GetComponent<Renderer>().material.color = UnityEngine.Color.red;
        }
        else
        {
            cube.GetComponent<Renderer>().material.color = UnityEngine.Color.white;
        }
    }
}
