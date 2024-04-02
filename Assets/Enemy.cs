
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage = 10;
    private Transform target; 
    public float speed; 
    public int getDamage()
    {
        return damage;
    }
    
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
