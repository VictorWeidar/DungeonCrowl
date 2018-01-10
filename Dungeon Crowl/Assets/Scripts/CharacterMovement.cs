using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    public float speed;
    public GameObject Model;
    Camera Maincam;

	// Use this for initialization
	void Awake ()
    {
        Maincam = GetComponentInChildren<Camera>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        float xMov = Input.GetAxis("Horizontal");
        float yMov = Input.GetAxis("Vertical");

        float MoveX = xMov * speed * Time.deltaTime;
        float MoveY = yMov * speed * Time.deltaTime;

        transform.Translate(MoveX, 0, MoveY);
	}
}
