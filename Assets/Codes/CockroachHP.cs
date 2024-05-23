using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CockroachHP : EnemyHPBase
{
    public override void PlayerTakeDMG()
    {
        //player.HP -= cockroachDMG
    }

    public override void EnemyTakeDMG()
    {
        cockroachHP -= 5;
    }
}
