using UnityEngine;
using System.Collections;

public class fishController : MonoBehaviour {
	
	private int velocity;
	
	// Use this for initialization
	void Start () 
	{
		velocity = 2;
	}
	
	// Update is called once per frame
	void Update ()
	{
		if (this.transform.position.x < 4f)
		{
			print("right");
			if(Input.GetKeyDown(KeyCode.RightArrow))
				transform.position += new Vector3(velocity * Time.deltaTime,0,0);
		}
		
		if (this.transform.position.x > -4f)
		{
			if(Input.GetKeyDown(KeyCode.LeftArrow))
				transform.position -= new Vector3(velocity * Time.deltaTime,0,0);
		}
	}
}