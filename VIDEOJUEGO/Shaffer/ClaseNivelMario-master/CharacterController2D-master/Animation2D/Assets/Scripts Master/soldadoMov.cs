using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soldadoMov : MonoBehaviour {
	public  bool i=false;
	public float volocity=0.003f;
	// Use this for initialization
	void Start () {
		volocity=-0.09f;
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Translate(volocity,0,0);
		cambiar(i);
	
	}
	void cambiar(bool i){
this.transform.Translate(volocity,0,0);
if(i==true){
this.transform.Rotate(new Vector3(0f,0f,0f)*Time.deltaTime);
}else{
	this.transform.Rotate(new Vector3(0f,180f,0f)*Time.deltaTime/0.9f);
}

	}
	
}
