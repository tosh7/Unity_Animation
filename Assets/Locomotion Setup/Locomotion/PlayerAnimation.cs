using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimation : MonoBehaviour {

	public Animator animator;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		animator = GetComponent<Animator> ();

		if(Input.GetKey (KeyCode.Space)){
			animator.SetBool("Jump", true);
		} else {
			animator.SetBool("Jump", false);
		}
	}
}
