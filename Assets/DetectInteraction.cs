using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectInteraction : MonoBehaviour
{
    public bool equiped = false;
    public string item = "";
    public GameObject ground;
    GameObject itemHeld = null;
    public Transform hand;
    void Update()
    {
        Drop();
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.GetComponent<InteractionObject>())
        {
            Pick(other.gameObject);
        }
    }
    public void Pick(GameObject other)
    {
       if(!equiped && Input.GetKey(KeyCode.E))
       {
           other.transform.rotation = Quaternion.identity;
           itemHeld = Instantiate(other, ground.transform.position, Quaternion.identity);
           itemHeld.name = other.name;
           itemHeld.transform.SetParent(hand);
           itemHeld.transform.position = hand.position;
           itemHeld.transform.localScale = new Vector3(1f, 1f, 1f);
           itemHeld.transform.localRotation = Quaternion.identity;
           equiped = true;
           item = other.gameObject.name;
           Destroy(other);
       }
   
    }
    public void Drop()
    {
       if(equiped && Input.GetKey(KeyCode.F))
       {
           GameObject newItemDrop = Instantiate(itemHeld, ground.transform.position, Quaternion.identity);
           newItemDrop.name = itemHeld.name;
           Destroy(itemHeld);
           equiped = false;
           item = "";
       }
    }
    public string ItemName()
    {
        return item; 
    }
}
