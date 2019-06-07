using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(NavMeshAgent))]
public class Enemy : LivingEntity
{

    public Transform pathHolder;

    private void OnDrawGizmos() 
    {
        Vector3 startPosition = pathHolder.GetChild(0).position;
        Vector3 previousPosition = startPosition;
        foreach(Transform waypoint in pathHolder)
        {
            Gizmos.DrawSphere(waypoint.position, 0.3f);
            Gizmos.DrawLine(previousPosition, waypoint.position);
            previousPosition = waypoint.position; 
        }
        Gizmos.DrawLine(previousPosition, startPosition);
    }


    NavMeshAgent pathfinder;
    Transform target;

    protected override void Start()
    {
        
        base.Start();

        pathfinder = GetComponent<NavMeshAgent>();
        target = GameObject.FindGameObjectWithTag("Player").transform;
        StartCoroutine(UpdatePath());
        gameObject.GetComponent<EnemyAiFollowPath>().enabled = false;
    }

    IEnumerator UpdatePath()
    {
        float refreshRate = .25f;
        
            while (target != null)
            {
                Vector3 targetPosition = new Vector3(target.position.x, 0, target.position.z);
                if (!dead)
                {
                    pathfinder.SetDestination(targetPosition);
                }
                yield return new WaitForSeconds(refreshRate);
            }
        
        
    }
}
