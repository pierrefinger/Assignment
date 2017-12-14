using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_1 : MonoBehaviour {
    public float speed = 5.0f;

    public float topBound = 4.1f;
    public float bottomBound = -4.1f;
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        transform.Rotate(0, 0, 50 * Time.deltaTime);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            transform.position += Vector3.up * speed * Time.deltaTime;
        }
        if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.position += Vector3.down * speed * Time.deltaTime;
        }
        if (transform.position.y > topBound)
        {
            transform.position = new Vector3(transform.position.x, topBound, 0);
        }
        else if (transform.position.y < bottomBound)
        {
            transform.position = new Vector3(transform.position.x, bottomBound, 0);
        }
    }
}

