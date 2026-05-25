using UnityEngine;

public class SetPosition : MonoBehaviour
{
    public GameObject portal;
    private GameObject player;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            player.transform.position = new Vector3(portal.transform.position.x, portal.transform.position.y);
        }
    }
}