using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSelect : MonoBehaviour
{
    [HideInInspector] public SpellSelect ss;
    [HideInInspector] public float delay;
    public virtual void Start()
    {
        ss = FindObjectOfType(typeof(SpellSelect)) as SpellSelect;
    }
    public virtual void Update()
    {
        delay += Time.deltaTime;
    }

    public virtual void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.layer == 3 && delay >= 0.25f)
        {
            sendType();
        }
    }
    public virtual void sendType()
    {
        //Empty
    }
}
