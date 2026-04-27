using TMPro;
using UnityEngine;

public class UI_health_display : MonoBehaviour
{
    public healthcomponent healthComponent;
    public TextMeshProUGUI textComponent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        healthComponent.OnHealthInitialized += OnHealthInitialized;
        healthComponent.OnHealthChanged += OnHealthChanged;
    }

    private void OnHealthInitialized(float Health)
    {
        textComponent.text = Health.ToString();
    }

    private void OnHealthChanged(float newHealth, float amountChanged)
    {
        textComponent.text = newHealth.ToString();
        //Debug.Log(newHealth + ":" + amountChanged);
    }


    // Update is called once per frame
    void Update()
    {
    }
}