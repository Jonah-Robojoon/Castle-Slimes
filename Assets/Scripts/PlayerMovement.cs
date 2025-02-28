using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveRigidbodyVelocity : MonoBehaviour
{

    public bool isGrounded;
    public Vector3 jump;
    public Vector2 turn;
    public float speed = 10f;
    private Rigidbody rb;

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        jump = new Vector3(0.0f, 2.0f, 0.0f);
    }

    void OnCollisionStay(){
        isGrounded = true;
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

        // jump
    
    }

        void Update(){
        if(Input.GetKeyDown(KeyCode.Space) && isGrounded){

            rb.AddForce(jump * 3.5f, ForceMode.Impulse);
            isGrounded = false;
        }
    }
}
