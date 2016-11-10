﻿using UnityEngine;
using System.Collections;

public class ButtonCollider : MonoBehaviour {


	public Animation animButton;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider monCollider){

		GestionEtat joueurEtat = monCollider.GetComponent<GestionEtat>();
		Debug.Log(joueurEtat.etatActif);




		if (monCollider.gameObject.tag == "Joueur" && joueurEtat.etatActif == GestionEtat.Etat.Solide) {

			//Debug.Log (joueurEtat.etatActif);
			animButton.Play ();
			//Debug.Log("debo morir");
		}


	}


}
