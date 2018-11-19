using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hp : MonoBehaviour {
public float hpt;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
	public void hurt(float damage){
		this.hpt -=damage;
		if(this.hpt<0){
			this.hpt=0;
Destroy (this.gameObject);
		}	
	}
}
