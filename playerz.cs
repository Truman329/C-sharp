using UnityEngine;
using UnityEngine.UI;
using System.Collections;
// This code control the player movement 
//and their ability to pick up a gameobject while keeping track of the amount that they are picking up 
public class playerz : MonoBehaviour
{
    public GameObject player;
    //public Vector3 teleport;
    public float speed;
    private Rigidbody2D rb;
    //public Text countText;
    //public Text winText;
    private int count;
    public Text countText;
    public Text winText;
    public Color color = new Color(0.2F, 0.3F, 0.4F, 0.5F);


    // Use this for initialization
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        count = 0;
        SetCountText();
        winText.text = "";
        //SetCountText();
        //winText.text = "";
    }

    // Update is called once per frame
    void Update()
    {
     
        if (Input.GetKeyDown (KeyCode.W)) 
        {
        player.transform.position = player.transform.position + new Vector3(0f, 1f, 0f);
        }
        

    }
    void FixedUpdate()
    {
        float move = Input.GetAxis("Horizontal");
        //float move = Input.GetAxis("Vertical");
        rb.velocity = new Vector2(speed * move, rb.velocity.y);

    }
    void OnCollisionEnter2D(Collision2D other)
    {
        if (other.gameObject.CompareTag("Pick Up"))
        {
            other.gameObject.SetActive(false);
            count = count + 1;
            SetCountText();
            color = new Color(Random.value, Random.value, Random.value, Random.value); 
		    gameObject.GetComponent<SpriteRenderer> ().color = color;

	}
}

        }
    }
    void SetCountText()
    {
        countText.text = "Cherry: " + count.ToString();
        if (count >= 1)
        {
            winText.text = "The door has open";
        }
    }
    

}
    
