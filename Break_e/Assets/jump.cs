using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class jump : MonoBehaviour
{
    public KeyCode key;
    private bool canJump;
    

    private void OnCollisionEnter(Collision other)
    {
        canJump = true;
    }
    
    void Update()
    {
     if(Input.GetKeyDown(key))
     {
         if (canJump == true)
         {
             gameObject.transform.position = new Vector3(gameObject.transform.position.x, gameObject.transform.position.y + 2, gameObject.transform.position.z);
             canJump = false;
         }
         
     }    
    }
}
