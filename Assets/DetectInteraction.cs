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
    public bool drop = false;
    Enemy enemy;
    public GameObject masterKey;
    public int enemyDied = 1;
    void Start()
    {
        enemy = FindObjectOfType<Enemy>();
    }
    void Update()
    {
        Drop();
        if(enemy==null && enemyDied == 1)
        {
            masterKey.transform.position = ground.transform.position;
            masterKey.SetActive(true);
            enemyDied = 0;
        }
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
           drop = false; 
           itemHeld = Instantiate(other, ground.transform.position, Quaternion.identity);
           itemHeld.name = other.name;
           itemHeld.transform.SetParent(hand);
           itemHeld.transform.position = hand.position;
           //itemHeld.transform.localScale = new Vector3(1f, 1f, 1f);
           itemHeld.transform.rotation = other.transform.rotation;
           itemHeld.transform.localScale = other.transform.localScale;
           equiped = true;
           item = other.gameObject.name;
           Destroy(other);
       }
   
    }
    public void Drop()
    {
       if(equiped && Input.GetKey(KeyCode.F))
       {
           drop = true; 
           GameObject newItemDrop = Instantiate(itemHeld, ground.transform.position, Quaternion.identity);
           newItemDrop.name = itemHeld.name;
           newItemDrop.transform.rotation = itemHeld.transform.rotation;
           Destroy(itemHeld);
           equiped = false;
           item = "";
       }
    }
    public string ItemName()
    {
        return item; 
    }
    public bool getDrop()
    {
        return drop;
    }
}
