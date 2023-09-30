using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

public class FollowPlayer : MonoBehaviour
{
   
    public NavMeshAgent agent;
    public Transform target;

    public bool isFollowing = false;

    private void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        agent.updateRotation = false;
    }
    private void Update()
    {
       if (isFollowing)
        {
            if (target != null)
            {
                agent.SetDestination(target.position);
            }
        }
        
    }
   

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            GetComponent<MeshRenderer>().material.color = Color.red;
            isFollowing = true;
            agent.SetDestination(target.position);
            Debug.Log("I will follow");
        }
    }
}