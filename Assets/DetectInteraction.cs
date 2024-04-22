using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectInteraction : MonoBehaviour
{
    public bool equiped = false;
    public GameObject ground;
    GameObject handObj = null;
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
           handObj = Instantiate(other, ground.transform.position, Quaternion.identity);
           handObj.transform.position = Vector3.zero;
           hand.localScale = Vector3.one;
           handObj.transform.SetParent(hand);
           equiped = true;
           Destroy(other);
       }
   
    }
    public void Drop()
    {
       if(equiped && Input.GetKey(KeyCode.F))
       {
           handObj.transform.SetParent(null);
           handObj.transform.position = Vector3.zero;
           hand.localScale = Vector3.one;
           Instantiate(handObj, ground.transform.position, Quaternion.identity);
           Destroy(handObj);
           equiped = false;
           
       }
    }
}
