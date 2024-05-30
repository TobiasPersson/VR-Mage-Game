using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MeleeSpell : Spell
{

    public GameObject rightHandController;
    [SerializeField] private MeshRenderer meshrend;
    Material mat;

    private void Awake()
    {
        mat = meshrend.material;
    }

    private void Start()
    {
        rightHandController = FindObjectOfType<WandManager>().rightHandController;
        transform.SetParent(rightHandController.transform);
        transform.localPosition = new Vector3(0, 2, 0);
        mat.SetColor("_LitColor", color);
        mat.SetColor("_DarkColor", color);
    }


}
