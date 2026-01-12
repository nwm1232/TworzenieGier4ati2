using UnityEngine;
using UnityEngine.Rendering;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float MovementDistance;
    [SerializeField] private float Speed;
    [SerializeField] private float Damage;
    private bool MovingLeft;
    private float LeftEdge;
    private float RightEdge;


    private void Awake()
    {
        LeftEdge = transform.position.x - MovementDistance;
        RightEdge = transform.position.x + MovementDistance; 
    }
    private void Update()
    {
        if (MovingLeft)
        {
            if(transform.position.x > LeftEdge)
            {
                transform.position = new Vector3(transform.position.x - Speed * Time.deltaTime, transform.position.y, transform.position.z);
            }
            else
                MovingLeft = false;
        }
        else
        {
            if(transform.position.x < RightEdge)
            {
                transform.position = new Vector3(transform.position.x + Speed * Time.deltaTime, transform.position.y, transform.position.z);
            }
            else
                MovingLeft = true;
        }

        
    }


    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.tag == "Player")
        {
            collision.GetComponent<Health>().TakeDamage(Damage);
        }
    }
}
