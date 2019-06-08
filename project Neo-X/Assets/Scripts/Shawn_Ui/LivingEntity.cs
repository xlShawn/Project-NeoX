using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LivingEntity : MonoBehaviour, IDamageable
{
    public float startingHealth;
    protected float health;
    protected bool dead;

    protected virtual void Start()
    {
        health = startingHealth;
    }

    public void TakeHit(float damage, RaycastHit hit)
    {
        health -= damage;

        if (health <= 0 && !dead)
        {
            Die();
            //FindObjectOfType<GameManager_UI>().EndGame();
            //SceneManager.LoadScene(2);
        }
    }

    protected void Die()
    {
        dead = true;
        GameObject.Destroy(gameObject);
        
    }
}
