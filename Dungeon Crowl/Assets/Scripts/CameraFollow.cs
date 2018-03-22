using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour {

    public Transform _target;

    public float SmoothSpeed = 10f;

    public Vector3 Offset;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate ()
    {
        Vector3 DesiredPosition = _target.position + Offset;
        Vector3 SmoothPos = Vector3.Lerp(transform.position, DesiredPosition, SmoothSpeed * Time.deltaTime);
        transform.position = SmoothPos;	
	}
}
