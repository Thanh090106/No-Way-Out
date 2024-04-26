using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
public class Events : MonoBehaviour
{
    public UnityEvent testEvent = new UnityEvent();
    public bool inside = false;
    // Start is called before the first frame update
    void Start()
    {
        testEvent.AddListener(TestListener);
        
    }

    // Update is called once per frame
    void Update()
    {
        if(inside && Input.GetKeyDown(KeyCode.E))
        {
            testEvent.Invoke();
        }
    }
    void TestListener()
    {
        print("test listener called");
    }
    void OnTriggerEnter(Collider other)
    {
        inside = true;
    }
    void OnTriggerExit(Collider other)
    {
        inside = false;
    }
}
