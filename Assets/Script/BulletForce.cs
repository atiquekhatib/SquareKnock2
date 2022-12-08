using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletForce : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody rb;
    void Start()
    {
        rb.velocity = transform.forward * speed;
        //rb.velocity = transform.position.z * speed;
    }

    void Update()
    {
        Invoke("destorybullet",2f);
    }

    void destorybullet()
    {
        Destroy(gameObject);
    }

    void OnCollisionEnter(Collision other) 
    {
    if(other.gameObject.tag == "Enemy")
        {
            Destroy(gameObject);
        } 
    }

}
