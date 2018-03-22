using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class EnemyHealth : MonoBehaviour {

    public int startingHealth = 100;
    public int currentHealth;
    public int scoreValue = 10;

    ParticleSystem hitParticles;
    bool isDead;

    void Awake()
    {
        hitParticles = GetComponentInChildren<ParticleSystem>();

        currentHealth = startingHealth;
    }

	void TakeDamage (int amount, Vector3 hitPoint)
    {
	    if(isDead)
        {
            return;
        }

        currentHealth -= amount;
        hitParticles.transform.position = hitPoint;
        hitParticles.Play();

        if(currentHealth <= 0)
        {
            Death();
        }
	}

    void Death()
    {
        isDead = true;
        GetComponent<NavMeshAgent>().enabled = false;
        Destroy(gameObject, 1f);
    }

}
