using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.SceneManagement;


[RequireComponent(typeof(NavMeshAgent))]
public class Enemy : LivingEntity
{

    public Transform pathHolder;
    public EnemyProjectile projectile;

    private GameObject player;
    private bool playerLocked;

    public GameObject muzzle;
    public float fireTimer;
    private bool shotReady;
    public float timeToLive;

    //public float speed;
    //public float stoppingDistance;
    //public float retreatDistance;


    //private float timeBtwShots;
    //public float startTimeBtwShots;


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
        //timeBtwShots = startTimeBtwShots;
        shotReady = true;
        Destroy(projectile, timeToLive);
    }

    private void Update()
    {
        //shooting detecting enemies;
        if (playerLocked)
        {
            transform.LookAt(target);
            if (shotReady)
            {
                Shoot();
            }
        }
        //if (Vector3.Distance(transform.position, target.position) > stoppingDistance)
        //{
        //    transform.position = Vector3.MoveTowards(transform.position, target.position, speed * Time.deltaTime);
        //}else if(Vector3.Distance(transform.position,target.position)<stoppingDistance && Vector3.Distance(transform.position, target.position) > retreatDistance)
        //{
        //    transform.position = this.transform.position;
        //}else if (Vector3.Distance(transform.position, target.position) < retreatDistance)
        //{
        //    transform.position = Vector3.MoveTowards(transform.position, target.position, -speed * Time.deltaTime);
        //}

        //if (timeBtwShots <= 0)
        //{
        //    Instantiate(projectile, transform.position, Quaternion.identity);
        //    timeBtwShots = startTimeBtwShots;
        //}
        //else
        //{
        //    timeBtwShots -= Time.deltaTime;
        //}
    }

    void Shoot()
    {
        Transform _bullet = Instantiate(projectile.transform, muzzle.transform.position, Quaternion.identity);
        _bullet.transform.rotation = muzzle.transform.rotation;
        shotReady = false;
        StartCoroutine(FireRate());
    }

    IEnumerator FireRate()
    {
        yield return new WaitForSeconds(fireTimer);
        shotReady = true;

    }

    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            player = other.gameObject;
            playerLocked = true;
        }
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
