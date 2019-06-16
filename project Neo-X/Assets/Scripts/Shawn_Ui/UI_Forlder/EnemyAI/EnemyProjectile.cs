using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyProjectile : MonoBehaviour
{
    public LayerMask collisionMask;
    float speed = 10;
    float damage = 1;
    private GameObject target;

    public AudioClip playerHitAudio;
    public AudioSource playerAudioSource;

    public void SetSpeed(float newSpeed)
    {
        speed = newSpeed;
    }

    void Update()
    {
        float moveDistance = speed * Time.deltaTime;
        //CheckCollisions(moveDistance);
        transform.Translate(Vector3.forward * moveDistance);
    }


    //void CheckCollisions(float moveDistance)
    //{
    //    Ray ray = new Ray(transform.position, transform.forward);
    //    RaycastHit hit;

    //    if (Physics.Raycast(ray, out hit, moveDistance, collisionMask, QueryTriggerInteraction.Collide))
    //    {
    //        OnHitObject(hit);
    //        print(HealthBar.health);
    //    }
    //}
    private void OnTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
            target = other.gameObject;
            target.GetComponent<Player>().health -= damage;
            HealthBar.health -= 1f;
            Destroy(this.gameObject);

            playerAudioSource.enabled = true;
            playerAudioSource.clip = playerHitAudio;
            playerAudioSource.Play();
        }
    }
    //void OnHitObject(RaycastHit hit)
    //{
    //    HealthBar.health -= 1f;
    //    IDamageable damageableObject = hit.collider.GetComponent<IDamageable>();
    //    if (damageableObject != null)
    //    {
    //        damageableObject.TakeHit(damage, hit);
    //    }
    //    GameObject.Destroy(gameObject);
    //}
}
