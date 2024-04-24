using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectInteraction : MonoBehaviour
{
    public bool equiped = false;
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
           itemHeld = Instantiate(other, ground.transform.position, Quaternion.identity);
           
           itemHeld.transform.SetParent(hand);
           itemHeld.transform.position = hand.position;
           itemHeld.transform.localScale = new Vector3(0.3f, 0.3f, 0.3f);
           equiped = true;
           Destroy(other);
       }
   
    }
    public void Drop()
    {
       if(equiped && Input.GetKey(KeyCode.F))
       {
           GameObject newItemDrop = Instantiate(itemHeld, ground.transform.position, Quaternion.identity);
           Destroy(itemHeld);
           equiped = false;
       }
    }
}
