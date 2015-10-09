using UnityEngine;
using System.Collections;

public class penguinBehaviour : MonoBehaviour {
	
	private float velocity;
	private GameObject end;
	
	// Use this for initialization
	void Start () 
	{
		velocity = 6f;
		end = GameObject.Find("End");	
	}
	
	// Update is called once per frame
	void Update () 
	{
		this.transform.position -= new Vector3 (0, velocity * Time.deltaTime, 0);
		if (this.gameObject.transform.position.y < end.transform.position.y)
			Destroy (this.gameObject);
	}
}
