using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Spellcasting : MonoBehaviour {

    public bool CastSpell;

	// Use this for initialization
	void Start ()
    {
       
	}
	
	// Update is called once per frame
	void Update ()
    {
	    if(Input.GetKeyDown(KeyCode.Space))
        {
            SpellSequence();
        }
	}

    void SpellSequence()
    {
        if(CastSpell)
        {
            //slow down

            //match input with spell

            //Time speed up
            //magic circle appears

            //Circle Disappears
            //Spell Fires
        }

    }
}
