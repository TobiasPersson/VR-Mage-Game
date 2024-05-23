using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldSpell : Spell
{
    // Start is called before the first frame update
    void Start()
    {
        ShieldManager.instance.ResetShields(gameObject);
    }
}
