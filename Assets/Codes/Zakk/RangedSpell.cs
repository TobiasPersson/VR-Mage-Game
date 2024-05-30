using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.VFX;

public class RangedSpell : Spell
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;
    [SerializeField] private float intensity;

    float lifetime = 20;
    float timer = 0;

    [SerializeField] private VisualEffect visualEffect;



    private void Start()
    {
        visualEffect.SetVector4("FrontColor", new Vector4(color.r * intensity, color.g*intensity, color.b*intensity, color.a*intensity));
    }


    private void Update()
    {
        timer += Time.deltaTime;
        if (timer > lifetime)
        {
            Destroy(gameObject);
        }
    }

    private void FixedUpdate()
    {
        rb.velocity = ((transform.forward * speed) * Time.deltaTime);
    }

    private void OnCollisionEnter(Collision collision)
    {
        Debug.Log(collision.gameObject.layer);
        Debug.Log(layer.value);
        if (collision.gameObject.layer == layer.value)
        {
            Debug.Log("Hit " + collision.gameObject.name);
        }
    }
}
