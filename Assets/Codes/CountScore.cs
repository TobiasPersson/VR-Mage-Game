using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.XR;
using TMPro;

public class CountScore : MonoBehaviour
{
    public TextMeshProUGUI Score;

    public static int Manypoints;
    // Start is called before the first frame update
    void Start()
    {
        Score.text = "" + Manypoints;

    }
    public void GetPoints()
    {
        Manypoints++;
        Score.text = " Points" + Manypoints ;
    }
}
