using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerSlider : MonoBehaviour
{

    public int maxHealth = 3;
    public int currentHealth;
    [SerializeField] PlayerHealthBar healthbar;
    // Start is called before the first frame update
    void Start()
    {
        healthbar = transform.GetComponentInChildren<PlayerHealthBar>();
        currentHealth = maxHealth;
    }
    public void TakeDamage(int amount)
    {
        currentHealth -= amount;

        healthbar.UpdateFixedHealtBar(currentHealth, maxHealth);

        if (currentHealth <= 0)
        {
            Destroy(gameObject);
        }

    }

}
