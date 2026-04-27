using System.Collections;
using UnityEngine;
using UnityEngine.SceneManagement;

public class healthcomponent : MonoBehaviour
{
    private float Health = 15;
    private float MaxHealth = 15;
    private bool invicibility;

    public delegate void OnHealthInitializedHandler(float Health);
    public delegate void OnHealthChangedHandler(float newHealth, float amountChanged);
    public event OnHealthChangedHandler OnHealthChanged;
    public event OnHealthInitializedHandler OnHealthInitialized;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Health = MaxHealth;
        OnHealthInitialized?.Invoke(Health);
    }

    // Update is called once per frame
    void Update()
    {

    }
    public void AddDamage(float damage)
    {
        if (!invicibility)

        {
            Health -= damage;
            OnHealthChanged?.Invoke(Health, damage);
            invicibility = true;
            StartCoroutine(Resetinvincibility(1));
        }

        //Debug.Log(Health);

        if (Health <= 0)
        {
            Health = 0;
            SceneManager.LoadScene("endgame");
        }
        OnHealthChanged?.Invoke(Health, -damage);
    }
    IEnumerator Resetinvincibility(float resetTime)
    {
        yield return new WaitForSeconds(resetTime);
        invicibility = false;
    }
    public void AddHealth(float HealingValue)
    {
        Health += HealingValue;

        if (Health >= MaxHealth)
        {
            Health = MaxHealth;
        }
        OnHealthChanged?.Invoke(Health, HealingValue);
        // Debug.Log(Health);


    }
}