using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Snowball : MonoBehaviour
{
    public GameObject snowballPrefab; 
    public Transform shootPoint; 
    public float shootForce = 10f;
    public float snowLifetime = 2f;


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
}