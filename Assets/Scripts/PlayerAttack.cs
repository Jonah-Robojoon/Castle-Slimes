using System;
using UnityEngine;

public class PlayerAttack : MonoBehaviour
{
    public GameObject Collider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log("collided");
    }

}
