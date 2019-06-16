using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LivingEntity : MonoBehaviour, IDamageable
{
    public float startingHealth;
    public float health; // it also could be protected, if it doesnt work.
    protected bool dead;

    public AudioClip enemyDieAudio;
    public AudioSource enemyAudioSource;

    protected virtual void Start()
    {
        health = startingHealth;
    }

    public void TakeHit(float damage, RaycastHit hit)
    {
        health -= damage;

        if (health <= 0 && !dead)
        {
            enemyAudioSource.enabled = true;
            enemyAudioSource.clip = enemyDieAudio;
            enemyAudioSource.Play();
            Die();
            //FindObjectOfType<GameManager_UI>().EndGame();
            //SceneManager.LoadScene(2);
        }
    }

    protected void Die()
    {
        dead = true;
       // GameObject.Destroy(gameObject);

    }
}
