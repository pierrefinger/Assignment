using System.Collections;
using System.Collections.Generic;
using UnityEngine;
 using UnityEngine.UI;

public class winner : MonoBehaviour {
    public Text player1Score;
    public int totalPlayer1;
    // Use this for initialization
    void Start () {
        GameObject.Find("gamescore").GetComponent<ballUpdatedLevel3>().count1 = totalPlayer1 ;
        player1Score.text = totalPlayer1.ToString();
    }
	
	// Update is called once per frame
	void Update () {
		
	}
}
