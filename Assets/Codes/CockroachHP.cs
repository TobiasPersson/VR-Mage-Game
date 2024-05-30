using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CockroachHP : EnemyHPBase
{
    CountScore score;
    WaveScript wave;
    public override void Start()
    {
        base.Start();
        score = FindObjectOfType<CountScore>();
        wave = FindObjectOfType<WaveScript>();

    }
    public override void PlayerTakeDMG()
    {
        playerSlider.TakeDamage(cockroachDMG);
    }

    public override void EnemyTakeDMG()
    {
        cockroachHP -= 5;

        if(cockroachHP <= 0)
        {

            score.GetPoints();
            wave.enemiesAlive--;
            Destroy(gameObject);

        }
    }
    public void Update()
    {
        if (cockroachHP <= 0)
        {

            score.GetPoints();
            wave.enemiesAlive--;
            Destroy(gameObject);

        }
    }

}

