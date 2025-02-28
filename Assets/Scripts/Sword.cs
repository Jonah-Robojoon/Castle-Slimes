using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{

    Animator m_Animator;
    bool Move;
    bool Swing;

    public bool AllowSwing = true;

    public GameObject SwordCollider;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        m_Animator = gameObject.GetComponent<Animator>();

        SwordCollider.SetActive(false);

    }
    
    void FixedUpdate()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        if (moveVertical != 0)
        {
            m_Animator.SetBool("Move", true);
        }
        else
        {
            m_Animator.SetBool("Move", false);
        }
    }


    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0) && AllowSwing)
        {

            StartCoroutine(SwordSwing());

        }
    }
    
    IEnumerator SwordSwing()
    {
        AllowSwing = false;
        m_Animator.Play("Sword Swing");
        yield return new WaitForSeconds(0.2f);
        SwordCollider.SetActive(true);
        yield return new WaitForSeconds(0.1f);
        SwordCollider.SetActive(false);
        yield return new WaitForSeconds(1.7f);
        m_Animator.Play("Sword Idle");
        AllowSwing = true;
        
    }
}