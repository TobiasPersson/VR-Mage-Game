using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellSelect : MonoBehaviour
{
    [SerializeField]
    GameObject spellElement, spellForm;
    [SerializeField]
    Transform wand;
    [SerializeField]
    Transform camera;
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
        wm = FindObjectOfType(typeof(WandManager)) as WandManager;
    }

    private void Update()
    {
        if (input.XRIRightHandInteraction.Activate.WasPressedThisFrame())
        {
            InstantiateElementCircle();
        }
        if (input.XRIRightHandInteraction.Activate.WasReleasedThisFrame())
        {
            DestroyCircles();
        }
    }
    public void InstantiateElementCircle()
    {
        GameObject circle = Instantiate(spellElement, wand.position, new Quaternion(0, 0, 0, 0));
        circle.transform.parent = gameObject.transform;
        circle.transform.LookAt(camera);
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
