using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skeletonHP : EnemyHPBase
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
        playerSlider.TakeDamage(skeletonDMG);
    }

    public override void EnemyTakeDMG()
    {
        skeletonHP -= 5;

        if (skeletonHP <= 0)
        {
            score.GetPoints();
            wave.enemiesAlive--;
            Destroy(gameObject);

        }
    }

}
