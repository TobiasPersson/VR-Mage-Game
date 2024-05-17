using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TpyeSelect : MonoBehaviour
{
    SpellSelect ss;
    public virtual void Start()
    {
        
    }
    public virtual void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.layer == 3)
        {
            
        }
    }
    public virtual void sendType()
    {

    }
}
