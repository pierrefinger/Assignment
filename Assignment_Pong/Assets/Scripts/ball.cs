using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour {
    private Rigidbody2D rb2d;
    private Vector2 vel;

    // Use this for initialization
    void Start () {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 0);
    }
	
	// Update is called once per frame
	void Update () {
        

    }
    void GoBall()
    {
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            rb2d.AddForce(new Vector2(200, -150));
        }
        else
        {
            rb2d.AddForce(new Vector2(-200, -150));
        }
    }

}
