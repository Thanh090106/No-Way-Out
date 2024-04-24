using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Raycast : MonoBehaviour
{
    // Start is called before the first frame update
    public float range = 100f;
   
    void Start()
    {
        
    }
    [SerializeField] private float maxDistance = 1f;
    InteractionObject hit = null;
    // Update is called once per frame
    void Update()
    {
       if(Input.GetButtonDown("Fire1"))
        {
            Shoot();
        }
        
    }
    public void Shoot()
    {
        Vector3 origin = Camera.main.transform.position;
        Vector3 direction = Camera.main.transform.forward;
        RaycastHit hit;
        if (Physics.Raycast(origin, direction, out hit, range))
        {
           Enemy enemy = hit.transform.GetComponent<Enemy>();
           if(enemy)
           {
             print("hi");
           }
        }
    }
}





