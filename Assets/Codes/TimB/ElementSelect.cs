using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementSelect : BaseSelect
{
    [SerializeField] ElementSO element;
    public override void sendType()
    {
        ss.DestroyElementCircle(element);
    }
}
