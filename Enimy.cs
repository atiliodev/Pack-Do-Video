using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

[RequireComponent(typeof(NavMeshAgent))]
public class Enimy : MonoBehaviour
{
    private NavMeshAgent agent;
    private Animator anim;
    public Transform target;
    Vector3 direction;
    float debug;
    public PlayerControler player;

    private void Start()
    {
        anim = GetComponent<Animator>();
        agent = GetComponent<NavMeshAgent>();
    }

    private void Update()
    {
        SetTarget();
        SetDirection();
        SetDano();
    }

    void SetTarget()
    {
        if (target != null)
            agent.SetDestination(target.position);
    }

    void SetDirection()
    {
        direction = agent.desiredVelocity;
        anim.SetFloat("posX", direction.magnitude);
    }

    void SetDano()
    {
        anim.SetFloat("ataque", debug);
        player.SetAtaque(debug);
    }

    private void OnTriggerEnter(Collider other)
    {
        switch (other.gameObject.tag)
        {
            case "Player":
                debug = 1;
                break;
        }
    }
    private void OnTriggerExit(Collider other)
    {
        debug = 0;
    }

}
