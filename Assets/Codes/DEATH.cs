using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DEATH : MonoBehaviour
{
    // Start is called before the first frame update
    PlayerSlider pls;
    SceneSwitch scenmg;
    int health;
    void Start()
    {
        pls = FindObjectOfType<PlayerSlider>();

        scenmg = FindObjectOfType<SceneSwitch>();
    }

    // Update is called once per frame
    void Update()
    {
        health = pls.currentHealth;
        if (health >= 0)
        {
            //die
            scenmg.BackToTitle();
        }
    }
}
