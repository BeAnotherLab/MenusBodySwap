using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManager : MonoBehaviour {

	public AudioSource instructions;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown ("space") && SceneManager.GetActiveScene().name  == "Initial" )
			SceneManager.LoadScene ("Select language");

		if (instructions.isPlaying == false)
			SceneManager.LoadScene ("Swap");
	}

	public void LoadEnglish(){
		SceneManager.LoadScene ("Instructions_en");
	}

	public void LoadGerman(){
		SceneManager.LoadScene ("Instructions_de");
	}

	public void LoadFrench(){
		SceneManager.LoadScene ("Instructions_fr");
	}

	public void LoadItalian(){
		SceneManager.LoadScene ("Instructions_it");
	}
}
