using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    public bool equiped = false;
    public Transform item; 
    public Transform hand; 
    Rigidbody rb; 
    
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Pick()
    {
       if(!equiped && Input.GetKey(KeyCode.E)) 
       {
           item.SetParent(hand);
           equiped = true;
           rb.useGravity = false;
       }
    
    }
    public void Drop()
    {
       if(equiped && Input.GetKey(KeyCode.F)) 
       {
           rb.useGravity = true;
           hand.DetachChildren();
           equiped = false;
       }
    }
    
}
