using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangedSpell : Spell
{
    [SerializeField] private Rigidbody rb;
    [SerializeField] private float speed;

    private void FixedUpdate()
    {
        rb.velocity = ((transform.forward * speed) * Time.deltaTime).normalized;
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
