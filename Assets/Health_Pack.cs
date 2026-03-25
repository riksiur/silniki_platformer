using UnityEngine;

public class Health_Pack : MonoBehaviour
{
    public float HealingValue = 1;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        collision.GetComponent<Health_Component>().AddHealth(HealingValue);
        Destroy(gameObject);
    }
}
