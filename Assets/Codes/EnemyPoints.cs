using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.XR;

public class EnemyPoints : MonoBehaviour
{
    [SerializeField]
    GameObject Enemy;

    [SerializeField]
    CountScore  countScore;
    void Start()
    {
        countScore.GetComponent<CountScore>();
    }
    void Update()
    {
      //  if(health <= 0)
        {
            Destroy(Enemy);
            countScore.GetPoints();
        }
    }
}
