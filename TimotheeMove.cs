using UnityEngine;
using UnityEngine.InputSystem;

public class TimotheeMove : MonoBehaviour
{
    public InputAction moveLeft;
    public InputAction moveRight;

    //public KeyCode moveLeft;
    //public KeyCode moveRight;

    public float speed = 20.0f;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        moveRight.Enable();
        moveLeft.Enable();
        
    }

    // Update is called once per frame
    void Update()
    {
        if (moveLeft.IsPressed())
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
        }

        if (moveRight.IsPressed())
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }
        
    }
}
