using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Light_Flicker : MonoBehaviour
{
    public GameObject light; 
    public float timer = 0; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Random.Range(0,800) == 1)
        {
            light.SetActive(false);
            timer = 0.1f;
        }
        else if(timer <= 0)
        {
            light.SetActive(true);
        }
        timer -= Time.deltaTime; 
        
        
    }
}
