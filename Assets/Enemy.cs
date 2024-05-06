

using UnityEngine;
using UnityEngine.AI;
public class Enemy : MonoBehaviour
{
    public Transform target;
    private NavMeshAgent enemy;
    public GameObject masterKey; 
   
   
    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
    }


    // Update is called once per frame
    void Update()
    {
        enemy.SetDestination(target.position);
    }
    private void OnTriggerStay(Collider other)
    {
        if (other.CompareTag("Cross"))
        {
            Destroy(gameObject);
        }
    }

    
}



