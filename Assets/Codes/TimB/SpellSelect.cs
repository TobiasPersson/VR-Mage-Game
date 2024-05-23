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
    public XRIDefaultInputActions input;

    private void OnEnable()
    {
        input = new XRIDefaultInputActions();
        input.Enable();
    }
    private void OnDisable()
    {
        input.Disable();
    }
    void Start()
    {
        print(input.XRIRightHandInteraction.Activate.WasPressedThisFrame());
        wm = FindObjectOfType(typeof(WandManager)) as WandManager;
    }

    private void Update()
    {
        if (input.XRIRightHandInteraction.Activate.WasPressedThisFrame())
        {
            print("hello");
        }
    }
    public void OnActivate()
    {
        InstantiateElementCircle();
    }

    public void InstantiateElementCircle()
    {
        print("test!");
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
    public void DestroyCircles()
    {
        Destroy(gameObject.transform.GetChild(0).gameObject);
    }
}
