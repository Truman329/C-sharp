using UnityEngine;
using System.Collections;

public class movementup : MonoBehaviour
{
    public GameObject player;
    public Vector3 teleport;
    public float speed;
    Rigidbody2D rb;

    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        /*  if (Input.GetKeyDown(KeyCode.D))
          {
              player.transform.position = player.transform.position + new Vector3(1f, 0f, 0f);
          }
          if (Input.GetKeyDown(KeyCode.S))
          {
              player.transform.position = player.transform.position + new Vector3(0f, -1f, 0f);
          }
          if (Input.GetKeyDown(KeyCode.W))
          {
             player.transform.position = player.transform.position + new Vector3(0f, 1f, 0f);
          }
          if (Input.GetKeyDown(KeyCode.Space))
          {
              player.transform.position = player.transform.position + new Vector3(-1f, 0f, 0f);
          }
          //if (Input.GetKeyDown (KeyCode.W)) 
          //{
          //player.transform.position = player.transform.position + new Vector3(0f, 2f, 0f);
          //}
          */
        if (Input.GetKeyDown(KeyCode.A))
        {
            player.transform.position = player.transform.position + new Vector3(0f, 1f, 0f);
        }

    }
    void FixedUpdate()
    {
        //float move = Input.GetAxis("Horizontal");
        float move = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(speed * move, rb.velocity.y);
    }
}
