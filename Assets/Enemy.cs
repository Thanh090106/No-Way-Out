
using UnityEngine;

public class Enemy : MonoBehaviour
{

    private Transform target; 
    public float speed; 
   
    
    // Start is called before the first frame update
    void Start()
    {
        target= GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        
    }
}
