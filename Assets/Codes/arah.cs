using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class arah : MonoBehaviour
{
    // Start is called before the first frame update
    Animator anim;
    float timer;
    void Start()
    {
        anim = GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update()
    {
        timer -= 1 * Time.deltaTime;
        if(timer <= 0)
        {
            attack();
            timer = 5;
        }
    }
    public void attack()
    {
        anim.SetBool("attack", true);
    }
}
