using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour
{
    public float playerHealth = 1000f; 
   
    // Start is called before the first frame update
    void Start()
    {
       
    }


    // Update is called once per frame
    void Update()
    {
        if(playerHealth<=0)
        {
            Application.LoadLevel("PlayAgain");
            playerHealth = 1000f;
        }
        
    }
    void OnTriggerStay(Collider player)
    {
        if(player.gameObject.CompareTag("Enemy"))
        {
            playerHealth -= 10f;
            print("Health is " +playerHealth);
        }
        
    }
    
}





