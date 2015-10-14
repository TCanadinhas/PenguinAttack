using UnityEngine;
using System.Collections;

public class penguinSpawnerController : MonoBehaviour {
	
	public GameObject penguin;
	private int random;
	
	
	// Use this for initialization
	void Start () 
	{
		StartCoroutine(timer (5f));
		//penguin = Resources.Load("Penguin") as GameObject;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//print ("will instantiate");
		
		StartCoroutine(timer(5f));
		
		switch (random)
		{
		case 0:
			Instantiate(penguin, new Vector3(-4,this.transform.position.y,0), this.transform.rotation);
			break;
			
		case 1:
			Instantiate(penguin, new Vector3(-2,this.transform.position.y,0), this.transform.rotation);
			break;
			
		case 3:
			Instantiate(penguin, new Vector3(0,this.transform.position.y,0), this.transform.rotation);
			break;
			
		case 4:
			Instantiate(penguin, new Vector3(2,this.transform.position.y,0), this.transform.rotation);
			break;
			
		case 5:
			Instantiate(penguin, new Vector3(4,this.transform.position.y,0), this.transform.rotation);
			break;
		}
		
	}
	
	private void instantiate()
	{
		
	}
	
	IEnumerator timer (float s)
	{
		yield return new WaitForSeconds(s);
		print("wait: " + s + " seconds");
		random = Random.Range(0,6);	
	}
}
