using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellSelect : MonoBehaviour
{
    [SerializeField]
    GameObject spellElement, spellForm;
    GameObject formType;
    ElementSO elementType;
    Vector3 wandPosition;
    Quaternion wandRotation;

    public void InstantiateElementCircle()
    {
        wandPosition = gameObject.transform.position;
        wandRotation = gameObject.transform.rotation;
        Instantiate(spellElement, wandPosition, wandRotation);
    }
    public void DestroyElementCircle(ElementSO element)
    {
        elementType = element;
        Destroy(gameObject.transform.GetChild(0).gameObject);
        InstantiateFormCircle();
    }
    public void InstantiateFormCircle()
    {
        Instantiate(spellForm, wandPosition, wandRotation);
    }
    public void DestroyFormCircle(GameObject form)
    {
        formType = form;
        Destroy(gameObject.transform.GetChild(0).gameObject);
    }
}
