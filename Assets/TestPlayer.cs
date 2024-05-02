using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class TestPlayer : MonoBehaviour
{
    public float playerHealth = 1000f;

    public GameObject m_GotHitScreen; 

    private bool attackMode = false; 
    private bool RedIncrease = false; 

    
    // Start is called before the first frame update
    void Start()
    {
       
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.K))
        {
            attackMode = true;
            RedIncrease = true;
            print("true");
        }

        if (Input.GetKeyDown(KeyCode.P))
        {
            RedIncrease = false; 
            print("false");
        }

        if(playerHealth<=0)
        {
            Application.LoadLevel("PlayAgain");
            playerHealth = 1000f;
        }
        if(attackMode)
        {
            if(RedIncrease)
            {
                var color = m_GotHitScreen.GetComponent<Image>().color;
                color.a += 0.01f;
                m_GotHitScreen.GetComponent<Image>().color = color; 
            }
            else
            {
                var color = m_GotHitScreen.GetComponent<Image>().color;
                color.a -= 0.01f;
                m_GotHitScreen.GetComponent<Image>().color = color;
                if(color.a <= 0)
                {
                    attackMode = false; 
                }
                
            }
            
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

    void OnTriggerEnter()
    {
        // add check to see if we are colliding with the enemy
        attackMode = true; 
        RedIncrease = true; 
    }

    void OnTriggerExit()
    {
        RedIncrease = false;
    }
}





