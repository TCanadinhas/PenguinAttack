using UnityEngine;
using System.Collections;

public class penguinSpawnerController : MonoBehaviour {

	public GameObject penguin;
	private int random;
	private bool isInstantiated;


	// Use this for initialization
	void Start () 
	{
		isInstantiated = false;
		//penguin = Resources.Load("Penguin") as GameObject;
	}
	
	// Update is called once per frame
	void Update () 
	{
		//print ("will instantiate");

		random = Random.Range(0,6);	

		switch (random)
		{
		case 0:
			StartCoroutine(instantiate(penguin, new Vector3(-4,this.transform.position.y,0)));
			break;
			
		case 1:
			StartCoroutine(instantiate(penguin, new Vector3(-2,this.transform.position.y,0)));
			break;
			
		case 3:
			StartCoroutine(instantiate(penguin, new Vector3(0,this.transform.position.y,0)));
			break;
			
		case 4:
			StartCoroutine(instantiate(penguin, new Vector3(2,this.transform.position.y,0)));
			break;
			
		case 5:
			StartCoroutine(instantiate(penguin, new Vector3(4,this.transform.position.y,0)));
			break;
		}

	}

	IEnumerator instantiate(GameObject obj, Vector3 position) 
	{
		yield return new WaitForSeconds (2);
		Instantiate (obj, position, transform.rotation);
		isInstantiated = true;
	}

	/* IEnumerator timer (float s)
	{
		yield return new WaitForSeconds(s);
		print("wait: " + s + " seconds");
	} */
}
