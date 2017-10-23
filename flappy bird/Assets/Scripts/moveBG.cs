using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveBG : MonoBehaviour {

	public GameObject bg;
	public GameObject bg2;
	public pipe p;
	private float count=10f;
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		if (GameObject.Find("Bird").transform.position.x-count>0.01) {
			bg.transform.position = new Vector3 (bg.transform.position.x+20,bg.transform.position.y,bg.transform.position.z);
			GameObject b=bg2;
			bg2 = bg;
			bg = b;
			count += 10;
			p.randomPosition ();
		}
	}
}
