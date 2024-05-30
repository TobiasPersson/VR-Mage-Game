using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeSpell : Spell
{

    public GameObject rightHandController;

    private void Start()
    {
        rightHandController = FindObjectOfType<WandManager>().rightHandController;
        transform.SetParent(rightHandController.transform);
        transform.localPosition = new Vector3(0, 2, 0);
    }


}
