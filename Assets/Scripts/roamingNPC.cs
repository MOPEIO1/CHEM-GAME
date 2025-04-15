using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;


public class roamingNPC : MonoBehaviour
{
    public float roamRadius = 10f;
    public float pauseTime = 2f;


    private NavMeshAgent agent;
    private Vector3 startPosition;
    private float pauseTimer = 0f;
    private bool isPaused = false;


    void Start()
    {
        agent = GetComponent<NavMeshAgent>();
        startPosition = transform.position;
        GoToNewPosition();
    }


    void Update()
    {
        if (!agent.pathPending && agent.remainingDistance <= agent.stoppingDistance)
        {
            if (!isPaused)
            {
                isPaused = true;
                pauseTimer = pauseTime;
            }
        }


        if (isPaused)
        {
            pauseTimer -= Time.deltaTime;
            if (pauseTimer <= 0f)
            {
                isPaused = false;
                GoToNewPosition();
            }
        }
    }


    void GoToNewPosition()
    {
        Vector3 randomDirection = Random.insideUnitSphere * roamRadius;
        randomDirection += startPosition;


        if (NavMesh.SamplePosition(randomDirection, out NavMeshHit hit, roamRadius, NavMesh.AllAreas))
        {
            agent.SetDestination(hit.position);
        }
    }
}
