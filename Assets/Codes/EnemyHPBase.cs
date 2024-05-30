using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyHPBase : MonoBehaviour
{
    public ElementEnum element;
    public int skeletonHP = 15;
    public int cockroachHP = 5;

    public int skeletonDMG = 3;
    public int cockroachDMG = 1;

    public PlayerSlider playerSlider;

    public virtual void Start()
    {
        playerSlider = FindObjectOfType<PlayerSlider>();
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            PlayerTakeDMG();
        }
        if (collision.gameObject.CompareTag("Spell"))
        {
            Spell current = collision.transform.GetComponent<Spell>();
            
            if (current.element == ElementEnum.Fire && element == ElementEnum.Air)
            {
                EnemyTakeDMG();
            }
            else if (current.element == element + 1)
            {
                EnemyTakeDMG();
            }

        }
    }
    public virtual void PlayerTakeDMG()
    {

    }
    public virtual void EnemyTakeDMG()
    {

    }

}
