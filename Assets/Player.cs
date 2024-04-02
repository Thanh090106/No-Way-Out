using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public float playerHealth = 100; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(playerHealth<=0)
        {
            
            Destroy(gameObject);
        }
    }
    void OnTriggerStay(Collider player)
    {
        if(player.gameObject.CompareTag("Enemy"))
        {
            TakeDamage(10f);
        }
        
    }
    public void TakeDamage(float damage)
    {
        playerHealth -= damage;
    }
}
