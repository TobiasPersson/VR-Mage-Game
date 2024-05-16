using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.XR;

public class CountScore : MonoBehaviour
{
    public Text Score;

    // Start is called before the first frame update
    void Start()
    {
        teddyCount.text = "" + teddysleft;

        if (teddysleft == 0)
        {
            teddyCount.text = "Winner Winner Kyckling Dinner!";
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
