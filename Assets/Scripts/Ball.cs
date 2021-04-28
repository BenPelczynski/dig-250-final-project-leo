using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
  bool start_press = false;
  public float speed;
  public Rigidbody2D rb;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
      if (start_press == false)
      {
        if (Input.GetKeyDown("space"))
        {
          start_press = true;
        }
      }
    }
}
