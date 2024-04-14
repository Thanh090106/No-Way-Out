using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Raycast : MonoBehaviour
{
    // Start is called before the first frame update
    PickUp pickUp;
    
    void Start()
    {
        pickUp = FindObjectOfType<PickUp>();
    }
    [SerializeField] private float maxDistance = 1f;
    InteractionObject hit = null;
    // Update is called once per frame
    void Update()
    {
        Vector3 origin = Camera.main.transform.position;
        Vector3 direction = Camera.main.transform.forward;
        RaycastHit raycastHit = new RaycastHit();
        if(Physics.Raycast(origin, direction, out raycastHit, maxDistance))
        {
            hit = raycastHit.collider.gameObject.GetComponent<InteractionObject>();
        }
        if(hit)
        {
            pickUp.Pick();
        }
        pickUp.Drop();
    }
}
