using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseProjectile : MonoBehaviour {

    public GameObject HitParticle;
    public float DeathTimer;
    float timer;


	// Use this for initialization
	void Start ()
    {
        timer = DeathTimer;
	}

    private void Update()
    {
        timer -= Time.deltaTime;

        if(timer <= 0)
        {
            Death();
        }
    }

    // Update is called once per frame
    private void OnCollisionEnter(Collision collision)
    {
        Death();
    }

    void Death()
    {
        GameObject Hitparticle = Instantiate(HitParticle, transform.position, Quaternion.identity);
        Destroy(this.gameObject);
        Destroy(Hitparticle, 1f);
    }
}
