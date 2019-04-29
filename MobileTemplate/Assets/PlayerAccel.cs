using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerAccel : MonoBehaviour
{
    public float smoothing = 0.8f;
    public float velocity = 5;
    private Vector3 currentAcceleration, initialAcceleration;
    public Rigidbody2D rb;
    public bool lose;
    public int points;
    //public Text pointsTekst;
    //public GameObject loseText;

    void Start()
    {
        initialAcceleration = Input.acceleration;
        currentAcceleration = Vector3.zero;
        rb = GetComponent<Rigidbody2D>();
        lose = false;
        points = 0;
        //loseText.SetActive(false);
        rb.gravityScale = 0;
        //StartCoroutine(AddPoints());
    }

    void Update()
    {
        currentAcceleration = Vector3.Lerp(currentAcceleration, Input.acceleration - initialAcceleration, Time.deltaTime / smoothing);
        rb.velocity = new Vector3(0,currentAcceleration.y,0) * velocity;
        //transform.Translate(0, currentAcceleration.y, 0);
        if(Input.GetKeyDown(KeyCode.Space)) {
            //Death();
        }
    }

    /* IEnumerator AddPoints() {
        while(!lose) {
            points += 1;
            pointsTekst.text = "Points: " + points;
            yield return new WaitForSeconds(1);
        }
    }

    /* public static void Death() {
        lose = true;
        loseText.SetActive(true);
        rb.gravityScale = 1;
    }*/


}
