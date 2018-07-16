using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Spell {

    //Brackeys added a string for the word
    //would I add an enum with spell inputs?
    //enum Elements {Fire, Air, Water, Earth};
    string name;
    public string spell;
    private int TypeIndex;

    public Spell (string _spell)
    {
        spell = _spell;
        name = _spell;
        TypeIndex = 0;
    }

    public char GetNextElement()
    {
        return spell[TypeIndex];
    }

    public void ActivateElement()
    {
        TypeIndex++;
        //remove letter on screen
        //this means "Change colour of arrows/icons"
    }

    //check if spell has been fully typed
    public bool SpellCast()
    {
        bool spellcast = (TypeIndex >= spell.Length);

        if(spellcast)
        {
            //Remove spell on screen
        }

        return spellcast;
    }
}
