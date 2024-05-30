using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class ShieldSpell : Spell
{
    [SerializeField] private MeshRenderer meshRenderer;
    Material material;
    float lifetime = 20;
    float timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        ShieldManager.instance.ResetShields(gameObject);
        material = meshRenderer.material;
        material.SetColor("_BackColor", color);
    }

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > lifetime)
        {
            ShieldManager.instance.RemoveShield();
            Destroy(gameObject);
        }
    }
}
