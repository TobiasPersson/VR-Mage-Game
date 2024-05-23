using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerHealthBar : MonoBehaviour
{
    [SerializeField] private Slider slider;
    [SerializeField] private Transform target;
    [SerializeField] private Vector3 offset;
    [SerializeField] private Camera camera2;

    [SerializeField] PlayerSlider player;
    // Start is called before the first frame update
    void Start()
    {
        player = transform.GetComponentInParent<PlayerSlider>();
        camera2 = FindObjectOfType<Camera>();
    }

    public void UpdateFixedHealtBar(int currentValue, int maxValue)
    {
        slider.value = currentValue / maxValue;
    }
    private void Update()
    {
        if (player == null)
        {
            player = transform.parent.parent.gameObject.GetComponent<PlayerSlider>();
        }
        if (slider == null)
        {
            slider = GetComponent<Slider>();
        }
        slider.value = player.currentHealth;
        transform.rotation = camera2.transform.rotation;
        transform.position = target.position + offset;
    }
}
