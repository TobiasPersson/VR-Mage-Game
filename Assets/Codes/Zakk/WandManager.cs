using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandManager : MonoBehaviour
{

    public XRIDefaultInputActions inputActions;

    [SerializeField] private GameObject currentSpellform;

    [SerializeField] private ElementSO element;

    [SerializeField] private GameObject aimPoint;

    public GameObject rightHandController;

    private bool shooting = false;

    private void OnEnable()
    {
        inputActions = new XRIDefaultInputActions();
        inputActions.Enable();
    }

    private void OnDisable()
    {
        inputActions.Disable();
    }

    private void Update()
    {

        if (inputActions.XRIRightHandInteraction.Activate.WasReleasedThisFrame())
        {
            CastSpell();
        }

        if (Input.GetKeyDown(KeyCode.Space))
        {
            CastSpell();
        }
    }


    public void SetSpellInfo(GameObject form, ElementSO elementSO)
    {
        currentSpellform = form;
        element = elementSO;
        shooting = true;
    }

    public void CastSpell()
    {
        GameObject spellObj = Instantiate(currentSpellform, transform.position, Quaternion.identity);
        spellObj.transform.LookAt(aimPoint.transform);
        Spell spellScript = spellObj.GetComponent<Spell>();
        spellScript.element = element.elementEnum;
        spellScript.SetColor(element.elementColor);
        //spellScript.SetLayer(element.elementAttackLayer);
        Debug.Log("Casted Spell");
    }

}
