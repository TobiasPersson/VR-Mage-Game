using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseSelect : MonoBehaviour
{
    [HideInInspector] public SpellSelect ss;
    public virtual void Start()
    {
        ss = FindObjectOfType(typeof(SpellSelect)) as SpellSelect;
    }

    public virtual void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 3)
        {
            sendType();
        }
    }
    public virtual void sendType()
    {
        //Empty
    }
}
