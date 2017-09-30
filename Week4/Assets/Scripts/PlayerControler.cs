using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControler : MonoBehaviour {

    public float speed = 10.0f;

    private Rigidbody2D rBody;

	// Use this for initialization
	void Start () {
        rBody = this.GetComponent<Rigidbody2D>();
	}
	
	// Update is called once per frame
	void FixedUpdate () {
        float hMove = Input.GetAxis("Horizontal");

        Vector3 movement = new Vector3(hMove, 0, 0);

        rBody.velocity = movement * speed;
	}
}
