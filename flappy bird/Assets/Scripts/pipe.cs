using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour {
	void Start()
	{
		randomPosition ();
	}
	public void randomPosition(){
		this.transform.localPosition = new Vector3 (this.transform.localPosition.x,Random.Range(-0.06f,0.19f),this.transform.localPosition.z);
	}
}
