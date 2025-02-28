using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.Antlr3.Runtime.Tree;
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

    // collision check
    void OnCollisionStay(){
        isGrounded = true;
    }

    void FixedUpdate()
    {

    
    }

        void Update(){

        // get input
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");
        // move player
        transform.position += transform.forward * moveVertical * speed * Time.deltaTime;
        transform.position += transform.right * moveHorizontal * speed * Time.deltaTime;



        // mouse movements X <---->
        turn.x += Input.GetAxis("Mouse X") * 7;
        transform.localRotation = Quaternion.Euler(0, turn.x, 0);


        // jump
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded){

            rb.AddForce(jump * 3.5f, ForceMode.Impulse);
            isGrounded = false;

        }
    }
}
