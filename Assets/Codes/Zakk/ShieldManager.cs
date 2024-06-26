using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldManager : MonoBehaviour
{
    public static ShieldManager instance { get; private set; }
    [SerializeField] private GameObject currentShield;
    [SerializeField] GameObject shieldPos;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(this);
        }
        else instance = this;
    }

    public void ResetShields(GameObject newshield)
    {
        if(currentShield != null)
        {
            Destroy(currentShield);
            Debug.Log("Removed " + currentShield.name);
        }

        currentShield = newshield;
        newshield.transform.position = shieldPos.transform.position;
        Debug.Log("Added " + currentShield.name);
    }

    public void RemoveShield()
    {
        currentShield = null;
    }


}
