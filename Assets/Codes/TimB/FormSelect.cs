using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FormSelect : BaseSelect
{
    [SerializeField] GameObject form;
    public override void sendType()
    {
        ss.DestroyFormCircle(form);
    }
}
