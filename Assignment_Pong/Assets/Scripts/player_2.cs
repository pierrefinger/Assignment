using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_2 : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        Vector3 paddlePos = new Vector3(8.39f, this.transform.position.y, 1f);

        float mousePosInBlocks = Input.mousePosition.y / Screen.height * 30;

        paddlePos.y = Mathf.Clamp(mousePosInBlocks, -2.7f, 5.6f);
        this.transform.position = paddlePos;
    }
}
