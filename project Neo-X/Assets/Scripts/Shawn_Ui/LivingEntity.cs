using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LivingEntity : MonoBehaviour, IDamageable
{
    public float startingHealth;
    public float health; // it also could be protected, if it doesnt work.
    protected bool dead;

    public AudioClip enemyHitAudio;
    public AudioClip enemyDieAudio;
    public AudioSource enemyAudioSource;
    public Animator animator;

    protected virtual void Start()
    {
        health = startingHealth;
        animator = this.gameObject.GetComponent<Animator>();
    }

    public void TakeHit(float damage, RaycastHit hit)
    {
        health -= damage;

        enemyAudioSource.enabled = true;
        enemyAudioSource.clip = enemyHitAudio;
        enemyAudioSource.Play();

        if (health <= 0 && !dead)
        {
            Invoke("Die", 2f);

            enemyAudioSource.enabled = true;
            enemyAudioSource.clip = enemyDieAudio;
            enemyAudioSource.Play();
        }
    }


    protected void Die()
    {
        if (animator != null)
        {
            animator.SetBool("isDead", true);
        }

        dead = true;
        GameObject.Destroy(gameObject);
    }
}
        