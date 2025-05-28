using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
public class EnemyFollowPlayer : MonoBehaviour
{
    public Transform player;
    private NavMeshAgent agent;
    
    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player").transform;
        
        
    }

    
    void Update()
    {
        if(player != null)
        {
            agent.SetDestination(player.position);
        }
    }
}
