using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectInteraction : MonoBehaviour
{
    Grab grab;
    // Start is called before the first frame update
    void Start()
    {
        grab = FindObjectOfType<Grab>();
    }

    // Update is called once per frame
    void Update()
    {
        grab.Drop();
    }
    private void OnTriggerStay(Collider other)
    {
        if(other.gameObject.CompareTag("Item"))
        {
            grab.Pick();
        }
    }
}
