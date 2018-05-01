using System.Collections.Generic;
using UnityEngine;

public class generadordeenemigos : MonoBehaviour {

	public GameObject enemyprefab;
	public float ancho = 10;
	public float alto = 5;
	public float velocidad = 5.0f;
	public float direccion = 1;

	// Use this for initialization
	void Start () {
		foreach (Transform child in transform) {
			GameObject enemigo = Instantiate (enemyprefab, child.position , Quaternion.identity) as GameObject;
		enemigo.transform.parent = child;
		}
		
	}

	void OnDrawGizmos (){
		float xmin = transform.position.x - 0.5f * ancho;
		float xmax = transform.position.x + 0.5f * ancho;
		float ymin = transform.position.x - 0.5f * alto;
		float ymax = transform.position.x + 0.5f * alto;
		Gizmos.DrawLine (new Vector3 (xmin, ymin, 0), new Vector3(xmin,ymax, 0));
		Gizmos.DrawLine (new Vector3 (xmin, ymax, 0), new Vector3(xmax,ymax, 0));
		Gizmos.DrawLine (new Vector3 (xmax, ymax, 0), new Vector3(xmax,ymin, 0));
		Gizmos.DrawLine (new Vector3 (xmax, ymin, 0), new Vector3(xmin,ymin, 0));
	}
	
	// Update is called once per frame
	void Update () {
		transform.position += new Vector3 (direccion * velocidad * Time.deltaTime,0,0);
		transform.position += new Vector3 (direccion * velocidad * Time.deltaTime,-0,-0);
	}
}
