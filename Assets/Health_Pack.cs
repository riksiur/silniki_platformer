using UnityEngine;

public class HealthPack : MonoBehaviour
{
    public float HealingValue = 10;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<healthcomponent>().AddHealth(HealingValue);
        Destroy(gameObject);
    }

}