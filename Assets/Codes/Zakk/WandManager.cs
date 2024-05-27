using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WandManager : MonoBehaviour
{

    [SerializeField] private GameObject currentSpellform;

    [SerializeField] private ElementSO element;


    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            CastSpell();
        }
    }


    public void SetSpellInfo(GameObject form, ElementSO elementSO)
    {
        currentSpellform = form;
        element = elementSO;
    }

    public void CastSpell()
    {
        GameObject spellObj = Instantiate(currentSpellform, transform.position + transform.forward * 4, Quaternion.identity);
        Spell spellScript = spellObj.GetComponent<Spell>();
        spellScript.element = element.elementEnum;
        spellScript.SetColor(element.elementColor);
        //spellScript.SetLayer(element.elementAttackLayer);
        Debug.Log("Casted Spell");
    }

}
