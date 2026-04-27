using UnityEngine;

public class coincomponent : MonoBehaviour
{
    public float money = 0;
    public float maxMoney = 10;
    public float moneyhealth = 10;

    public delegate void OnMoneyInitializedHandler(float money);
    public delegate void OnMoneyChangedHandler(float newMoney, float amountChanged);
    public event OnMoneyChangedHandler OnMoneyChanged;
    public event OnMoneyInitializedHandler OnMoneyInitialized;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        OnMoneyInitialized?.Invoke(money);
    }

    // Update is called once per frame
    void Update()
    {


    }
    public void AddCoin(float coinvalue)
    {
        money += coinvalue;

        // Debug.Log(money);
        if (money >= maxMoney)
        {
            money = money - 10;
            GetComponent<healthcomponent>().AddHealth(moneyhealth);

        }

        OnMoneyChanged?.Invoke(money, coinvalue);



    }
}