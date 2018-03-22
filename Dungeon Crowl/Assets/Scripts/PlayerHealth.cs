using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHealth : MonoBehaviour {

    public int StartingHealth = 5;
    public int CurrentHealth;

    bool isDead;
    bool damaged;

    CharacterMovement _charMovement;
    //PlayerShooting _playerShoot;

	void Awake ()
    {
        _charMovement = GetComponent<CharacterMovement>();
        //_playerShoot = GetComponent<PlayerShooting>();

        CurrentHealth = StartingHealth;
	}
	
	void Update ()
    {
		//if events need to happen on damaged = true
        //in tutorial case this is making screen flash red
	}

    public void TakeDamage(int amount)
    {
        damaged = true;

        CurrentHealth -= amount;

        if(CurrentHealth <= 0 && !isDead)
        {
            Death();
        }
    }

    void Death()
    {
        isDead = true;

        //_playerShoot.DisableEffects();

        _charMovement.enabled = false;
        //_playerShoot.enabled = false;
    }
}
