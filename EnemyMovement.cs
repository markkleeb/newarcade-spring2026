using UnityEngine;

public class EnemyMovement : MonoBehaviour
{
    //variable to hold the player GameObject so we can reference it
    public GameObject player;
    public float speed = 2.0f;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        Vector2 position = this.transform.position;

        //position.x = Mathf.Lerp(this.transform.position.x, player.transform.position.x,speed*Time.deltaTime);
        //position.y = Mathf.Lerp(this.transform.position.y, player.transform.position.y,speed*Time.deltaTime);

        position = Vector2.Lerp(this.transform.position, player.transform.position, speed*Time.deltaTime);

        this.transform.position = position;
        
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        //homework!
    }
}
