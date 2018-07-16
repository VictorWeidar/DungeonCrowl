using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellInput : MonoBehaviour {

    public SpellManager spellManager;

	// Update is called once per frame
	void Update ()
    {
		foreach (char letter in Input.inputString)
        {
            //this would have to be changed to fit arrowkeys
            //or possibly this would work if any other keys are
            //used to cast spells
            Debug.Log(letter);
            spellManager.TypeLetter(letter);
        }
	}
}
