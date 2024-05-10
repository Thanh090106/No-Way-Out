

using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent enemy;
    public GameObject masterKey; 
    public int health = 100;
   
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
    }


    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(target.position);
        if(health <= 0)
        {
            Destroy(gameObject);
        }
    }
    public int GetEnemyHealth()
    {
        return health;
    }
    public void CauseDamage()
    {
        health -= 20;
    }

    
}



