using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour {
    public GameObject ship;
    public GameObject ball;
    Rigidbody shipRb;
    Rigidbody2D rb;

    Vector3 shipLastPos;
    public Vector3 shipVelocity;

    public float ballThrowingForce = 100f;
    public bool holdingBall = true;


    private void Start ()
    {
        rb = ball.GetComponent<Rigidbody2D> ();
        shipRb = ship.GetComponent<Rigidbody> ();
    }

    void FixedUpdate ()
    {
        // update velocity (from mundy help)
        shipVelocity = (shipRb.position - shipLastPos) * 50;
        shipLastPos = shipRb.position;
        //Debug.Log (shipVelocity);

        if (Input.GetKey ("return")) {
            //print ("pressed return key");

            if (holdingBall) {
            //print ("holding ball");
            	holdingBall = false;
            	rb.AddForce((shipVelocity * ballThrowingForce) + new Vector3(0f, 20f, 0f));
            	transform.parent = null;
            	print(transform.eulerAngles.z);
            }
        }
        rb.velocity = rb.velocity * new Vector2(1f, 1f);
    }

}
