using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CockroachHP : EnemyHPBase
{
    public override void PlayerTakeDMG()
    {
        playerSlider.TakeDamage(cockroachDMG);
    }

    public override void EnemyTakeDMG()
    {
        cockroachHP -= 5;
    }
}
