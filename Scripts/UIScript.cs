using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class UIScript : MonoBehaviour {

	void Update(){
		if (Input.GetMouseButtonDown (0)) 
		{
			/*sound.PlayOneShot (clip, 1f)*/;	
		}	
	}
	// Use this for initialization

	public void Menu()
	{
		SceneManager.LoadScene (0);
	}

	public void Play()
	{
		SceneManager.LoadScene (1);
	}

	public void Quit()
	{
		Application.Quit ();
	}
}
