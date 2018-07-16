using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Eventsystem : MonoBehaviour {

    public static Eventsystem Instance;

	void Awake()
    {
        Instance = this;
	}


    public UnityEvent Preparing = new UnityEvent();
    public UnityEvent Input = new UnityEvent();
    public UnityEvent Hold = new UnityEvent();
    public UnityEvent Fire = new UnityEvent();

}
