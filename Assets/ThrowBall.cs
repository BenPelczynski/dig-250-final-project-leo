using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ThrowBall : MonoBehaviour
{   public GameObject ship;
    public GameObject ball;

    public float ballThrowingForce = 400f;
    private bool holdingBall = true;

    void FixedUpdate()
    {
        if (Input.GetKey("return")){
           print("pressed return key");
           
           if (holdingBall)
           {
               print("holding ball");
               holdingBall = false;
               ball.GetComponent<Rigidbody2D>().AddForce(ball.transform.forward * ballThrowingForce);
           }
       }
    }

}
