using UnityEngine;
using System.Collections;
using UnityEngine.AI;

public class Slime : MonoBehaviour
{
    private NavMeshAgent agent;
    [SerializeField]private Transform target;
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        //   GO = GetComponent<GameObject>();
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(target.position);

    }
}
