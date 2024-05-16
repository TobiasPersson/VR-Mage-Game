using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arah : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;

    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("attack", true);

    }
    public void attack()
    {
        anim.SetBool("attack", true);
    }
}
