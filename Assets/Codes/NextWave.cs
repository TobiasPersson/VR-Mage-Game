using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.XR;
using TMPro;

public class NextWave : MonoBehaviour
{
    public TextMeshProUGUI Wave;
    public static int CurretnWave;

    // Start is called before the first frame update
    void Start()
    {
        Wave.text = " Wave:" + " " + CurretnWave;
    }
    public void WaveLooking()
    {
        CurretnWave++;
        Wave.text = " Wave:" + " " + CurretnWave;
    }
}
