using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI; 

public class TestPlayer : MonoBehaviour
{
    public float playerHealth = 1000f;

    public GameObject m_GotHitScreen; 

    private bool attacks = false; 

    
    // Start is called before the first frame update
    void Start()
    {
       
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetKeyDown(KeyCode.K))
        {
            attacks = true;
        }

        if (Input.GetKeyDown(KeyCode.J))
        {
            attacks = false; 
        }

        if(playerHealth<=0)
        {
            Application.LoadLevel("PlayAgain");
            playerHealth = 1000f;
        }

        if(attacks)
        {
            if(m_GotHitScreen.GetComponent<Image>.color.a > 0)
            {
                var color = m_GotHitScreen.GetComponent<Image>().color;

                color.a += 0.01f;

                m_GotHitScreen.GetComponent<Image>().color = color;
            }
        }
        else if(!attacks)
        {
            var color = m_GotHitScreen.GetComponent<Image>().color;

            color.a -= 0.01;

            m_GotHitScreen.GetComponent<Image>().color = color;
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
        attacks = true; 
    }

    void OnTriggerExit()
    {
        attacks = false;
    }
}





