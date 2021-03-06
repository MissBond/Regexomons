﻿ using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharizardCollisionScript : MonoBehaviour {

	public bool collisionWithCharizard = true;
	// Use this for initialization
	void OnCollisionEnter (Collision Col)
	{
		if(Col.gameObject.tag == "pikachuCollision")
		{
			CharizardControlScript.Instance.goCharizard = false;
			// returns pikachu back to his position
			GameObject.Find("Charizard").transform.position = GameObject.Find("IdleCharizard").transform.position;
			// pikachu starts to bop again
			GameObject.Find ("Charizard").GetComponent<Animator>().Play("CharizardIDLE");
			// Charizard should animate in attacked position
			// GameObject.FindGameObjectWithTag("CharizardGO").GetComponent<Animator>().Play("fly");
			GameObject.Find("Pikachu").GetComponent<Animator>().Play("attackFromCharizard");
			pikachuControlScript.Instance.flyAttackFromCharizard(0f, collisionWithCharizard);	
			audioControl.Instance.tackleSound.Play();	
			// CharizardControlScript.Instance.quickAttackFromPikachu(0f, collisionWithPikachu);
			// ScriptForGameController.Instance.ConfirmButton.SetActive(true);
			// put some sound
			// health bar needs to decrease
			
		}
	}
}
