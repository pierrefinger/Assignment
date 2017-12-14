using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ballUpdated : MonoBehaviour
{
    private Rigidbody2D rb2d;
    private Vector2 vel;

    public Text score1;
    private int count1;
    public Text score2;
    private int count2;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("trigger1"))
        {
            Debug.Log("Trigger");
            count1 = count1 + 2;
            score1.text = count1.ToString();
            transform.position = new Vector3(0, 0, 1);
            if (count1 == 10)
            {
                Application.LoadLevel("level_3");
            }

        }
        else if (other.gameObject.CompareTag("trigger2"))
        {
            Debug.Log("Trigger2");
            count2 = count2 + 2;
            score2.text = count2.ToString();
            transform.position = new Vector3(0, 0, 1);
            if (count2 == 10)
            {
                Application.LoadLevel("level_3");
            }
        }
    }
    // Use this for initialization
    void Start()
    {
        rb2d = GetComponent<Rigidbody2D>();
        Invoke("GoBall", 0);
        count1 = 0;
        count2 = 0;
        score1.text = count1.ToString();
        score2.text = count2.ToString();
    }

    // Update is called once per frame
    void Update()
    {


    }
    void GoBall()
    {
        float rand = Random.Range(0, 2);
        if (rand < 1)
        {
            rb2d.AddForce(new Vector2(400, -300));
        }
        else
        {
            rb2d.AddForce(new Vector2(-400, -300));
        }
    }

}
