using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Element", menuName = "ScriptableObject/Element")]
public class ElementSO : ScriptableObject
{

    public LayerMask elementAttackLayer;

    public ElementEnum elementEnum;

    public Color32 elementColor;


}
