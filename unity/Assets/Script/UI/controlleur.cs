using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class controlleur : MonoBehaviour {
	
	public Slider slider; 

	// Use this for initialization


	void Start(){
		
		Debug.Log ("debut");

		if (slider) { 
			GetComponent<AudioSource>().volume = PlayerPrefs.GetFloat ("volumeCourrant");
			slider.value = 	GetComponent<AudioSource>().volume;

			Debug.Log ("loader"); 

		}

	}


	public void ChargeScene(){

		string nomScene;

		//on vérifie si un nom de niveau a été enmagaziné. Si il n'y en a pas on recharge le tutoriel
		if (PlayerPrefs.HasKey ("niveauCourrant")) {

			Debug.Log ("On recharge " + PlayerPrefs.GetString ("niveauCourrant"));
			nomScene = PlayerPrefs.GetString ("niveauCourrant");

		} 

		else 
		{
			Debug.Log ("On recharge la scène par défaut");
			nomScene = "Tutoriel";
		}

		SceneManager.LoadScene (nomScene); 

	}


	 public void volume(){
		controlVolume(slider.value);

	}
	// le code ci-dessous vient de la video suivante : https://www.youtube.com/watch?v=Fwo-YAnQGy8.
	 void controlVolume(float ctrVolume){		
		GetComponent<AudioSource>().volume = ctrVolume;   
		PlayerPrefs.SetFloat("volumeCourrant", 	GetComponent<AudioSource>().volume);
		Debug.Log ("sauvegarde");
	}

}