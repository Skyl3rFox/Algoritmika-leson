using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public Transform player; 
    public float speed = 5f; 
    public int health = 4;

    void Update()
    {
        Vector3 direction = player.position - transform.position;
        direction.Normalize();
        transform.LookAt(player);
        transform.Translate(direction * speed * Time.deltaTime);
    }
    void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Snowball")) 
        {
            health--; 
            if (health == 0) 
            {
                Die(); 
            }
        }
    }

    void Die()
    {
        Destroy(gameObject); 
    }
}
