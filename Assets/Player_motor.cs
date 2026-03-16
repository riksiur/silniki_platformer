using UnityEngine;
using UnityEngine.InputSystem;

public class Player_motor : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMove(InputValue value)
    {
        //Debug.Log("Move");
        // Debug.Log(value.Get<Vector2>());
        Vector2 direction = value.Get<Vector2>();
        transform.position += new Vector3(direction.x, direction.y, 0);
    }
}
