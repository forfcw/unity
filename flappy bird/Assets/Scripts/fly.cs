using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fly : MonoBehaviour {

	public float time;
	public int speed=10;
	public int count = 0;
	public float _vspeed = 0.15f;

	void Start () {
		this.gameObject.GetComponent<Rigidbody> ().velocity =new Vector3(_vspeed,0,0);
	}
	
	// Update is called once per frame
	void Update () {
		moveUp ();
		time += Time.deltaTime;
		if (time >= 1.0f / speed) {
			count++;
			time -= 1.0f / speed;
			int index = count % 3;
			this.gameObject.GetComponent<MeshRenderer> ().material.SetTextureOffset ("_MainTex", new Vector2 (index * 0.3333f, 0));
		}
	}
	private void moveUp(){
		if (Input.GetKey (KeyCode.UpArrow)) {
			Vector3 vel=this.gameObject.GetComponent<Rigidbody> ().velocity;
			this.gameObject.GetComponent<Rigidbody> ().velocity = new Vector3 (_vspeed,5,vel.z);
		}
	}
}
