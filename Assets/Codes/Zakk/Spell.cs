using System.Collections;
using System.Collections.Generic;
using Unity.XR.CoreUtils;
using UnityEngine;

public enum ElementEnum
{
    Fire,
    Water,
    Earth,
    Air,
};

public class Spell : MonoBehaviour
{
    public ElementEnum element;



    [SerializeField] protected LayerMask layer;
    public void SetLayer(LayerMask layerMask)
    {
        layer = layerMask;
    }

    [SerializeField] private Color32 color;
    public void SetColor(Color32 color32)
    {
        color = color32;
    }


}
