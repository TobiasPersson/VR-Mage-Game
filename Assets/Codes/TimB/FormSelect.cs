using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormSelect : MonoBehaviour
{
    public SpellSelect ss;
    [SerializeField] GameObject form;
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
        ss.DestroyFormCircle(form);
    }
}
