using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellSelect : MonoBehaviour
{
    [SerializeField]
    GameObject spellElement, spellForm;
    [SerializeField]
    Transform wand;
    ElementSO elementType;
    WandManager wm;

    void Start()
    {
        wm = FindObjectOfType(typeof(WandManager)) as WandManager;
        InstantiateElementCircle();
    }
    public void InstantiateElementCircle()
    {
        GameObject circle = Instantiate(spellElement, wand.position, new Quaternion(80, wand.rotation.y, wand.rotation.z, wand.rotation.w));
        circle.transform.parent = gameObject.transform;
    }
    public void DestroyElementCircle(ElementSO element)
    {
        elementType = element;
        Destroy(gameObject.transform.GetChild(0).gameObject);
        GameObject circle = Instantiate(spellForm, wand.position, wand.rotation);
        circle.transform.parent = gameObject.transform;
    }
    public void DestroyFormCircle(GameObject form)
    {
        Destroy(gameObject.transform.GetChild(0).gameObject);
        wm.SetSpellInfo(form, elementType);
    }
}
