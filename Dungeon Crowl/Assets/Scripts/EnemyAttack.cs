using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour {

    public float TimeBetweenAttacks = 0.5f;
    public int attackDamage = 1;

    GameObject Player;
    PlayerHealth _playerHP;
    EnemyHealth _enemyHP;
    bool playerInRange;
    float timer;

	// Use this for initialization
	void Awake ()
    {
        Player = GameObject.FindGameObjectWithTag("Player");
        _playerHP = Player.GetComponent<PlayerHealth>();
        _enemyHP = GetComponent<EnemyHealth>();
	}

    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject == Player)
        {
            playerInRange = true;
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject == Player)
        {
            playerInRange = false;
        }
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= TimeBetweenAttacks && playerInRange  && _enemyHP.currentHealth > 0 )
        {
            Attack();
        }
    }

    void Attack()
    {
        timer = 0f;

        if(_playerHP.CurrentHealth > 0 )
        {
            _playerHP.TakeDamage(attackDamage);
        }
    }
}
