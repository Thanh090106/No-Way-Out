using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(Rigidbody))]


public class PickUp : MonoBehaviour
{
    public bool equiped = false;
    public Transform item;
    public Transform hand;
    Rigidbody rb;
    
    BoxCollider boxCollider;
   
    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        boxCollider = GetComponent<BoxCollider>();
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
           boxCollider.enabled = false;

       }
   
    }
    public void Drop()
    {
       if(equiped && Input.GetKey(KeyCode.F))
       {
           rb.useGravity = true;
           boxCollider.enabled = true;
           hand.DetachChildren();
           equiped = false;
       }
    }
   
}





