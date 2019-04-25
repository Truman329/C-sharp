using UnityEngine;
using System.Collections;
// when a button is click change the color to the random one
public class randomcolor3 : MonoBehaviour 
{
	public Color color = new Color(0.2F, 0.3F, 0.4F, 0.5F);
	//public GameObject background;
	
	
	// Use this for initialization
	void Start () 
	{
		
	}
	
	// Update is called once per frame
	void Update () 
	{
		color = new Color(Random.value, Random.value, Random.value, Random.value); // the color is changing to a different random color is every frame.

		if (Input.GetKeyDown (KeyCode.Q)) 
		{
			gameObject.GetComponent<SpriteRenderer> ().color = color; // the color of the gameobject is changing its color to the random color.
		}

		if (Input.GetKeyDown (KeyCode.W)) 
		{
			gameObject.GetComponent<SpriteRenderer> ().color = color; // the color of the gameobject is changing its color to the random color.
		}

		if (Input.GetKeyDown (KeyCode.E)) 
		{
			gameObject.GetComponent<SpriteRenderer> ().color = color; // the color of the gameobject is changing its color to the random color.
		}

		if (Input.GetKeyDown (KeyCode.R)) 
		{
			gameObject.GetComponent<SpriteRenderer> ().color = color; // the color of the gameobject is changing its color to the random color.
		}
	}
}
