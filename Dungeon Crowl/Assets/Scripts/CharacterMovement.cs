using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMovement : MonoBehaviour {

    public float speed;
    public float range = 150f;
    public GameObject Model;
    Vector3 mousePosition;
    public Camera Maincam;
    Rigidbody Rb;

    Vector3 target;

	// Use this for initialization
	void Awake ()
    {
        Rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        // Velocity Asigning.
        float h = Input.GetAxisRaw("Horizontal");
        float v = Input.GetAxisRaw("Vertical");
        Rb.velocity = new Vector3(h, 0, v) * speed;

        Ray ray = Maincam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hit;

        if (Physics.Raycast(ray, out hit, range))
        {
            Debug.Log(hit.transform.name);
        }

        var rotationLookAt = Quaternion.LookRotation(hit.point - transform.position);
        transform.rotation = Quaternion.Slerp(transform.rotation, rotationLookAt, Time.deltaTime * 10);
    }

}
