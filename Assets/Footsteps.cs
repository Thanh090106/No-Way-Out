using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Footsteps : MonoBehaviour
{
    public AudioSource footstepsSound, sprintSound;
    
    void Update()
    {
        if(Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.D) || Input.GetKey(KeyCode.S))
        {
            footstepsSound.enabled = true;
            if(Input.GetKeyUp(KeyCode.LeftShift))
            {
                footstepsSound.enabled = false; 
                sprintSound.enabled = true;
            }
        }
        else
        {
            footstepsSound.enabled = false; 
        }
    }

    
    
}
