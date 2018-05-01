using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerScript : MonoBehaviour {
	public float speed = 5.0f;
	public float padding = 1.0f;

	private float xmax = -5f;
	private float xmin = 5f;

	// Use this for initialization
	void Start () {
		Camera camera = Camera.main;
		float distance = transform.position.z - camera.transform.position.z;
		xmin = camera.ViewportToWorldPoint(new Vector3(0,0, distance)).x + padding;
		xmax = camera.ViewportToWorldPoint(new Vector3(1,1, distance)).x - padding;
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKey (KeyCode.LeftArrow)) {
			transform.position = new Vector3 (Mathf.Clamp(transform.position.x -speed* 
				Time.deltaTime, xmin, xmax), transform.position.y, transform.position.z);
		}

		else if (Input.GetKey (KeyCode.RightArrow)) {
			transform.position = new Vector3 (Mathf.Clamp(transform.position.x +speed*  
				Time.deltaTime, xmin, xmax), transform.position.y, transform.position.z);
		}
	}
}