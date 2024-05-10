using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Raycast : MonoBehaviour
{
    // Start is called before the first frame update
    public float range = 100f;
    Enemy enemy;
    public ParticleSystem holySpirit;
    void Start()
    {
       
    }
    [SerializeField] private float maxDistance = 1f;
    InteractionObject hit = null;
    // Update is called once per frame
    void Update()
    {
       if(Input.GetMouseButtonDown(0))
        {
            Shoot();
            holySpirit.Play();
        }
        
    }
    public void Shoot()
    {
        Vector3 origin = Camera.main.transform.position;
        Vector3 direction = Camera.main.transform.forward;
        RaycastHit hit;
        if (Physics.Raycast(origin, direction, out hit, range))
        {
           enemy = hit.transform.GetComponent<Enemy>();
           if(enemy)
           {
             enemy.CauseDamage();
             print("Enemy health: " + enemy.GetEnemyHealth());
           }
        }
    }
}





