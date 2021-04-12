using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour {
    public GameObject ship;
    public GameObject ball;
    Rigidbody shipRb;
    Rigidbody2D rb2d;


    Vector3 shipLastPos;
    public Vector3 shipVelocity;

    public float ballThrowingForce = 400f;
    public bool holdingBall = true;


    private void Start ()
    {
        rb2d = ball.GetComponent<Rigidbody2D> ();
        shipRb = ship.GetComponent<Rigidbody> ();
    }

    void FixedUpdate ()
    {
        // update velocity
        shipVelocity = (shipRb.position - shipLastPos) * 50;
        shipLastPos = shipRb.position;
        //Debug.Log (shipVelocity);

        if (Input.GetKey ("return")) {
            print ("pressed return key");

            //if (holdingBall) {
            print ("holding ball");
            holdingBall = false;
            rb2d.AddForce (shipVelocity * ballThrowingForce);
            //}
        }
    }

}
