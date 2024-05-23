using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHPBase : MonoBehaviour
{
    public int skeletonHP = 15;
    public int cockroachHP = 5;

    public int skeletonDMG = 3;
    public int cockroachDMG = 1;
    

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerTakeDMG();
        }
    }
    public virtual void PlayerTakeDMG()
    {

    }
    public virtual void EnemyTakeDMG()
    {

    }

}
