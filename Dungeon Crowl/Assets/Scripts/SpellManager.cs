using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellManager : MonoBehaviour {

    public List<Spell> Spells;

    private bool HasActiveSpell;
    private Spell activeSpell;

    private void Start()
    {
        AddSpell();
        AddSpell();
        AddSpell();
    }

    public void AddSpell()
    {
        Spell spell = new Spell("Fireball");
    }

    //change wording to fit spellcasting
    public void TypeLetter (char letter)
    {
        if(HasActiveSpell)
        {
            //check if spell element was the next
            //Remove it from the spell
            //Remove in this case means "set as being used for spell"

            if(activeSpell.GetNextElement() == letter)
            {
                activeSpell.ActivateElement();
            }
        }

        else
        {
            foreach (Spell spell in Spells)
            {
                //letter here should be element
                if (spell.GetNextElement() == letter)
                {
                    //WARNING
                    //having an active spell will
                    //prevent the player from freely
                    //entering inputs if the system
                    //recognizes the spell
                    activeSpell = spell;
                    HasActiveSpell = true;
                    spell.ActivateElement();
                    break;
                }
            }
        }

        if(HasActiveSpell && activeSpell.SpellCast())
        {
            HasActiveSpell = false;
            Spells.Remove(activeSpell);
        }
    }
}
