using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Grab : MonoBehaviour
{
    public bool equiped = false;
    public GameObject item;
    public GameObject tempItem;
    public GameObject ground;
    GameObject instantiateObj = null;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
     public void Pick()
    {
       if(!equiped && Input.GetKey(KeyCode.E))
       {
            if(instantiateObj != null)
            {
                Destroy(instantiateObj);
            }
           item.SetActive(true);
           Destroy(tempItem);
           equiped = true;
           
       }
   
    }
    public void Drop()
    {
       if(equiped && Input.GetKey(KeyCode.F))
       {
           item.SetActive(false);
           instantiateObj = Instantiate(item, ground.transform.position, Quaternion.identity);
           instantiateObj.SetActive(true);
           equiped = false;
           
       }
    }
}
