using UnityEngine;
using System.Collections;

public class LoadOnClick : MonoBehaviour {
	
	public void LoadScene(string scene)
	{
		Application.LoadLevel(scene);
	}
}