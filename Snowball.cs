using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowball : MonoBehaviour
{
    public GameObject snowballPrefab; 
    public Transform shootPoint; 
    public float shootForce = 10f; 

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            ShootSnowball();
        }
    }
    void ShootSnowball()
    {
        GameObject snowball = Instantiate(snowballPrefab, shootPoint.position, shootPoint.rotation);
        Rigidbody rb = snowball.GetComponent<Rigidbody>();
        rb.AddForce(shootPoint.forward * shootForce, ForceMode.Impulse);
    }
    void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.CompareTag("Enemy"))
        {
            Destroy(gameObject);
        }
    }
}
