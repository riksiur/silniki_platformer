using TMPro;
using UnityEngine;

public class UI_money_display : MonoBehaviour
{
    public coincomponent coinComponent;
    public TextMeshProUGUI textComponent;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Awake()
    {
        coinComponent.OnMoneyInitialized += OnMoneyInitialized;
        coinComponent.OnMoneyChanged += OnHealthChanged;
    }
    private void OnMoneyInitialized(float money)
    {
        textComponent.text = money.ToString();
    }

    private void OnHealthChanged(float newMoney, float amountChanged)
    {
        textComponent.text = newMoney.ToString();
        // Update is called once per frame
        void Update()
        {

        }
    }
}