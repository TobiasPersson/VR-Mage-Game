using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class skeletonHP : EnemyHPBase
{
    public override void PlayerTakeDMG()
    {
        //player.HP -= skeletonDMG
    }

    public override void EnemyTakeDMG()
    {
        skeletonHP -= 5;
    }
}
