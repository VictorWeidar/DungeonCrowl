using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerShooting : MonoBehaviour {

    public GameObject BaseProjectile;
    public Transform ShootPoint;
    public float TimeBetweenBullets = 1f;
    public float BulletSpeed;

    Rigidbody BulletRB;

    float timer;

	// Use this for initialization
	void Start ()
    {
		
	}
	
	// Update is called once per frame
	void Update ()
    {
        timer += Time.deltaTime;

        if (Input.GetButton("Fire1") && timer >= TimeBetweenBullets)
        {
            Shoot();
        }
	}

    void Shoot()
    {
        timer = 0f;

       GameObject Projectile = Instantiate(BaseProjectile, ShootPoint.position, this.gameObject.transform.rotation);
       BulletRB = Projectile.GetComponent<Rigidbody>();
       BulletRB.AddForce(transform.forward * BulletSpeed);
    }
}
