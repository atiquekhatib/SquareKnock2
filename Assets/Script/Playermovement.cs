using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Playermovement : MonoBehaviour
{
    public Vector2 turn;
    public int r;
    public CharacterController controller;
    public float speed = 6f;
    public float gravity;
    Vector3 velocity;
    void Update()
    {
        playermove();
        playerrotate();
        playergravity();
    }

    void playergravity()
    {
        velocity.y += gravity * Time.deltaTime;
        controller.Move(velocity*Time.deltaTime);
    }

    void playermove()
    {
        float horizontal = Input.GetAxisRaw("Horizontal");
        float vertical = Input.GetAxisRaw("Vertical");
        Vector3 direction = new Vector3(horizontal,0f,vertical).normalized;

        if(direction.magnitude >= 0.1f)
        {
            controller.Move(direction * speed * Time.deltaTime);
        }

    }

    void playerrotate()
    {
        //horizontal
        turn.x += Input.GetAxis("Mouse X");
        transform.localRotation = Quaternion.Euler(0,turn.x * r,0);
        turn.x += Input.GetAxis("Mouse Y");
        transform.localRotation = Quaternion.Euler(0,turn.x * r,0);
    }
}
