using UnityEngine;
using UnityEngine.InputSystem;

public class TimotheeMove : MonoBehaviour
{
    //Input variables
    public InputAction moveLeft;
    public InputAction moveRight;
    public InputAction jump;

    //old input system variables
    //public KeyCode moveLeft;
    //public KeyCode moveRight;

    //move speed variables
    public float speed = 20.0f;
    public float jumpForce;

    private bool isGrounded; //are we touching the ground?
    private bool facingLeft; //are we facing left?

    //Components
    private Rigidbody2D timmyRB;
    private SpriteRenderer timmySR;


    void Start()
    {
        //initialize input variables
        moveRight.Enable();
        moveLeft.Enable();
        jump.Enable();

        //get components
        timmyRB = gameObject.GetComponent<Rigidbody2D>();
        timmySR = gameObject.GetComponent<SpriteRenderer>();
        
    }

    // Update is called once per frame
    void Update()
    {
        //Debug.Log(isGrounded);
        
        //move left
        if (moveLeft.IsPressed())
        {
            transform.Translate(Vector2.left * speed * Time.deltaTime);
            facingLeft = true;
        }

        //move right
        if (moveRight.IsPressed())
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
            facingLeft = false;
        }
        
        //jump
        if (isGrounded && jump.IsPressed())
        {
            timmyRB.linearVelocityY = jumpForce;
        }

        //handle sprite swap

        if (facingLeft)
        {
            timmySR.flipX = false;
        }

        else
        {
            timmySR.flipX = true;
        }
        
    }

private void OnCollisionEnter2D(Collision2D other) {

        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
        }

}

private void OnCollisionExit2D(Collision2D other) {

        if (other.gameObject.CompareTag("Ground"))
        {
            isGrounded = false;
        }

}

}
