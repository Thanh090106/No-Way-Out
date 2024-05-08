using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpikeDmg : MonoBehaviour
{
    DetectInteraction detectInteraction;
    // Start is called before the first frame update
    void Start()
    {
        detectInteraction = FindObjectOfType<DetectInteraction>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider other)
    {
        if(detectInteraction.getDrop())
        {
            if(other.CompareTag("Player"))
            {
                Application.LoadLevel("PlayAgain");
            }
        }
    }
}
