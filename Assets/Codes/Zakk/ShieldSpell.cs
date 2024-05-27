using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class ShieldSpell : Spell
{
    [SerializeField] private MeshRenderer meshRenderer;
    Material material;
    // Start is called before the first frame update
    void Start()
    {
        ShieldManager.instance.ResetShields(gameObject);
        material = meshRenderer.material;
        material.SetColor("_BackColor", color);
    }
}
