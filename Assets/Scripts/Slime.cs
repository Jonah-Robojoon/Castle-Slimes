using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class Slime : MonoBehaviour
{
    private NavMeshAgent agent;
    [SerializeField]private Transform target;
    [SerializeField] float health, maxHealth = 3f;
    [SerializeField] HpBar healthBar;
    public int score = 0;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //   GO = GetComponent<GameObject>();
        health = maxHealth;
        healthBar.UpdateHealthBar(health, maxHealth);
    }

    private void Awake()
    {
        healthBar = GetComponentInChildren<HpBar>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);
        
    }
    public void TakeDamage(int damageAmount)
    {
        health -= damageAmount;
        healthBar.UpdateHealthBar(health, maxHealth);
        if (health < 0)
        {
            death();
        }
    }
    private void death()
    {
        Destroy(gameObject);
        int score =+ 100;
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Sword colider")
        {
            TakeDamage(2);
        }
    }
}
