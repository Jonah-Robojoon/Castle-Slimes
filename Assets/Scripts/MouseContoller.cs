using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class MouseContoller : MonoBehaviour
{

    public Vector2 turn;


    void Update()
    {
        turn.y += Input.GetAxis("Mouse Y") * 7;
        transform.localRotation = Quaternion.Euler(-turn.y, 0, 0);
    }
}
