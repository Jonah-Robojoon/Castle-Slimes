using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRigidbodyVelocity : MonoBehaviour
{

    public Vector2 turn;
    public float speed = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        transform.position += transform.forward * moveVertical * speed * Time.deltaTime;
        transform.position += transform.right * moveHorizontal * speed * Time.deltaTime;


        // mouse movements X <---->
        turn.x += Input.GetAxis("Mouse X") * 5;
        transform.localRotation = Quaternion.Euler(0, turn.x, 0);
    }
}
